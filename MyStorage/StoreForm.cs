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
    public partial class StoreForm : Form
    {
        MySqlDataAdapter mySqlDataAdapter;
        DataSet ds;
        List<Store> stores = new List<Store>();
        List<Client> clients = new List<Client>();
        Client cur_client = new Client();
        Store cur_shop = new Store();
        BindingList<Product> bindingList;

        public StoreForm()
        {
            InitializeComponent();
            panelRemain.Visible = false;
            panelSale.Visible = false;
            panelReceipt.Visible = false;
            bindingList = new BindingList<Product>();

            dataGridViewSale.Width = 350;
            dataGridViewSale.Height = 130;
            dataGridViewSale.RowHeadersWidth = 10;
            dataGridViewSale.AllowUserToAddRows = false;
            dataGridViewSale.AllowUserToDeleteRows = false;
            dataGridViewSale.AllowUserToResizeColumns = false;
            dataGridViewSale.AllowUserToResizeRows = false;

            dataGridViewReceipt.Width = 350;
            dataGridViewReceipt.Height = 130;
            dataGridViewReceipt.RowHeadersWidth = 10;
            dataGridViewReceipt.AllowUserToAddRows = false;
            dataGridViewReceipt.AllowUserToDeleteRows = false;
            dataGridViewReceipt.AllowUserToResizeColumns = false;
            dataGridViewReceipt.AllowUserToResizeRows = false;

            dataGridViewSale.AutoGenerateColumns = false;
            dataGridViewReceipt.AutoGenerateColumns = false;

            //create the column programatically
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            DataGridViewTextBoxColumn colName = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "name",
                HeaderText = "Product",
                DataPropertyName = "Name",
                Width = 350 - 50 - 50 - 10,
                ReadOnly = true
            };
            DataGridViewTextBoxColumn colPrice = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "price",
                HeaderText = "Price",
                DataPropertyName = "Price",
                Width = 50,
                ReadOnly = true
            };
            DataGridViewTextBoxColumn colCount = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "count",
                HeaderText = "Count",
                DataPropertyName = "Count",
                Width = 50
            };

            dataGridViewSale.Columns.Add(colName);
            dataGridViewSale.Columns.Add(colPrice);
            dataGridViewSale.Columns.Add(colCount);

            DataGridViewTextBoxColumn colNameR = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "name",
                HeaderText = "Product",
                DataPropertyName = "Name",
                Width = 350 - 50 - 50 - 10,
                ReadOnly = true
            };
            DataGridViewTextBoxColumn colPriceR = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "price",
                HeaderText = "Price",
                DataPropertyName = "Price",
                Width = 50,
                ReadOnly = true
            };
            DataGridViewTextBoxColumn colCountR = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "count",
                HeaderText = "Count",
                DataPropertyName = "Count",
                Width = 50
            };

            dataGridViewReceipt.Columns.Add(colNameR);
            dataGridViewReceipt.Columns.Add(colPriceR);
            dataGridViewReceipt.Columns.Add(colCountR);

            dataGridViewSale.DataSource = bindingList;
            dataGridViewReceipt.DataSource = bindingList;
        }
        private void StoreForm_Load(object sender, EventArgs e)
        {
            Focus();
        }

        private void EnablePanel(string namePanel)
        {
            foreach (Panel p in Controls.OfType<Panel>())
                p.Visible = p.Name == namePanel ? true : false;            
        }

        //Remains
        private void butRemain_Click(object sender, EventArgs e)
        {
            EnablePanel(panelRemain.Name);
            GetRemains();
            dataGridViewRemain.DataSource = ds.Tables[0];
            dataGridViewRemain.Columns[0].Visible = false;
        }
        private void GetRemains()
        {
            string sql = "select lp.prod_id as 'ID', pos.name as 'Shop', pr.name as 'Prodact name', lp.count as 'Count', pr.description as 'Description', lp.price as 'Price'" +
                         "from listproducts lp join products pr on lp.prod_id = pr.id join placesofsale pos on pos.id = lp.place_id where pos.type_id = (select id from typeplace where type = 'shop'); ";
            mySqlDataAdapter = new MySqlDataAdapter(sql, DB.connection);
            ds = new DataSet();
            mySqlDataAdapter.Fill(ds);
        }

        //Sale
        private void butSale_Click(object sender, EventArgs e)
        {
            EnablePanel(panelSale.Name);
            comboBoxShops.Items.Clear();
            GetShops();
        }

        private void GetShops()
        {
            string sql = "select id,name from placesofsale where type_id=(select id from typeplace where type='shop');";
            var list = DB.Select(sql);
            stores.Clear();
            list.ForEach(l => { var ls = l.Split(' '); stores.Add(new Store(Convert.ToInt32(ls[0]), ls[1])); });
            stores.ForEach(s => comboBoxShops.Items.Add(s.name));
        }
        private void comboBoxShops_SelectedIndexChanged(object sender, EventArgs e)
        {
            cur_shop = stores.Find(s => s.name == comboBoxShops.SelectedItem.ToString());
            bindingList.Clear();
            GetProducts();
        }

        private void GetProducts()
        {
            string sql = "select lp.prod_id, pr.name, pr.description, lp.count, lp.price" +
                         " from listproducts lp join products pr on lp.prod_id = pr.id join placesofsale pos on pos.id = lp.place_id" +
                         " where pos.id =" + cur_shop.id + ";";
            var list = DB.Select(sql);
            cur_shop.products.Clear();
            list.ForEach(l => { var ls = l.Split(' '); cur_shop.products.Add(new Product(Convert.ToInt32(ls[0]), ls[1], ls[2], Convert.ToInt32(ls[3]), Convert.ToDouble(ls[4]))); });
            comboBoxProducts.Items.Clear();
            cur_shop.products.ForEach(x => comboBoxProducts.Items.Add(x.Name));
        }
        private void comboBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pr = cur_shop.products.Find(p => p.Name == comboBoxProducts.SelectedItem.ToString());
            if (!bindingList.ToList().Exists(x => x.Name == pr.Name))
                bindingList.Add(new Product(pr));
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            bindingList.ToList().ForEach(sale_prod => cur_shop.products.Find(old_prod => old_prod.Name == sale_prod.Name).Count -= sale_prod.Count);
            UpdateShop();
            bindingList.Clear();
        }
        private void UpdateShop()
        {
            string sql = "";
            cur_shop.products.ForEach((prod) =>
            {
                sql = "update listproducts set count =" + prod.Count + " where prod_id=" + prod.Id + " and place_id=" + cur_shop.id + ";";
                DB.Update(sql);
            });
            MessageBox.Show("Data successfully updated!");
            GetProducts();
        }

        //Receipt
        private void butReceipt_Click(object sender, EventArgs e)
        {
            EnablePanel(panelReceipt.Name);
            clients.Clear();
            comboBoxPartner.Items.Clear();
            GetPartner();
        }

        public void GetPartner()
        {
            string sql = "select c.id,tc.type,c.name,c.middle_name,c.lastname "+
                         "from clients c join typeclient tc on tc.id = c.id where cl_type_id = (select id from typeclient where type = 'provider');";
            var list = DB.Select(sql);
            clients.Clear();
            list.ForEach(l => { var ls = l.Split(' '); clients.Add(new Client(Convert.ToInt32(ls[0]), ls[1],ls[2],ls[3],ls[4])); });
            clients.ForEach(c => comboBoxPartner.Items.Add(c.Name+" "+ c.Last_name));
        }

        private void comboBoxPartner_SelectedIndexChanged(object sender, EventArgs e)
        {
            cur_client = clients.Find(c => c.Name == comboBoxPartner.SelectedItem.ToString());
            bindingList.Clear();
            GetShopsReceipt();
        }
        private void GetShopsReceipt()
        {
            string sql = "select id,name from placesofsale where type_id=(select id from typeplace where type='shop');";
            var list = DB.Select(sql);
            stores.Clear();
            list.ForEach(l => { var ls = l.Split(' '); stores.Add(new Store(Convert.ToInt32(ls[0]), ls[1])); });
            stores.ForEach(s => comboBoxShopReceipt.Items.Add(s.name));
        }

        private void comboBoxShopReceipt_SelectedIndexChanged(object sender, EventArgs e)
        {
            cur_shop = stores.Find(s => s.name == comboBoxShopReceipt.SelectedItem.ToString());
            bindingList.Clear();
            GetProductsReceipt();
        }
        private void GetProductsReceipt()
        {
            string sql = "select lp.prod_id, pr.name, pr.description, lp.count, lp.price" +
                         " from listproducts lp join products pr on lp.prod_id = pr.id join placesofsale pos on pos.id = lp.place_id" +
                         " where pos.id =" + cur_shop.id + ";";
            var list = DB.Select(sql);
            cur_shop.products.Clear();
            list.ForEach(l => { var ls = l.Split(' '); cur_shop.products.Add(new Product(Convert.ToInt32(ls[0]), ls[1], ls[2], Convert.ToInt32(ls[3]), Convert.ToDouble(ls[4]))); });
            comboBoxProd.Items.Clear();
            cur_shop.products.ForEach(x => comboBoxProd.Items.Add(x.Name));
        }

        private void comboBoxProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pr = cur_shop.products.Find(p => p.Name == comboBoxProd.SelectedItem.ToString());
            if (!bindingList.ToList().Exists(x => x.Name == pr.Name))
                bindingList.Add(new Product(pr));
        }

        private void butConfirmReceipt_Click(object sender, EventArgs e)
        {
            bindingList.ToList().ForEach(sale_prod => cur_shop.products.Find(old_prod => old_prod.Name == sale_prod.Name).Count += sale_prod.Count);
            UpdateShopReceipt();
            bindingList.Clear();
        }

        private void UpdateShopReceipt()
        {
            string sql = "";
            cur_shop.products.ForEach((prod) =>
            {
                sql = "update listproducts set count =" + prod.Count + " where prod_id=" + prod.Id + " and place_id=" + cur_shop.id + ";";
                DB.Update(sql);
            });
            MessageBox.Show("Data successfully updated!");
            GetProductsReceipt();
        }
    }
}
