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
    public partial class Form3 : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='hospital';username=root;password=xodjs5575");
        MySqlCommand command;
        public Form3()
        {
            InitializeComponent();
        }
        public void populatePAT()
        {
            string selectQuery = "SELECT pat_id as 환자ID , pat_addr as 주소 ,pat_name as 환자이름,pat_gen as 성별,pat_phone as 전화번호 ,pat_email as 이메일 , major_treat as 진료과,doc_name as 담당의사,nur_name as 담당간호사  FROM hospital.patient";
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
        private void Form3_Load(object sender, EventArgs e)
        {
            populatePAT();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO patient(pat_addr,pat_name,pat_gen,pat_phone,pat_email,major_treat,doc_name,nur_name) VALUES('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "')";
            executeMyQuery(insertQuery);
            populatePAT();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE patient SET pat_addr='" + textBox2.Text + "',pat_name='" + textBox3.Text + "',pat_gen='" + textBox4.Text + "',pat_phone='" + textBox5.Text + "',pat_email='" + textBox6.Text + "',major_treat='" + textBox7.Text + "',doc_name='" + textBox8.Text + "',nur_name='" + textBox9.Text + "' WHERE pat_id =" + int.Parse(textBox1.Text);
            executeMyQuery(updateQuery);
            populatePAT();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM patient WHERE pat_id = " + int.Parse(textBox1.Text);
            executeMyQuery(deleteQuery);
            populatePAT();
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
            populatePAT();
        }

        private void 진료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form4 showForm4 = new Form4();
            showForm4.ShowDialog();
            this.Close();
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
            textBox8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }
    }
}
