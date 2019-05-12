using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Miner.Records;


namespace Miner
{
    public partial class AddNameForm : Form
    {
        public AddNameForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = (textBox1.Text.Length > 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (CurrentLevel)
            {
                case (Levels.Amateur):
                    Records.AddRecord(Records.AmateurList, new RecordItem(textBox1.Text, Records.CurrentRecord));
                    break;
                case (Levels.Master):
                    Records.AddRecord(Records.MasterList, new RecordItem(textBox1.Text, Records.CurrentRecord));
                    break;
                case (Levels.Professional):
                    Records.AddRecord(Records.ProfessionalList, new RecordItem(textBox1.Text, Records.CurrentRecord));
                    break;
                case (Levels.Demon):
                    Records.AddRecord(Records.DemonList, new RecordItem(textBox1.Text, Records.CurrentRecord));
                    break;
                default:
                    break;
            }

            this.Hide();
        }

        private void AddNameForm_Shown(object sender, EventArgs e)
        {
            textBox2.Text = (CurrentRecord != 999) ? CurrentRecord.ToString() : String.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
