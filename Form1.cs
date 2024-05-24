namespace EmployeeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FirstName = textBox1.Text;
            string LastName = textBox2.Text;
            string Department = textBox3.Text;
            string JobTitle = textBox4.Text;
            double ratePerHour = double.Parse(textBox5.Text);
            int totalHoursWorked = int.Parse(textBox6.Text);

            PartTimeEmployee employee = new PartTimeEmployee(FirstName, LastName, Department, JobTitle);
            employee.ComputeSalary(totalHoursWorked, ratePerHour);

            lblFname.Text = "First name: " + employee.FirstName;
            lblLname.Text = "Last name: " + employee.LastName;
            lblBsalary.Text = "Basic Salary: " + employee.GetSalary().ToString("00.00");
        }
    }
}
