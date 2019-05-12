using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Miner.Records;
using Miner.Code;
using System.Globalization;


namespace Miner
{
    public struct Coords
    {
        public int A;
        public int B;

        public Coords(int a, int b) {
            this.A = a;
            this.B = b;
        }
    }

    public partial class MainForm : Form, ILanguageChangable
    {
        // Окошко с рекордами
        Form RecordsForm;

        // Окошко для ввода имени при добавлении нового рекорда
        Form NewRecord;

        // Все кнопки
        private List<Mine> Buttons = new List<Mine>();

        // Количество бомб
        private int Count
        {
            get
            {
                return _Count;
            }
            set
            {
                _Count = value;
                this.TotalBombs.Text = value.ToString();
            }
        }

        private int _Count = 0;


        // Время на игру - потом будем задаваться программно
        public int GameTime
        {
            get
            {
                return _GameTime;
            }
            set
            {
                _GameTime = value;
                this.TotalTime.Text = value.ToString();
            }
        }

        private int _GameTime = 50;


        public int GameTimeLeft
        {
            get
            {
                return _GameTimeLeft;
            }
            set
            {
                _GameTimeLeft = value;
                this.TimeLeft.Text = (((_GameTime - _GameTimeLeft).ToString().Length < 2) ? "0" : "") + (_GameTime - _GameTimeLeft).ToString() + " / " + ((_GameTimeLeft.ToString().Length < 2) ? "0" : "") + _GameTimeLeft.ToString();
            }
        }

        private int _GameTimeLeft = 0;


        // Размер кнопки по ширине
        public readonly int MineWidth = 30;

        // Размер кнопки по высоте
        public readonly int MineHeight = 30;

        // Количество кнопок по оси X
        private int X
        {
            get;
            set;
        }

        // Количество кнопок по оси Y
        private int Y
        {
            get;
            set;
        }

        public MainForm()
        {
            if (!String.IsNullOrEmpty(Properties.Settings.Default.Language))
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = (Properties.Settings.Default.Language == System.Globalization.CultureInfo.GetCultureInfo("ru-RU").ToString()) ? System.Globalization.CultureInfo.GetCultureInfo("ru-RU") : System.Globalization.CultureInfo.GetCultureInfo("en-US");
                System.Threading.Thread.CurrentThread.CurrentCulture = (Properties.Settings.Default.Language == System.Globalization.CultureInfo.GetCultureInfo("ru-RU").ToString()) ? System.Globalization.CultureInfo.GetCultureInfo("ru-RU") : System.Globalization.CultureInfo.GetCultureInfo("en-US");
            }
            else
            {
                // по-умолчанию язык программы английский
                System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");
            }

            InitializeComponent();
            Mines.OnMarked += Mines_OnMarked;
            Mines.OnVictory += Mines_OnVictory;
            Mines.OnFail += Mines_OnFail;
            RecordsForm = new RecordsForms();
            NewRecord = new AddNameForm();
            AmateurSetup();

            if (!String.IsNullOrEmpty(Properties.Settings.Default.Language))
            {
                russianToolStripMenuItem.CheckState = ((Properties.Settings.Default.Language == System.Globalization.CultureInfo.GetCultureInfo("ru-RU").ToString()) ? CheckState.Checked : CheckState.Unchecked);
                englishToolStripMenuItem.CheckState = ((Properties.Settings.Default.Language == System.Globalization.CultureInfo.GetCultureInfo("en-US").ToString()) ? CheckState.Checked : CheckState.Unchecked);

            }
            else
            {
                russianToolStripMenuItem.CheckState = CheckState.Unchecked;
                englishToolStripMenuItem.CheckState = CheckState.Checked;
            }
        }

        private void Mines_OnFail(int mark)
        {
            _Timer.Stop();
            _Timer.Enabled = false;
            MessageBox.Show(russianToolStripMenuItem.CheckState == CheckState.Checked ? Translation_ru_RU.msgLost : Translation_en_US.msgLost); // Ты лошара
        }

