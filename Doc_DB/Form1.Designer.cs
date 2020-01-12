namespace Doc_DB
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.테이블조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.의사ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.간호사ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.환자ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.진료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(523, 32);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 44;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(691, 584);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 10F);
            this.label1.Location = new System.Drawing.Point(42, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "의사ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 46);
            this.textBox1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(396, 25);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10F);
            this.label2.Location = new System.Drawing.Point(41, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "진료과";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(108, 92);
            this.textBox2.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(396, 25);
            this.textBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 10F);
            this.label3.Location = new System.Drawing.Point(43, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "이름";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(108, 134);
            this.textBox3.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(396, 25);
            this.textBox3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 10F);
            this.label4.Location = new System.Drawing.Point(43, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "성별";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(108, 178);
            this.textBox4.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(396, 25);
            this.textBox4.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 10F);
            this.label5.Location = new System.Drawing.Point(36, 220);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "전화번호";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(108, 218);
            this.textBox5.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(396, 25);
            this.textBox5.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 10F);
            this.label6.Location = new System.Drawing.Point(42, 258);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "이메일";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(108, 256);
            this.textBox6.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(396, 25);
            this.textBox6.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 15F);
            this.button1.Location = new System.Drawing.Point(39, 343);
            this.button1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 112);
            this.button1.TabIndex = 13;
            this.button1.Text = "INSERT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("굴림", 15F);
            this.button2.Location = new System.Drawing.Point(196, 343);
            this.button2.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 112);
            this.button2.TabIndex = 14;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("굴림", 15F);
            this.button3.Location = new System.Drawing.Point(361, 343);
            this.button3.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 112);
            this.button3.TabIndex = 15;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.테이블조회ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1236, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 테이블조회ToolStripMenuItem
            // 
            this.테이블조회ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.의사ToolStripMenuItem,
            this.간호사ToolStripMenuItem,
            this.환자ToolStripMenuItem,
            this.진료ToolStripMenuItem});
            this.테이블조회ToolStripMenuItem.Name = "테이블조회ToolStripMenuItem";
            this.테이블조회ToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.테이블조회ToolStripMenuItem.Text = "테이블조회";
            // 
            // 의사ToolStripMenuItem
            // 
            this.의사ToolStripMenuItem.Name = "의사ToolStripMenuItem";
            this.의사ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.의사ToolStripMenuItem.Text = "의사";
            this.의사ToolStripMenuItem.Click += new System.EventHandler(this.의사ToolStripMenuItem_Click);
            // 
            // 간호사ToolStripMenuItem
            // 
            this.간호사ToolStripMenuItem.Name = "간호사ToolStripMenuItem";
            this.간호사ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.간호사ToolStripMenuItem.Text = "간호사";
            this.간호사ToolStripMenuItem.Click += new System.EventHandler(this.간호사ToolStripMenuItem_Click);
            // 
            // 환자ToolStripMenuItem
            // 
            this.환자ToolStripMenuItem.Name = "환자ToolStripMenuItem";
            this.환자ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.환자ToolStripMenuItem.Text = "환자";
            this.환자ToolStripMenuItem.Click += new System.EventHandler(this.환자ToolStripMenuItem_Click);
            // 
            // 진료ToolStripMenuItem
            // 
            this.진료ToolStripMenuItem.Name = "진료ToolStripMenuItem";
            this.진료ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.진료ToolStripMenuItem.Text = "진료";
            this.진료ToolStripMenuItem.Click += new System.EventHandler(this.진료ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 622);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "Form1";
            this.Text = "의사 테이블";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 테이블조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 의사ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 간호사ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 환자ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 진료ToolStripMenuItem;
    }
}

