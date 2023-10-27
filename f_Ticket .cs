using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class TicketForm : Form
    {
        private Event _selectedEvent;
        private f_Available_Events _parentForm;
        private TextBox txtTicketQuantity; // TextBox for user to enter the number of tickets

        public TicketForm(Event concert, f_Available_Events parentForm)
        {
            InitializeComponent();
            _selectedEvent = concert;
            _parentForm = parentForm;
            Text = "Buy Ticket for " + concert.Name;
            // Initialize other UI elements as needed
            // Initialize the TextBox


            //textBox1.PlaceholderText = "Enter number of tickets";

            this.Controls.Add(txtTicketQuantity);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); // User canceled the purchase, close the form
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validate and convert the entered quantity to an integer
            int quantity;
            if (!int.TryParse(textBox1.Text, out quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid number of tickets.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Attempt to add participants based on the entered quantity
            bool success = _selectedEvent.AddParticipants(quantity);

            if (success)
            {
                MessageBox.Show("Purchase successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // If purchase was successful, notify the main form to refresh data
                _parentForm.LoadItems();  // Load all concert titles
                _parentForm.LoadPage();

                // Close the ticket purchasing form
                this.Close();
            }
            // If adding participants fails (e.g., not enough tickets), the AddParticipants method will handle the error message
        }
    }
}