        public void StartGame()
        {

            TotalTime.Text = GameTime.ToString();
            TotalBombs.Text = Count.ToString();

            ProgressBar.Value = 0;

            MinePanel.BackgroundImage = null;

            Dictionary<Coords, Mine> boxes = new Dictionary<Coords, Mine>();

            int a, b;

            MinePanel.Controls.Clear();
            for (a = 0; a < X; a++)
            {
                for (b = 0; b < Y; b++)
                {
                    Mine mine = new Mine(a * MineWidth, b * MineHeight, MineWidth, MineHeight, a, b);
                    MinePanel.Controls.Add(mine);
                    boxes.Add(new Coords(a, b), mine);
                }

                ProgressBar.Value = (int)Math.Round((double)50 * a / X);
            }

            Mines.Init(boxes, X, Y);

            Random random = new Random();
            int generated = 0;

            while (generated < Count)
            {
                a = random.Next(0, X);
                b = random.Next(0, Y);
                if (!(Mines.Boxes[new Coords(a, b)].IsBomb))
                {
                    Mines.Boxes[new Coords(a, b)].IsBomb = true;
                    generated++;
                }
                ProgressBar.Value = (int)Math.Round((double)50 * generated / Count) + 50;
            }

            Mines.Marked = 0;
            Mines.IsFinished = false;
            Mines.IsBombed = false;

            _GameTimeLeft = GameTime;

            if (_Timer != null)
            {
                GameTimeLeft = GameTime;
                _Timer.Enabled = true;
                _Timer.Start();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void Mines_OnVictory(int mark)
        {

            _Timer.Stop();
            _Timer.Enabled = false;
            Records.CurrentRecord = mark;
            Boolean isRecord = false;

            switch (CurrentLevel)
            {
                case (Levels.Amateur):
                    isRecord = Records.IsNewRecord(Records.AmateurList, GameTime - GameTimeLeft);
                    break;
                case (Levels.Master):
                    isRecord = Records.IsNewRecord(Records.MasterList, GameTime - GameTimeLeft);
                    break;
                case (Levels.Professional):
                    isRecord = Records.IsNewRecord(Records.ProfessionalList, GameTime - GameTimeLeft);
                    break;
                case (Levels.Demon):
                    isRecord = Records.IsNewRecord(Records.DemonList, GameTime - GameTimeLeft);
                    break;
                default:
                    isRecord = false;
                    break;
            }

            if (isRecord)
            {
                Records.CurrentRecord = GameTime - GameTimeLeft;
                NewRecord.Show();
            }
        }

        private void Mines_OnMarked(int mark)
        {
            //this.CounterLabel.Text = ((mark.ToString().Length < 2) ? "0":"") + mark.ToString();
            this.MinesLeft.Text = (((Count - mark).ToString().Length < 2) ? "0" : "") + (Count - mark).ToString() + " / " + ((mark.ToString().Length < 2) ? "0" : "") + mark.ToString();

        }

        private void _UpdateTimer(object sender, EventArgs e)
        {
            GameTimeLeft--;
            if (GameTimeLeft == 0)
            {
                _StopGame();

                MessageBox.Show(russianToolStripMenuItem.CheckState == CheckState.Checked ? Translation_ru_RU.msgTimeIsUp : Translation_en_US.msgTimeIsUp); // Время истекло
            }
        }

        private void _StopGame(Boolean clear = false)
        {
            _Timer.Stop();
            _Timer.Enabled = false;
            Mines.IsFinished = true;

            if (clear)
            {
                Mines.Boxes.Clear();
                MinePanel.Controls.Clear();
                MinePanel.BackgroundImage = ((System.Drawing.Image)(Properties.Resources._004));
                MinePanel.BackgroundImageLayout = ImageLayout.Center;

            }
        }

        private void SetupWidthAndHeight()
        {
            this.Width = MineWidth * X
                        + panel1.Width
                        + panel1.Margin.Left
                        + panel1.Margin.Left
                        + panel3.Margin.Left
                        + panel3.Margin.Left
                        + MinePanel.Margin.Left
                        + MinePanel.Margin.Right + 5;
            this.Height = MineHeight * Y
                        + menuStrip1.Height
                        + menuStrip1.Padding.Top
                        + menuStrip1.Padding.Bottom
                        + menuStrip1.Margin.Top
                        + menuStrip1.Margin.Bottom
                        + statusStrip1.Height
                        + statusStrip1.Margin.Top
                        + statusStrip1.Margin.Bottom
                        + panel3.Margin.Top
                        + panel3.Margin.Bottom
                        + MinePanel.Margin.Top
                        + MinePanel.Margin.Bottom + 30;
        }

        private void AmateurSetup()
        {
            GameTime = 100;
            X = 10;
            Y = 10;
            Count = 10;
            CurrentLevel = Levels.Amateur;
            SetupWidthAndHeight();
        }

        private void MasterSetup()
        {
            GameTime = 100;
            X = 15;
            Y = 10;
            Count = 20;
            CurrentLevel = Levels.Master;
            SetupWidthAndHeight();
        }

        private void ProfessionalSetup()
        {
            GameTime = 350;
            X = 25;
            Y = 15;
            Count = 70;
            SetupWidthAndHeight();
            CurrentLevel = Levels.Professional;
        }

        private void DemonSetup()
        {
            GameTime = 700;
            X = 40;
            Y = 25;
            Count = 200;
            SetupWidthAndHeight();
            CurrentLevel = Levels.Demon;
        }

        private void amateutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AmateurSetup();
            _StopGame(true);
        }

        private void masterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasterSetup();
            _StopGame(true);
        }

