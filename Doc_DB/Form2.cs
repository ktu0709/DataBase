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
    public partial class Form2 : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='hospital';username=root;password=xodjs5575");
        MySqlCommand command;
        public Form2()
        {
            InitializeComponent();
        }
        public void populateNUR()
        {
            string selectQuery = "SELECT * FROM nurse";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            populateNUR();
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

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e) //INSERT
        {
            string insertQuery = "INSERT INTO nurse(major_job,nur_name,nur_gen,nur_phone,nur_email,doc_id) VALUES('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
            executeMyQuery(insertQuery);
            populateNUR();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE nurse SET major_job='" + textBox2.Text + "',nur_name='" + textBox3.Text + "',nur_gen='" + textBox4.Text + "',nur_phone='" + textBox5.Text + "',nur_email='" + textBox6.Text + "',doc_id='" + textBox7.Text + "' WHERE nur_id =" + int.Parse(textBox1.Text);
            executeMyQuery(updateQuery);
            populateNUR();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM nurse WHERE nur_id = " + int.Parse(textBox1.Text);
            executeMyQuery(deleteQuery);
            populateNUR();
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
            populateNUR();
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
            this.Visible = false;
            Form4 showForm4 = new Form4();
            showForm4.ShowDialog();
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
