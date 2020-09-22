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
    public partial class Form1 : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='hospital';username=root;password=xodjs5575");
        MySqlCommand command;
        public Form1()
        {
            InitializeComponent();
        }
        public void populateDOC()
        {
            string selectQuery = "SELECT doc_id as ID , major_treat as 전공 ,doc_name as 이름 , doc_gen as 성별 , doc_phone as 전화번호 , doc_email as 이메일 FROM doctor";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(selectQuery, connection);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            populateDOC();
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              //dummy Event
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            //slectionmode = Full row slect
            //autosizecolumnmode = Fill
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string insertQuery = "INSERT INTO doctor(major_treat,doc_name,doc_gen,doc_phone,doc_email) VALUES('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
            executeMyQuery(insertQuery);
            populateDOC();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string updateQuery = "UPDATE doctor SET major_treat='" + textBox2.Text + "',doc_name='" + textBox3.Text + "',doc_gen='" + textBox4.Text + "',doc_phone='" + textBox5.Text + "',doc_email='" + textBox6.Text +"' WHERE doc_id ="+int.Parse(textBox1.Text);
            executeMyQuery(updateQuery);
            populateDOC();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM doctor WHERE doc_id = " + int.Parse(textBox1.Text);
            executeMyQuery(deleteQuery);
            populateDOC();
        }

        private void 간호사ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 showForm2 = new Form2();
            showForm2.ShowDialog();
            this.Close();
        }

        private void 의사ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            populateDOC();
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
    }
}
