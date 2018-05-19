using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyStorage.DataModel;

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
                Authenticator.Login(textBoxLogin.Text, textBoxPass.Text);
                switch (CurrentUser.user.Role)
                {
                    case "Seller": { var sf=new StoreForm(); sf.Show(); break; }
                    case "Storekeeper": { new StorageForm().Show(); break; }
                    case "Manager": { new PartnerForm().Show(); break; }
                }
                Close();
            }
            catch (AuthenticationException ex)
            { MessageBox.Show(ex.Message); }

        }
    }
}
