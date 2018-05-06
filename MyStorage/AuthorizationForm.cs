using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStorage
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void butEnter_Click(object sender, EventArgs e)
        {
            try
            {
                if (Authenticator.CheckUser(textBoxLogin.Text, textBoxPass.Text))
                    switch (CurrentUser.user.Role)
                    {
                        case "seller": { new StoreForm().Show(); break; }
                        case "storekeeper": { new StorageForm().Show(); break; }
                        case "manager": { new PartnerForm().Show(); break; }
                    }
                Close();
            }
            catch(AuthenticationException ex)
            { MessageBox.Show(ex.Message);}
            
        }
    }
}
