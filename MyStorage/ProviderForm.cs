using MySql.Data.MySqlClient;
using MyStorage.Database;
using MyStorage.DataModel;
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
    public partial class ProviderForm : Form
    {
        MySqlDataAdapter mySqlDataAdapter;
        DataSet ds;
        //List<Store> stores = new List<Store>();
        List<Client> clients = new List<Client>();
        Client cur_client = new Client();
        //Store cur_shop = new Store();
        BindingList<Client> bindingList;

        public ProviderForm()
        {
            InitializeComponent();
            panelRemain.Visible = true;
            bindingList = new BindingList<Client>();
            dataGridViewRemain.DataSource = bindingList;
            GetProvider();
            
        }
        private void ProviderForm_Load(object sender, EventArgs e)
        {
            Focus();
        }
        

        public void GetProvider()
        {
            string sql = "select c.id,tc.type,c.name,c.middle_name,c.lastname " +
                         "from clients c join typeclient tc on tc.id = c.id where cl_type_id = (select id from typeclient where type = 'provider');";
            var list = DB.Select(sql);
            clients.Clear();
            list.ForEach(l => { var ls = l.Split(' '); clients.Add(new Client(Convert.ToInt32(ls[0]), ls[1], ls[2], ls[3], ls[4])); });
            clients.ForEach(c => comboBoxProvider.Items.Add(c.Name + " " + c.Last_name));
        }
        // may repeat because not clear binding list
        private void comboBoxProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cl = clients.Find(p => p.Name + " "+ p.Last_name == comboBoxProvider.SelectedItem.ToString());
            if (!bindingList.ToList().Exists(x => x.Name == cl.Name))
                bindingList.Add(new Client(cl));
        }
    }
}
