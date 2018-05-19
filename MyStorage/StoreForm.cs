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
        public StoreForm()
        {
            InitializeComponent();            
        }

        private void GetProducts()
        {
            string sql = "select lp.prod_id as 'ID', pos.name as 'Магазин', pr.name as 'Название товара', lp.count as 'Кол-во', pr.description as 'Описание', lp.price as 'Цена'"+
                         "from listproducts lp join products pr on lp.prod_id = pr.id join placesofsale pos on pos.id = lp.place_id where pos.type_id = (select id from typeplace where type = 'shop'); ";
            mySqlDataAdapter = new MySqlDataAdapter(sql, DB.connection);
            ds = new DataSet();
            mySqlDataAdapter.Fill(ds);
        }
        private void butRemain_Click(object sender, EventArgs e)
        {
            GetProducts();            
            dataGridView.DataSource = ds.Tables[0];
            dataGridView.Columns[0].Visible = false;
            //panel.Visible = true;
            //dataGridView.Visible = true;
            CurrentUser.user.Sale();
        }

        private void butSale_Click(object sender, EventArgs e)
        {
            GetProducts();
            panel.Visible = false;
            panelSale.Visible = true;
            Store store = new Store();
            foreach (DataRow row in ds.Tables[0].Rows)
                store.products.Add(new Product((int)row[0],row[1].ToString(),Convert.ToString(row[3])));

        }

        private void StoreForm_Load(object sender, EventArgs e)
        {
            Focus();
        }
    }
}
