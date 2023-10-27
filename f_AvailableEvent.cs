using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class f_Available_Events : Form
    {
        private Button previousButton;
        private Button nextButton;
        private DataGridView dataGridView;
        private Label pageLabel;
        private int currentPage = 1;
        private int itemsPerPage = 10;
        private List<Event> allItems;

        public f_Available_Events()
        {
            InitializeComponent();
            LoadItems();  // Load all concert titles
            LoadPage();   // Load the first page
        }



        public void LoadItems()
        {
            ConnectData connectData = new ConnectData();
            allItems = connectData.GetAllActiveEventsInfo();
        }

        public void LoadPage()
        {
            dataGridView.Rows.Clear();
            int startIndex = (currentPage - 1) * itemsPerPage;
            int endIndex = Math.Min(startIndex + itemsPerPage, allItems.Count);
            for (int i = startIndex; i < endIndex; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell { Value = allItems[i].Name });
                if (allItems[i] != null)
                {
                    row.Cells.Add(new DataGridViewButtonCell { Value = "Buy" });
                    row.Cells.Add(new DataGridViewButtonCell { Value = "View" });
                }
                else
                {
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = string.Empty });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = string.Empty });
                }
                dataGridView.Rows.Add(row);
            }
            UpdatePageLabel();
        }

        private void UpdatePageLabel()
        {
            int totalPages = (allItems.Count + itemsPerPage - 1) / itemsPerPage;
            pageLabel.Text = $"Page {currentPage} of {totalPages}";
        }
        private void OpenBuyTicketPage(Event concert, f_Available_Events f)
        {
            TicketForm ticketForm = new TicketForm(concert, f);
            ticketForm.Show();
        }

        private void OpenDetailsPage(Event concert)
        {
            f_Details detailsForm = new f_Details(concert);
            detailsForm.Show();
        }

        private void dataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView.Rows[e.RowIndex].Cells[0].Value != null)
            {
                int selectedRowIndex = e.RowIndex;
                Event selectedConcert = allItems[(currentPage - 1) * itemsPerPage + selectedRowIndex];


                if (selectedConcert == null)
                {
                    // Ignore clicks on rows with null concert item values
                    return;
                }

                if (e.ColumnIndex == 1)
                {
                    // Buy Ticket button clicked
                    OpenBuyTicketPage(selectedConcert, this);
                }
                else if (e.ColumnIndex == 2)
                {
                    // View Details button clicked
                    OpenDetailsPage(selectedConcert);
                }
            }
        }

        private void bnt_Previous_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadPage();
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            int totalPages = (allItems.Count + itemsPerPage - 1) / itemsPerPage;
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadPage();
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("You want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                UserLoginForm loginForm = new UserLoginForm();
                loginForm.Show();
                this.Hide();
            }
        }
    }
}