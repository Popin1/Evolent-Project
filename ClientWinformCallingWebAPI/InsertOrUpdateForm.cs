using ClientWinformCallingWebAPI.Model;
using System;
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
            //validation
            HttpResponseMessage response=new HttpResponseMessage();
            if (_contact == null)
            {
                Contact contact = new Contact { FirstName = firstNameTextBox.Text, LastName = lastNameTextBox.Text, Email = emailTextBox.Text, Phone = phoneNoTextBox.Text };
                response = _client.PostAsJsonAsync("Contacts", contact).Result;
            }
            else
            {
                string uri = "Contacts/" + _contact.Id.ToString();
                response = _client.PutAsJsonAsync(uri, _contact).Result;
            }
            if(response.IsSuccessStatusCode)
            {
                MessageBox.Show("Sucessfully inserted / updated ");
            }
            else
            {
                MessageBox.Show("Error occurs while inserting / updating. Please refer the log file for details.");
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
