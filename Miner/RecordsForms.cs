using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miner
{
    public partial class RecordsForms : Form
    {
        public RecordsForms()
        {
            InitializeComponent();
        }

        private void RecordsFormcs_Load(object sender, EventArgs e)
        {
            DataTable  table = MakeNamesTable("Amateur");            

            foreach (var rec in Records.AmateurList)
            {
                DataRow row;
                row = table.NewRow();

                row["Name"] = rec.Name;
                row["Time"] = rec.Time;
                table.Rows.Add(row);
            }

            gridAmateur.DataSource = table;

            table = MakeNamesTable("Master");

            foreach (var rec in Records.MasterList)
            {
                DataRow row;
                row = table.NewRow();

                row["Name"] = rec.Name;
                row["Time"] = rec.Time;
                table.Rows.Add(row);
            }

            gridMaster.DataSource = table;

            table = MakeNamesTable("Professional");

            foreach (var rec in Records.MasterList)
            {
                DataRow row;
                row = table.NewRow();

                row["Name"] = rec.Name;
                row["Time"] = rec.Time;
                table.Rows.Add(row);
            }

            gridProfessional.DataSource = table;

            table = MakeNamesTable("Demon");

            foreach (var rec in Records.MasterList)
            {
                DataRow row;
                row = table.NewRow();

                row["Name"] = rec.Name;
                row["Time"] = rec.Time;
                table.Rows.Add(row);
            }

            gridDemon.DataSource = table;


        }

        private DataTable MakeNamesTable(String name)
        {
            // Create a new DataTable titled 'Names.'
            DataTable namesTable = new DataTable(name);

            // Add column objects to the table.
            DataColumn fTime = new DataColumn();
            fTime.DataType = System.Type.GetType("System.Int32");
            fTime.ColumnName = "Time";
            fTime.AutoIncrement = false;
            namesTable.Columns.Add(fTime);

            DataColumn fNameColumn = new DataColumn();
            fNameColumn.DataType = System.Type.GetType("System.String");
            fNameColumn.ColumnName = "Name";
            fNameColumn.DefaultValue = "Name";
            namesTable.Columns.Add(fNameColumn);

            // Return the new DataTable.
            return namesTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
