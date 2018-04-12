using ClientWinformCallingWebAPI.Model;
using ClientWinformCallingWebAPI.Properties;
using ClientWinformCallingWebAPI.Validation;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Windows.Forms;

namespace ClientWinformCallingWebAPI
{
    public partial class InsertOrUpdateForm : Form
    {
        Contact _contact;
        HttpClient _client;

        public InsertOrUpdateForm(Contact contact, HttpClient client)
        {
            InitializeComponent();
            _contact = contact;
            _client = client;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            HttpResponseMessage response = new HttpResponseMessage();
            ContactValidator validator = new ContactValidator();
            Contact contact = new Contact { FirstName = firstNameTextBox.Text, LastName = lastNameTextBox.Text, Email = emailTextBox.Text, Phone = phoneNoTextBox.Text.Trim(), IsActive = true };
            if (_contact == null)
            {
                if (validator.Validate(contact))
                {
                    response = _client.PostAsJsonAsync("Contacts", contact).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        Success();
                    }
                    else
                    {
                        Failure(response);
                    }
                }
            }
            else
            {
                if (validator.Validate(contact))
                {
                    string uri = "Contacts?id=" + _contact.Id.ToString();
                    contact.Id = _contact.Id;
                    response = _client.PutAsJsonAsync(uri, contact).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        Success();
                    }
                    else
                    {
                        Failure(response);
                    }
                }
            }

        }

        private void Failure(HttpResponseMessage response)
        {
            MessageBox.Show(Resources.ErrorInsertedUpdated);
            EventLog.WriteEntry("Application", response.ReasonPhrase + " " + response.RequestMessage, EventLogEntryType.Error);
        }

        private void InsertOrUpdateForm_Load(object sender, EventArgs e)
        {
            if (_contact != null)
            {
                firstNameTextBox.Text = _contact.FirstName;
                lastNameTextBox.Text = _contact.LastName;
                emailTextBox.Text = _contact.Email;
                phoneNoTextBox.Text = _contact.Phone;
            }
        }
        private void Success()
        {
            MessageBox.Show(Resources.SucesfullyInsertUpdated);
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
