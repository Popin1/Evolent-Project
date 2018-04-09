using ClientWinformCallingWebAPI.Model;
using ClientWinformCallingWebAPI.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClientWinformCallingWebAPI.Validation
{
    class ContactValidator
    {
        public bool Validate(Contact contact)
        {
            StringBuilder stringBuilder = new StringBuilder();
            bool valid = true;
            if (contact!=null)
            {
                string emialRegex = @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
                                        + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				                            [0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
                                        + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				                            [0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
                                        + @"([a-zA-Z0-9]+[\w-]+\.)+[a-zA-Z]{1}[a-zA-Z0-9-]{1,23})$";
                if (string.IsNullOrEmpty(contact.Email) || !Regex.IsMatch(contact.Email, emialRegex))
                {
                    stringBuilder.Append(Resources.EmailRequired);
                    stringBuilder.Append(Environment.NewLine);
                    valid = false;
                }

                if (string.IsNullOrEmpty(contact.Phone) ||
                    !Regex.IsMatch(contact.Phone, @"^(\+?\d{1,4}[\s-])?(?!0+\s+,?$)\d{10}\s*,?$"))
                {
                    stringBuilder.Append(Resources.PhoneRequired);
                    stringBuilder.Append(Environment.NewLine);
                    valid = false;
                }
                if(string.IsNullOrEmpty(contact.FirstName) || contact.FirstName.Length>50)
                {
                    stringBuilder.Append(Resources.FirstNameValidator);
                    stringBuilder.Append(Environment.NewLine);
                    valid = false;
                }

                if (string.IsNullOrEmpty(contact.LastName) || contact.LastName.Length > 50)
                {
                    stringBuilder.Append(Resources.LasttNameValidator);
                    stringBuilder.Append(Environment.NewLine);
                    valid = false;
                }

                if(stringBuilder.Length>0)
                {
                    System.Windows.Forms.MessageBox.Show(stringBuilder.ToString());
                }

            }
            return valid;
        }
    }
}
