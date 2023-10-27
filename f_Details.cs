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
    public partial class f_Details : Form
    {
        private Event concert;

        public f_Details(Event concert)
        {
            InitializeComponent();
            this.concert = concert;
            Text = "View Details for " + concert.Name;


            // Create labels for each piece of information.
            Label lblName = new Label { Text = "Event Name: " + concert.Name, AutoSize = true, Location = new System.Drawing.Point(10, 10) };
            Label lblPrice = new Label { Text = "Event Price: $" + concert.Price.ToString(), AutoSize = true, Location = new System.Drawing.Point(10, 30) };
            Label lblCapacity = new Label { Text = "Event Capacity: " + concert.Capacity.ToString(), AutoSize = true, Location = new System.Drawing.Point(10, 50) };
            Label lblDate = new Label { Text = "Event Date: " + concert.Date, AutoSize = true, Location = new System.Drawing.Point(10, 70) };
            Label lblTime = new Label { Text = "Event Time: " + concert.Time, AutoSize = true, Location = new System.Drawing.Point(10, 90) };
            Label lblAvailableSpace = new Label { Text = "Available Space: " + (concert.AvailableSpace).ToString(), AutoSize = true, Location = new System.Drawing.Point(10, 110) };

            // Add the labels to the form.
            Controls.Add(lblName);
            Controls.Add(lblPrice);
            Controls.Add(lblCapacity);
            Controls.Add(lblDate);
            Controls.Add(lblTime);
            Controls.Add(lblAvailableSpace);

        }
    }
}
