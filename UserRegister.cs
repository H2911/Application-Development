using System;
using System.IO;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class UserRegister : Form
    {
        public UserRegister()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Login Btn was Clicked");
            this.Hide();
            var UserLoginForm = new UserLoginForm();
            UserLoginForm.Closed += (s, args) => this.Close();
            UserLoginForm.Show();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Register Btn was clicked");

            // Read the text file
            string filePath = "Login.txt";
            if (File.Exists(filePath))
            {
                try
                {
                    // Read all lines from the text file
                    string[] lines = File.ReadAllLines(filePath);

                    // Get the values from emailBox, passwordBox, and passwordBoxConfirm
                    string enteredEmail = emailBox.Text;
                    string enteredPassword = passwordBox.Text;
                    string confirmPassword = passwordBoxConfirm.Text;

                    bool userExists = false;

                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(':');
                        if (parts.Length == 2)
                        {
                            string storedEmail = parts[0];
                            string storedPassword = parts[1];

                            if (enteredEmail == storedEmail)
                            {
                                MessageBox.Show("Account already exists");
                                break;
                            }
                        }
                    }

                    if (!userExists)
                    {
                        if (!enteredPassword.Contains(":") && !enteredEmail.Contains(":")) {
                            if (enteredPassword == confirmPassword)
                            {
                                // User does not exist, allow registration
                                // Append the new user to the Login.txt file
                                File.AppendAllText(filePath, $"\n{enteredEmail}:{enteredPassword}");
                                MessageBox.Show("Registration successful! You can now login.");
                            }
                            else
                            {
                                MessageBox.Show("Password and confirm password do not match. Please try again.");
                            }
                        } else
                        {
                            MessageBox.Show("Email/Password cannot contain colon : ");
                        }
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
    }
}
