namespace _07_Laboratory_Exercise_1_Soriano
{
    partial class FrmClubRegistration
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
            panel1 = new Panel();
            cbGender = new ComboBox();
            cbProgram = new ComboBox();
            txtMiddleName = new TextBox();
            txtAge = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtStudentID = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            label8 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cbGender);
            panel1.Controls.Add(cbProgram);
            panel1.Controls.Add(txtMiddleName);
            panel1.Controls.Add(txtAge);
            panel1.Controls.Add(txtFirstName);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(txtStudentID);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(662, 210);
            panel1.TabIndex = 0;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(227, 169);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(173, 23);
            cbGender.TabIndex = 3;
            // 
            // cbProgram
            // 
            cbProgram.FormattingEnabled = true;
            cbProgram.Location = new Point(425, 41);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(218, 23);
            cbProgram.TabIndex = 3;
            // 
            // txtMiddleName
            // 
            txtMiddleName.BorderStyle = BorderStyle.FixedSingle;
            txtMiddleName.Location = new Point(425, 107);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(144, 23);
            txtMiddleName.TabIndex = 2;
            // 
            // txtAge
            // 
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.Location = new Point(17, 170);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 2;
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Location = new Point(227, 107);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(173, 23);
            txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Location = new Point(17, 107);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(182, 23);
            txtLastName.TabIndex = 2;
            // 
            // txtStudentID
            // 
            txtStudentID.BorderStyle = BorderStyle.FixedSingle;
            txtStudentID.Location = new Point(17, 41);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(182, 23);
            txtStudentID.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 152);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 1;
            label3.Text = "Age:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(227, 152);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 1;
            label5.Text = "Gender:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(425, 89);
            label7.Name = "label7";
            label7.Size = new Size(80, 15);
            label7.TabIndex = 1;
            label7.Text = "Middle name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(425, 23);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 1;
            label6.Text = "Program:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(227, 89);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 1;
            label4.Text = "First name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 89);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "Last name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 23);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Student ID:";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(button3);
            panel2.Location = new Point(12, 243);
            panel2.Name = "panel2";
            panel2.Size = new Size(783, 195);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 18);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(645, 162);
            dataGridView1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(676, 18);
            button3.Name = "button3";
            button3.Size = new Size(100, 38);
            button3.TabIndex = 2;
            button3.Text = "Refresh";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnRefresh_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(688, 12);
            button1.Name = "button1";
            button1.Size = new Size(100, 36);
            button1.TabIndex = 2;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnRegister_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(688, 68);
            button2.Name = "button2";
            button2.Size = new Size(100, 38);
            button2.TabIndex = 2;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(39, 235);
            label8.Name = "label8";
            label8.Size = new Size(122, 15);
            label8.TabIndex = 0;
            label8.Text = "List Of Club Members";
            // 
            // FrmClubRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmClubRegistration";
            Text = "Form1";
            Load += FrmClubRegistration_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button button1;
        private Button button2;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label2;
        private ComboBox cbGender;
        private ComboBox cbProgram;
        private TextBox txtMiddleName;
        private TextBox txtAge;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtStudentID;
        private Label label7;
        private Label label6;
        private DataGridView dataGridView1;
        private Button button3;
        private Label label8;
    }
}
