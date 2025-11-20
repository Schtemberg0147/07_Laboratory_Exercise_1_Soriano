namespace _07_Laboratory_Exercise_1_Soriano
{
    public partial class FrmClubRegistration : Form
    {
        private ClubRegistrationQuery clubRegistrationQuery;
        int ID, Age, count;
        string FirstName, MiddleName, LastName, Gender, Program;
        long StudentID;
        string[] Genders = { "Male", "Female" };
        string[] Programs = { "BSIT", "BSCS", "BSIS", "BSSE", "BSECE" };
        public FrmClubRegistration()
        {
            InitializeComponent();
            clubRegistrationQuery = new ClubRegistrationQuery();
        }

        public void RefreshListOfClubMembers()
        {
            clubRegistrationQuery.DisplayList();
            dataGridView1.DataSource = clubRegistrationQuery.bindingSource;
        }

        private void FrmClubRegistration_Load(object sender, EventArgs e)
        {
            foreach (string Program in Programs)
            {
                cbProgram.Items.Add(Program);
            }
            foreach (string Gender in Genders)
            {
                cbGender.Items.Add(Gender);
            }
            RefreshListOfClubMembers();
        }

        public int RegistrationID()
        {
            this.count += 1;
            return this.count;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            ID = RegistrationID();
            StudentID = long.Parse(txtStudentID.Text);
            FirstName = txtFirstName.Text;
            MiddleName = txtMiddleName.Text;
            LastName = txtLastName.Text;
            Age = int.Parse(txtAge.Text);
            Gender = cbGender.Text;
            Program = cbProgram.Text;
            clubRegistrationQuery.RegisterStudent(ID, StudentID, FirstName, MiddleName, LastName, Age, Gender, Program);
            MessageBox.Show("Registration Success!");
            RefreshListOfClubMembers();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //Refresh the datagridview when the button is clicked
            RefreshListOfClubMembers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmUpdateMember frmUpdateMember = new FrmUpdateMember();
            frmUpdateMember.Show();
        }

        
    }
}