        private void professionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfessionalSetup();
            _StopGame(true);
        }

        private void demonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DemonSetup();
            _StopGame(true);
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinePanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            _Timer.Stop();
            _Timer.Enabled = false;
        }

        private void button1_KeyUp(object sender, KeyEventArgs e)
        {
            _Timer.Start();
            _Timer.Enabled = true;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            _Timer.Stop();
            _Timer.Enabled = false;
            MinePanel.Visible = false;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            _Timer.Start();
            _Timer.Enabled = true;
            MinePanel.Visible = true;
        }

        private void ShowRecords(Levels level)
        {
            //RecordsForm.Controls.Find("tabControl1", false)[0].Select();
            //((TabControl)RecordsForm.Controls.Find("tabControl1", false)[0]).SelectedIndex = (int)level;
            RecordsForm.Show();
        }

        private void recordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRecords(CurrentLevel);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
        }

        private void russianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            englishToolStripMenuItem.CheckState = CheckState.Unchecked;
            englishToolStripMenuItem.Checked = false;
            russianToolStripMenuItem.CheckState = CheckState.Checked;
            russianToolStripMenuItem.Checked = true;
            ChangeLanguage(Helpers.AvailableLocalizations.Russian);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Language = russianToolStripMenuItem.CheckState.HasFlag(CheckState.Checked) ? System.Globalization.CultureInfo.GetCultureInfo("ru-RU").ToString() : System.Globalization.CultureInfo.GetCultureInfo("en-US").ToString();
            Properties.Settings.Default.Save();
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            russianToolStripMenuItem.CheckState = CheckState.Unchecked;
            russianToolStripMenuItem.Checked = false;
            englishToolStripMenuItem.CheckState = CheckState.Checked;
            englishToolStripMenuItem.Checked = true;

            ChangeLanguage(Helpers.AvailableLocalizations.English);
        }

        public void ChangeLanguage(Helpers.AvailableLocalizations localization)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo(Helpers.GetEnumDescriptions(localization));
            Miner.Properties.Settings.Default.Language = System.Globalization.CultureInfo.GetCultureInfo(Helpers.GetEnumDescriptions(localization)).ToString();

            var resources = new ComponentResourceManager(typeof(MainForm));
            CultureInfo cultureInfo = new CultureInfo(Helpers.GetEnumDescriptions(localization));

            ApplyCultureToControl(resources, this, cultureInfo);

            foreach (var item in menuStrip1.Items)
            {
                resources.ApplyResources(item, ((ToolStripItem)item).Name, cultureInfo);
            }

            foreach (var item in gameToolStripMenuItem.DropDownItems)
            {
                resources.ApplyResources(item, ((ToolStripItem)item).Name, cultureInfo);
            }

            resources.ApplyResources(this, "$this", cultureInfo);

            switch (CurrentLevel)
            {
                case Levels.Amateur:
                    AmateurSetup();
                    break;

                case Levels.Master:
                    MasterSetup();
                    break;

                case Levels.Professional:
                    ProfessionalSetup();
                    break;

                case Levels.Demon:
                    DemonSetup();
                    break;
            }
        }

        private void ApplyCultureToControl(ComponentResourceManager resourceManager, Control c, CultureInfo cultureInfo)
        {
            resourceManager.ApplyResources(c, c.Name, cultureInfo);

            foreach (Control control in c.Controls)
            {
                ApplyCultureToControl(resourceManager, control, cultureInfo);
            }
        }
    }
}
