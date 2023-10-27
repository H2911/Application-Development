using System;
using System.Windows.Forms;
using System.IO;

namespace Assignment2
{
    public partial class UserLoginForm : Form
    {
        public UserLoginForm()
        {
            InitializeComponent();

        }

        private void f_UserLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Login Btn was clicked");

            // Read the text file
            string filePath = "Login.txt";
            if (File.Exists(filePath))
            {
                try
                {
                    // Read all lines from the text file
                    string[] lines = File.ReadAllLines(filePath);

                    // Get the values from emailBox and passwordBox
                    // Format of "lines" is email:password:access
                    // Example admin@email.com:adminPassword:admin the third slice indicates admin access
                    string enteredEmail = emailBox.Text;
                    string enteredPassword = passwordBox.Text;
                    string storedAccess = "user";

                    // Check if the email and password match any line in the file
                    bool loginSuccessful = false;

                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(':');
                        if (parts.Length == 3)
                        {
                            string storedEmail = parts[0];
                            string storedPassword = parts[1];
                            storedAccess = parts[2];

                            if (enteredEmail == storedEmail && enteredPassword == storedPassword)
                            {
                                loginSuccessful = true;
                                break; // Login successful, exit the loop
                            }
                        }
                    }

                    if (loginSuccessful)
                    {
                        MessageBox.Show("Login successful!");
                        if (storedAccess == "admin")
                        {
                            this.Hide();
                            var AdminManagementForm = new AdminManagementForm();
                            AdminManagementForm.Closed += (s, args) => this.Close();
                            AdminManagementForm.Show();
                        } else if (storedAccess == "user")
                        {
                            // This section determines which window to open. An admin window or concert booking window
                            // Change me to show Shun's code
                            Console.WriteLine("user granted");
                            MessageBox.Show("User logged in");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Login failed. Please check your email and password.");
                    }
                }
                catch (IOException ex)
                {
                    Console.WriteLine("Error reading the file: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Login.txt does not exist. Please create the file with login information.");
            }
        }


        private void registerBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var UserRegister = new UserRegister();
            UserRegister.Closed += (s, args) => this.Close();
            UserRegister.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
