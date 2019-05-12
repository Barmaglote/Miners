using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miner
{
    public class Mine : Button
    {
        // Цвета для меток 
        private readonly List<Color> LabelColors = new List<Color>() { Color.Black, Color.Green, Color.Blue, Color.Violet, Color.YellowGreen, Color.Yellow, Color.Orange, Color.OrangeRed, Color.Red, Color.Black };

        public Boolean IsBomb
        {
            get
            {
                return _IsBomb;
            }
            set
            {
                _IsBomb = value;
            }
        }

        private Boolean IsLeftPressed = false;
        private Boolean IsRightPressed = false;

        public Boolean IsMarked
        {
            get
            {
                return _IsMarked;
            }
            set
            {
                this._IsMarked = value;

                if (this._IsMarked)
                {
                    this.BackgroundImage = ((System.Drawing.Image)(Properties.Resources._001));
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                    Mines.Marked++;
                }
                else
                {
                    this.BackgroundImage = null;
                    Mines.Marked--;
                }
                Mines.CheckVictoryState();
            }
        }

        private Boolean _IsMarked = false;

        public int A
        {
            get;
            set;
        }

        public int B
        {
            get;
            set;
        }

        private Boolean _IsBomb = false;


        // Количество бомб в округе
        public int? Arround
        {
            get
            {
                if (_Arround != null) return _Arround;
                _Arround = Mines.GetBombsCount(A, B);
                return _Arround;
            }
        }

        private int? _Arround;

        public Boolean IsOpened
        {
            get
            {
                return _IsOpened;
            }
            set
            {
                this._IsOpened = true;
                this.FlatStyle = FlatStyle.Standard;
                Mines.CheckVictoryState();
            }
        }

        public Boolean _IsOpened = false;

        public Mine(int x, int y, int w, int h, int a, int b)
        {
            this.Width = w;
            this.Height = h;
            this.Left = x;
            this.Top = y;
            this.CreateControl();
            this.A = a;
            this.B = b;
            this.IsBomb = false;
            this.MouseUp += Mine_MouseUp;
            this.MouseDown += Mine_MouseDown;
            this.FlatStyle = FlatStyle.Popup;
            this.Font = new Font("Arial", 14, FontStyle.Bold);
            this.BackColor = Color.DarkSlateGray;
        }

        private void Mine_MouseDown(object sender, MouseEventArgs e)
        {
            if (Mines.IsFinished) return;

            if (e.Button == MouseButtons.Left)
                IsLeftPressed = true;
            if (e.Button == MouseButtons.Right)
                IsRightPressed = true;

            switch (e.Button)
            {
                case MouseButtons.Left:
                    if (!this.IsMarked && !IsRightPressed) MineLeftClick(sender, e);
                    break;
                case MouseButtons.Right:
                    if (!IsLeftPressed) MineRightClick(sender, e);
                    break;
            }

            if (IsLeftPressed && IsRightPressed)
            {
                AutoSearch();
            }
        }

        private void AutoSearch()
        {
            List<Mine> neiboughers = Mines.GetNeiboughers(A, B);
            neiboughers.ForEach(x => x.FlatStyle = FlatStyle.Standard);
            if (this.Arround != 0 && this.Arround == neiboughers.Where(m => m.IsMarked && m.IsBomb).ToList<Mine>().Count && this.Arround == neiboughers.Where(m => m.IsMarked).ToList<Mine>().Count)
            {
                neiboughers.ForEach(x => x.AutoOpen());
            }
        }

        private void Mine_MouseUp(object sender, MouseEventArgs e)
        {
            if (Mines.IsFinished) return;

            if (IsLeftPressed && IsRightPressed)
            {
                List<Mine> neiboughers = Mines.GetNeiboughers(A, B);
                neiboughers.Where(x => !x.IsOpened).ToList<Mine>().ForEach(x => x.FlatStyle = FlatStyle.Popup);
            }

            if (IsLeftPressed != IsRightPressed)
            {
                IsLeftPressed = false;
                IsRightPressed = false;
            }
        }

        private void MineRightClick(object sender, MouseEventArgs e)
        {
            if (Mines.IsFinished) return;

            if (!this.IsOpened)
                this.IsMarked = !(this._IsMarked);
        }

        public void Check()
        {
            if (Mines.IsFinished) return;

            if (!this.IsBomb && !this.IsOpened && this.Arround == 0)
            {
                this.Open();
                Mines.GetNeiboughers(A, B).ForEach(x => x.Check());
            }
        }

        public void AutoOpen()
        {
            if (this.IsMarked)
            {
                return;
            }

            if (!this.IsOpened)
            {
                this.IsOpened = true;
                this.BackgroundImage = null;
                this.BackColor = Color.Silver;

                if (Arround != null)
                {
                    this.Text = (Arround == 0) ? String.Empty : Arround.ToString();
                    this.ForeColor = LabelColors[(int)Arround];
                }
                else
                {
                    this.Text = String.Empty;
                    this.ForeColor = Color.Black;
                }
            }
        }

        public void Open()
        {
            if (Mines.IsFinished) return;

            if (this.IsBomb)
            {
                this.BackgroundImage = ((System.Drawing.Image)(Properties.Resources._004));
                this.BackgroundImageLayout = ImageLayout.Stretch;
                this.BackColor = Color.Silver;
                return;
            }

            if (!this.IsOpened)
            {
                this.IsOpened = true;
                this.BackgroundImage = null;
                this.BackColor = Color.Silver;

                if (Arround != null)
                {
                    this.Text = (Arround == 0) ? String.Empty : Arround.ToString();
                    this.ForeColor = LabelColors[(int)Arround];
                }
                else
                {
                    this.Text = String.Empty;
                    this.ForeColor = Color.Black;
                }
            }
        }

        private void MineLeftClick(object sender, MouseEventArgs e)
        {
            if (Mines.IsFinished) return;

            this.Check();
            this.Open();


            if (this.IsBomb)
            {
                Mines.OpenAll();
                this.BackColor = Color.Red;
                Mines.IsFinished = true;
                Mines.IsBombed = true;
            }
        }
    }
}
