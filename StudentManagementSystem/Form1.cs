using SMS.Domain;

namespace StudentManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createStudent(int id, string name, string email)
        {
            var student = new Student
            {
                StudentId = id,
                StudentName = name,
                Email = email
            };

            textBoxId.Text = student.StudentId.ToString();
            textBoxName.Text = student.StudentName;
            textBoxEmail.Text = student.Email;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonShow_Click(sender, e);
           createStudent(1, "yes", "yes@no");
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            createStudent(2, "lense", "lense@lense");
        }
    }
}
