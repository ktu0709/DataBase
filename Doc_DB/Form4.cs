using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Doc_DB
{
    public partial class Form4 : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='hospital';username=root;password=xodjs5575");
        MySqlCommand command;
        public Form4()
        {
            InitializeComponent();
        }
        public void populateDIA()
        {
            string selectQuery = "SELECT treat_id as 진료ID,doc_name as 담당의사,pat_name as 환자이름 ,treat_contents as 진료내용, treat_date as 진료날짜 FROM diagnosis";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public void executeMyQuery(string query)
        {
            try
            {
                openConnection();
                command = new MySqlCommand(query, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query Executed");
                }

                else
                {
                    MessageBox.Show("Query Not Executed");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //무시
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            populateDIA();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO diagnosis(doc_name,pat_name,treat_contents,treat_date) VALUES('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            executeMyQuery(insertQuery);
            populateDIA();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE diagnosis SET doc_name='" + textBox2.Text + "',pat_name='" + textBox3.Text + "',treat_contents='" + textBox4.Text + "',treat_date='" + textBox5.Text + "' WHERE treat_id =" + int.Parse(textBox1.Text);
            executeMyQuery(updateQuery);
            populateDIA();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM diagnosis WHERE treat_id = " + int.Parse(textBox1.Text);
            executeMyQuery(deleteQuery);
            populateDIA();
        }

        private void 의사ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 showForm1 = new Form1();
            showForm1.ShowDialog();
            this.Close();
        }

        private void 간호사ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 showForm2 = new Form2();
            showForm2.ShowDialog();
            this.Close();
        }

        private void 환자ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 showForm3 = new Form3();
            showForm3.ShowDialog();
            this.Close();
        }

        private void 진료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            populateDIA();
        }
    }
}
