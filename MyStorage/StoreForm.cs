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
            string sql = "select str.prod_id, pr.name as 'Название товара', str.product_count as 'Кол-во', pr.about as 'Описание', str.price as 'Цена'" +
                                        " from store str join products pr on str.prod_id = pr.prod_id";
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
        }

        private void butSale_Click(object sender, EventArgs e)
        {
            GetProducts();
            panel.Visible = false;
            panelSale.Visible = true;
            Store store = new Store();
            foreach (DataRow row in ds.Tables[0].Rows)
                store.products.Add(new Product((int)row[0],row[1].ToString(),(int)row[2],Convert.ToDouble(row[4]),Convert.ToString(row[3])));

        }
    }
}
