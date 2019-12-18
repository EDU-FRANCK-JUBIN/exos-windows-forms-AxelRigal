using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {



        public Form4()
        {
            InitializeComponent();
            List<Artiste> listArtiste = new List<Artiste>();
            for(int j = 0; j < 9; j++)
            {
                List<Chanson> listChanson = new List<Chanson>();
                for (int i = 0; i < 9; i++)
                {
                    Chanson c = new Chanson("titre" + i);

                    listChanson.Add(c);

                }
                Artiste a = new Artiste("Artiste" + j, listChanson);
                listArtiste.Add(a);
            }

            dataGridView1.DataSource =listArtiste;
        }

        private void Form4_Load(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*MessageBox.Show("LOOOOOOOOOOOOOOOOL");
            DataGridView dg = sender as DataGridView;
            Artiste artiste = (Artiste)dg.SelectedRows[e.RowIndex].DataBoundItem;
            dataGridView2.DataSource = artiste.ListChanson;*/

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*MessageBox.Show("LOOOOOOOOOOOOOOOOL");
            DataGridView dg = sender as DataGridView;
            Artiste artiste = (Artiste)dg.SelectedRows[e.RowIndex].DataBoundItem;
            dataGridView2.DataSource = artiste.ListChanson;*/
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dg = (DataGridView) sender;
            DataGridViewRow  dataRow = dg.Rows[e.RowIndex];
            Artiste artiste = (Artiste)dataRow.DataBoundItem;
            dataGridView2.DataSource = artiste.ListChanson;
        }
    }
}
