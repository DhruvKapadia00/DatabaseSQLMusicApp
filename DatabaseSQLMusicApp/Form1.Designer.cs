namespace DatabaseSQLMusicApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button2 = new Button();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            txt_description = new TextBox();
            txt_ImageURL = new TextBox();
            txt_year = new TextBox();
            txt_artist = new TextBox();
            txt_album = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(633, 112);
            button2.Name = "button2";
            button2.Size = new Size(262, 48);
            button2.TabIndex = 1;
            button2.Text = "Load Albums";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(633, 184);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 92;
            dataGridView1.Size = new Size(1503, 478);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1158, 115);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(681, 43);
            textBox1.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(1861, 115);
            button3.Name = "button3";
            button3.Size = new Size(222, 47);
            button3.TabIndex = 5;
            button3.Text = "Search";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(2170, 184);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(467, 478);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txt_description);
            groupBox1.Controls.Add(txt_ImageURL);
            groupBox1.Controls.Add(txt_year);
            groupBox1.Controls.Add(txt_artist);
            groupBox1.Controls.Add(txt_album);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(43, 115);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(539, 478);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Album";
            // 
            // button1
            // 
            button1.Location = new Point(19, 383);
            button1.Name = "button1";
            button1.Size = new Size(173, 52);
            button1.TabIndex = 10;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt_description
            // 
            txt_description.Location = new Point(198, 312);
            txt_description.Name = "txt_description";
            txt_description.Size = new Size(305, 43);
            txt_description.TabIndex = 9;
            // 
            // txt_ImageURL
            // 
            txt_ImageURL.Location = new Point(198, 255);
            txt_ImageURL.Name = "txt_ImageURL";
            txt_ImageURL.Size = new Size(305, 43);
            txt_ImageURL.TabIndex = 8;
            txt_ImageURL.TextChanged += txt_ImageURL_TextChanged;
            // 
            // txt_year
            // 
            txt_year.Location = new Point(198, 192);
            txt_year.Name = "txt_year";
            txt_year.Size = new Size(305, 43);
            txt_year.TabIndex = 7;
            // 
            // txt_artist
            // 
            txt_artist.Location = new Point(198, 131);
            txt_artist.Name = "txt_artist";
            txt_artist.Size = new Size(305, 43);
            txt_artist.TabIndex = 6;
            // 
            // txt_album
            // 
            txt_album.Location = new Point(198, 73);
            txt_album.Name = "txt_album";
            txt_album.Size = new Size(305, 43);
            txt_album.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 312);
            label5.Name = "label5";
            label5.Size = new Size(152, 37);
            label5.TabIndex = 4;
            label5.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 261);
            label4.Name = "label4";
            label4.Size = new Size(139, 37);
            label4.TabIndex = 3;
            label4.Text = "ImageURL";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 198);
            label3.Name = "label3";
            label3.Size = new Size(67, 37);
            label3.TabIndex = 2;
            label3.Text = "Year";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 137);
            label2.Name = "label2";
            label2.Size = new Size(79, 37);
            label2.TabIndex = 1;
            label2.Text = "Artist";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 73);
            label1.Name = "label1";
            label1.Size = new Size(173, 37);
            label1.TabIndex = 0;
            label1.Text = "Album Name";
            label1.Click += label1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(633, 694);
            label6.Name = "label6";
            label6.Size = new Size(88, 37);
            label6.TabIndex = 8;
            label6.Text = "Tracks";
            label6.Click += label6_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(633, 757);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 92;
            dataGridView2.Size = new Size(1503, 281);
            dataGridView2.TabIndex = 9;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2681, 1291);
            Controls.Add(dataGridView2);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button button3;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txt_artist;
        private TextBox txt_album;
        private TextBox txt_description;
        private TextBox txt_ImageURL;
        private TextBox txt_year;
        private Button button1;
        private Label label6;
        private DataGridView dataGridView2;
    }
}
