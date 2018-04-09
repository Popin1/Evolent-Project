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
            
            HttpResponseMessage response=new HttpResponseMessage();
            ContactValidator validator = new ContactValidator();
            Contact contact = new Contact { FirstName = firstNameTextBox.Text, LastName = lastNameTextBox.Text, Email = emailTextBox.Text, Phone = phoneNoTextBox.Text };
            if (_contact == null)
            {
                if (validator.Validate(contact))
                {
                    response = _client.PostAsJsonAsync("Contacts", contact).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show(Resources.SucesfullyInsertUpdated);
                    }
                    else
                    {
                        MessageBox.Show(Resources.ErrorInsertedUpdated);
                        EventLog.WriteEntry("Application", response.ReasonPhrase + " " + response.RequestMessage, EventLogEntryType.Error);
                    }
                }
            }
            else
            {
                if (validator.Validate(contact))
                {
                    string uri = "Contacts/" + _contact.Id.ToString();
                    response = _client.PutAsJsonAsync(uri, contact).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show(Resources.SucesfullyInsertUpdated);
                    }
                    else
                    {
                        MessageBox.Show(Resources.ErrorInsertedUpdated);
                        EventLog.WriteEntry("Application", response.ReasonPhrase + " " + response.RequestMessage, EventLogEntryType.Error);
                    }
                }
            }
            
        }

        private void InsertOrUpdateForm_Load(object sender, EventArgs e)
        {
            if(_contact!=null)
            {
                firstNameTextBox.Text = _contact.FirstName;
                lastNameTextBox.Text = _contact.LastName;
                emailTextBox.Text = _contact.Email;
                phoneNoTextBox.Text = _contact.Phone;                
            }
        }
    }
}
