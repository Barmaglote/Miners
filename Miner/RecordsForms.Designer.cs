namespace Miner
{
    partial class RecordsForms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridAmateur = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataSet1 = new System.Data.DataSet();
            this.gridMaster = new System.Windows.Forms.DataGridView();
            this.gridProfessional = new System.Windows.Forms.DataGridView();
            this.gridDemon = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAmateur)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProfessional)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDemon)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(399, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(462, 310);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridAmateur);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(454, 284);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Amateur";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gridAmateur
            // 
            this.gridAmateur.AllowUserToAddRows = false;
            this.gridAmateur.AllowUserToDeleteRows = false;
            this.gridAmateur.AllowUserToResizeColumns = false;
            this.gridAmateur.AllowUserToResizeRows = false;
            this.gridAmateur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridAmateur.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridAmateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAmateur.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridAmateur.EnableHeadersVisualStyles = false;
            this.gridAmateur.Location = new System.Drawing.Point(6, 6);
            this.gridAmateur.MultiSelect = false;
            this.gridAmateur.Name = "gridAmateur";
            this.gridAmateur.ReadOnly = true;
            this.gridAmateur.RowHeadersVisible = false;
            this.gridAmateur.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridAmateur.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridAmateur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridAmateur.ShowEditingIcon = false;
            this.gridAmateur.Size = new System.Drawing.Size(442, 272);
            this.gridAmateur.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gridMaster);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(454, 284);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Master";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gridProfessional);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(454, 284);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Professional";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.gridDemon);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(454, 284);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Demon";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // gridMaster
            // 
            this.gridMaster.AllowUserToAddRows = false;
            this.gridMaster.AllowUserToDeleteRows = false;
            this.gridMaster.AllowUserToResizeColumns = false;
            this.gridMaster.AllowUserToResizeRows = false;
            this.gridMaster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridMaster.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMaster.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridMaster.EnableHeadersVisualStyles = false;
            this.gridMaster.Location = new System.Drawing.Point(6, 6);
            this.gridMaster.MultiSelect = false;
            this.gridMaster.Name = "gridMaster";
            this.gridMaster.ReadOnly = true;
            this.gridMaster.RowHeadersVisible = false;
            this.gridMaster.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridMaster.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridMaster.ShowEditingIcon = false;
            this.gridMaster.Size = new System.Drawing.Size(442, 272);
            this.gridMaster.TabIndex = 1;
            // 
            // gridProfessional
            // 
            this.gridProfessional.AllowUserToAddRows = false;
            this.gridProfessional.AllowUserToDeleteRows = false;
            this.gridProfessional.AllowUserToResizeColumns = false;
            this.gridProfessional.AllowUserToResizeRows = false;
            this.gridProfessional.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridProfessional.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridProfessional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProfessional.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridProfessional.EnableHeadersVisualStyles = false;
            this.gridProfessional.Location = new System.Drawing.Point(6, 6);
            this.gridProfessional.MultiSelect = false;
            this.gridProfessional.Name = "gridProfessional";
            this.gridProfessional.ReadOnly = true;
            this.gridProfessional.RowHeadersVisible = false;
            this.gridProfessional.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridProfessional.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridProfessional.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridProfessional.ShowEditingIcon = false;
            this.gridProfessional.Size = new System.Drawing.Size(442, 272);
            this.gridProfessional.TabIndex = 1;
            // 
            // gridDemon
            // 
            this.gridDemon.AllowUserToAddRows = false;
            this.gridDemon.AllowUserToDeleteRows = false;
            this.gridDemon.AllowUserToResizeColumns = false;
            this.gridDemon.AllowUserToResizeRows = false;
            this.gridDemon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridDemon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridDemon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDemon.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridDemon.EnableHeadersVisualStyles = false;
            this.gridDemon.Location = new System.Drawing.Point(6, 6);
            this.gridDemon.MultiSelect = false;
            this.gridDemon.Name = "gridDemon";
            this.gridDemon.ReadOnly = true;
            this.gridDemon.RowHeadersVisible = false;
            this.gridDemon.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridDemon.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDemon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridDemon.ShowEditingIcon = false;
            this.gridDemon.Size = new System.Drawing.Size(442, 272);
            this.gridDemon.TabIndex = 1;
            // 
            // RecordsForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 363);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RecordsForms";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Records";
            this.Load += new System.EventHandler(this.RecordsFormcs_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAmateur)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProfessional)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDemon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView gridAmateur;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.DataGridView gridMaster;
        private System.Windows.Forms.DataGridView gridProfessional;
        private System.Windows.Forms.DataGridView gridDemon;
    }
}