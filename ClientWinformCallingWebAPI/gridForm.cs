using ClientWinformCallingWebAPI.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace ClientWinformCallingWebAPI
{
    public partial class gridForm : Form
    {
        private HttpClient _client;

        public gridForm(HttpClient client)
        {
            InitializeComponent();
            _client = client;            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refeshGrid();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (contactsGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select the row to update");
            }
            else
            {
                InsertOrUpdateForm update = new InsertOrUpdateForm(selectedRow(), _client);
                update.ShowDialog();
                refeshGrid();
            }
            
        }

        private void refeshGrid()
        {
            HttpResponseMessage result = _client.GetAsync("contacts").Result;  // Blocking call!
            if (result.IsSuccessStatusCode)
            {
                var value = result.Content.ReadAsAsync<List<Contact>>().Result;
                contactsGridView.DataSource = value;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private Contact selectedRow()
        {
            Contact contact = new Contact { Id = (int)contactsGridView.SelectedRows[0].Cells[0].Value,
                                            FirstName = contactsGridView.SelectedRows[0].Cells[1].Value.ToString(),
                                            LastName = contactsGridView.SelectedRows[0].Cells[2].Value.ToString(),
                                            Email = contactsGridView.SelectedRows[0].Cells[3].Value.ToString(),
                                            Phone = contactsGridView.SelectedRows[0].Cells[4].Value.ToString(),
                                            IsActive = (bool)contactsGridView.SelectedRows[0].Cells[5].Value
                                            };
            return contact;
        }

        private void insertButon_Click(object sender, EventArgs e)
        {
            InsertOrUpdateForm update = new InsertOrUpdateForm(null, _client);
            update.ShowDialog();
            refeshGrid();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            if (contactsGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select the row to delete");
            }
            else
            {
                string Id = contactsGridView.SelectedRows[0].Cells[0].Value.ToString();
                response = _client.DeleteAsync("Contacts/" + Id).Result;
            }
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Sucessfully deleted ");
                refeshGrid();
            }
            else
            {
                MessageBox.Show("Error occurs while deleting. Please refer the event viwer for details.");                
            }
        }
       
    }
}
