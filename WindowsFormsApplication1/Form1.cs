using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        private void Register()
        {
            Models.DatabaseContext oDatabaseContext = null;

            try
            {
                oDatabaseContext =
                    new Models.DatabaseContext();

                Models.Person oPerson = new Models.Person();

                oPerson.Username = UsernameTextBox.Text;
                oPerson.Password = PasswordTextBox.Text;
                oPerson.Fullname = FullnameTextBox.Text;

                oDatabaseContext.Persons.Add(oPerson);

                oDatabaseContext.SaveChanges();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                if (oDatabaseContext != null)
                {
                    oDatabaseContext.Dispose();
                    oDatabaseContext = null;
                }
            }
        }

        private void GetUsers()
        {
            Models.DatabaseContext oDatabaseContext = null;

            try
            {
                oDatabaseContext = 
                    new Models.DatabaseContext();
                var varUsers =
                    oDatabaseContext.Persons
                    .OrderBy(current => current.Fullname)
                    .ToList()
                    ;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                if (oDatabaseContext != null)
                {
                    oDatabaseContext.Dispose();
                    oDatabaseContext = null;
                }
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            UsernameTextBox.Text = string.Empty;
            PasswordTextBox.Text = string.Empty;
            FullnameTextBox.Text = string.Empty;
            UsernameTextBox.Focus();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            Register();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            GetUsers();
        }
    }

}
