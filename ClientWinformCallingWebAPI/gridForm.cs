using ClientWinformCallingWebAPI.Model;
using ClientWinformCallingWebAPI.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            refreshGrid();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (contactsGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show(Resources.SelectRowUpdate);
            }
            else
            {
                InsertOrUpdateForm update = new InsertOrUpdateForm(selectedRow(), _client);
                update.ShowDialog();
                refreshGrid();
            }
            
        }

        private void refreshGrid()
        {
            HttpResponseMessage result = _client.GetAsync("contacts").Result;  // Blocking call!
            if (result.IsSuccessStatusCode)
            {
                var value = result.Content.ReadAsAsync<List<Contact>>().Result;
                contactsGridView.DataSource = value;
            }
            else
            {
                MessageBox.Show(Resources.ErrorDataGrid);
                EventLog.WriteEntry("Application", result.ReasonPhrase + " " + result.RequestMessage, EventLogEntryType.Error);
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
            refreshGrid();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            if (contactsGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show(Resources.SelectRowDelete);
            }
            else
            {
                string Id = contactsGridView.SelectedRows[0].Cells[0].Value.ToString();
                response = _client.DeleteAsync("Contacts/" + Id).Result;
            }
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show(Resources.SucessfullyDeleted);
                refreshGrid();
            }
            else
            {
                MessageBox.Show(Resources.DeleteError);
                EventLog.WriteEntry("Application", response.ReasonPhrase + " " + response.RequestMessage, EventLogEntryType.Error);
            }
        }
       
    }
}
