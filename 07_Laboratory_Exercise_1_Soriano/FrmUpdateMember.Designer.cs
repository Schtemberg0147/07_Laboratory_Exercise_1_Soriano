namespace _07_Laboratory_Exercise_1_Soriano
{
    partial class FrmUpdateMember
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cbStudentID = new ComboBox();
            cbGender = new ComboBox();
            cbProgram = new ComboBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtMiddleName = new TextBox();
            txtAge = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            label1.Location = new Point(18, 12);
            label1.Name = "label1";
            label1.Size = new Size(88, 19);
            label1.TabIndex = 0;
            label1.Text = "Student ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            label2.Location = new Point(18, 68);
            label2.Name = "label2";
            label2.Size = new Size(89, 19);
            label2.TabIndex = 1;
            label2.Text = "Last name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            label3.Location = new Point(19, 132);
            label3.Name = "label3";
            label3.Size = new Size(91, 19);
            label3.TabIndex = 1;
            label3.Text = "First name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            label4.Location = new Point(17, 197);
            label4.Name = "label4";
            label4.Size = new Size(106, 19);
            label4.TabIndex = 1;
            label4.Text = "Middle name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            label5.Location = new Point(19, 259);
            label5.Name = "label5";
            label5.Size = new Size(41, 19);
            label5.TabIndex = 1;
            label5.Text = "Age:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            label6.Location = new Point(19, 325);
            label6.Name = "label6";
            label6.Size = new Size(65, 19);
            label6.TabIndex = 1;
            label6.Text = "Gender:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            label7.Location = new Point(19, 393);
            label7.Name = "label7";
            label7.Size = new Size(78, 19);
            label7.TabIndex = 1;
            label7.Text = "Program:";
            // 
            // cbStudentID
            // 
            cbStudentID.Font = new Font("Bahnschrift", 12F);
            cbStudentID.FormattingEnabled = true;
            cbStudentID.Location = new Point(19, 34);
            cbStudentID.Name = "cbStudentID";
            cbStudentID.Size = new Size(244, 27);
            cbStudentID.TabIndex = 2;
            cbStudentID.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cbGender
            // 
            cbGender.Font = new Font("Bahnschrift", 12F);
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(19, 347);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(185, 27);
            cbGender.TabIndex = 2;
            // 
            // cbProgram
            // 
            cbProgram.Font = new Font("Bahnschrift", 12F);
            cbProgram.FormattingEnabled = true;
            cbProgram.Location = new Point(19, 415);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(244, 27);
            cbProgram.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Font = new Font("Bahnschrift", 12F);
            txtLastName.Location = new Point(19, 90);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(185, 27);
            txtLastName.TabIndex = 3;
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Bahnschrift", 12F);
            txtFirstName.Location = new Point(19, 154);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(185, 27);
            txtFirstName.TabIndex = 3;
            // 
            // txtMiddleName
            // 
            txtMiddleName.BorderStyle = BorderStyle.FixedSingle;
            txtMiddleName.Font = new Font("Bahnschrift", 12F);
            txtMiddleName.Location = new Point(19, 219);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(185, 27);
            txtMiddleName.TabIndex = 3;
            // 
            // txtAge
            // 
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.Font = new Font("Bahnschrift", 12F);
            txtAge.Location = new Point(19, 281);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(96, 27);
            txtAge.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.SaddleBrown;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(19, 458);
            button1.Name = "button1";
            button1.Size = new Size(244, 37);
            button1.TabIndex = 4;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnConfirm_Click;
            // 
            // FrmUpdateMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(288, 515);
            Controls.Add(button1);
            Controls.Add(txtAge);
            Controls.Add(txtMiddleName);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(cbProgram);
            Controls.Add(cbGender);
            Controls.Add(cbStudentID);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmUpdateMember";
            Text = "FrmUpdateMember";
            Load += FrmUpdateMember_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cbStudentID;
        private ComboBox cbGender;
        private ComboBox cbProgram;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtMiddleName;
        private TextBox txtAge;
        private Button button1;
    }
}