namespace Miner
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.russianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.amateutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.demonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.recordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._Timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalBombs = new System.Windows.Forms.Label();
            this.MinesLeft = new System.Windows.Forms.Label();
            this.TimeLeft = new System.Windows.Forms.Label();
            this.TotalTime = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MinePanel = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressBar});
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.SizingGrip = false;
            // 
            // ProgressBar
            // 
            resources.ApplyResources(this.ProgressBar, "ProgressBar");
            this.ProgressBar.Name = "ProgressBar";
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // gameToolStripMenuItem
            // 
            resources.ApplyResources(this.gameToolStripMenuItem, "gameToolStripMenuItem");
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.languageToolStripMenuItem,
            this.toolStripMenuItem1,
            this.amateutToolStripMenuItem,
            this.masterToolStripMenuItem,
            this.professionalToolStripMenuItem,
            this.demonToolStripMenuItem,
            this.toolStripMenuItem2,
            this.recordsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            // 
            // startToolStripMenuItem
            // 
            resources.ApplyResources(this.startToolStripMenuItem, "startToolStripMenuItem");
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.russianToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            // 
            // russianToolStripMenuItem
            // 
            resources.ApplyResources(this.russianToolStripMenuItem, "russianToolStripMenuItem");
            this.russianToolStripMenuItem.Name = "russianToolStripMenuItem";
            this.russianToolStripMenuItem.Click += new System.EventHandler(this.russianToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Checked = true;
            this.englishToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            // 
            // amateutToolStripMenuItem
            // 
            resources.ApplyResources(this.amateutToolStripMenuItem, "amateutToolStripMenuItem");
            this.amateutToolStripMenuItem.Name = "amateutToolStripMenuItem";
            this.amateutToolStripMenuItem.Click += new System.EventHandler(this.amateutToolStripMenuItem_Click);
            // 
            // masterToolStripMenuItem
            // 
            resources.ApplyResources(this.masterToolStripMenuItem, "masterToolStripMenuItem");
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Click += new System.EventHandler(this.masterToolStripMenuItem_Click);
            // 
            // professionalToolStripMenuItem
            // 
            resources.ApplyResources(this.professionalToolStripMenuItem, "professionalToolStripMenuItem");
            this.professionalToolStripMenuItem.Name = "professionalToolStripMenuItem";
            this.professionalToolStripMenuItem.Click += new System.EventHandler(this.professionalToolStripMenuItem_Click);
            // 
            // demonToolStripMenuItem
            // 
            resources.ApplyResources(this.demonToolStripMenuItem, "demonToolStripMenuItem");
            this.demonToolStripMenuItem.Name = "demonToolStripMenuItem";
            this.demonToolStripMenuItem.Click += new System.EventHandler(this.demonToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            // 
            // recordsToolStripMenuItem
            // 
            resources.ApplyResources(this.recordsToolStripMenuItem, "recordsToolStripMenuItem");
            this.recordsToolStripMenuItem.Name = "recordsToolStripMenuItem";
            this.recordsToolStripMenuItem.Click += new System.EventHandler(this.recordsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            // 
            // _Timer
            // 
            this._Timer.Interval = 1000;
            this._Timer.Tick += new System.EventHandler(this._UpdateTimer);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TotalBombs);
            this.panel1.Controls.Add(this.MinesLeft);
            this.panel1.Controls.Add(this.TimeLeft);
            this.panel1.Controls.Add(this.TotalTime);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Name = "panel1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // TotalBombs
            // 
            resources.ApplyResources(this.TotalBombs, "TotalBombs");
            this.TotalBombs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotalBombs.Name = "TotalBombs";
            // 
            // MinesLeft
            // 
            resources.ApplyResources(this.MinesLeft, "MinesLeft");
            this.MinesLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MinesLeft.Name = "MinesLeft";
            // 
            // TimeLeft
            // 
            resources.ApplyResources(this.TimeLeft, "TimeLeft");
            this.TimeLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TimeLeft.Name = "TimeLeft";
            // 
            // TotalTime
            // 
            resources.ApplyResources(this.TotalTime, "TotalTime");
            this.TotalTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotalTime.Name = "TotalTime";
            // 
            // panel5
            // 
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Name = "panel5";
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            this.button1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.button1_KeyUp);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Name = "panel2";
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Controls.Add(this.MinePanel);
            this.panel3.Name = "panel3";
            // 
            // MinePanel
            // 
            resources.ApplyResources(this.MinePanel, "MinePanel");
            this.MinePanel.BackColor = System.Drawing.Color.DarkGray;
            this.MinePanel.BackgroundImage = global::Miner.Properties.Resources._004;
            this.MinePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MinePanel.Name = "MinePanel";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Timer _Timer;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem amateutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem demonToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem recordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel MinePanel;
        private System.Windows.Forms.Label MinesLeft;
        private System.Windows.Forms.Label TimeLeft;
        private System.Windows.Forms.Label TotalTime;
        private System.Windows.Forms.Label TotalBombs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem russianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
    }
}

