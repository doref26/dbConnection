using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Form_A;

namespace form_A
{
    public partial class Form1 : Form
    {
        Store items;

        public Form1()
        {
            InitializeComponent();

            items = new Store();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = items.ItemTable();
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string desc = DescTextBox.Text;
            int price = int.Parse(PriceTextBox.Text);
            dataGridView1.DataSource = items.InsertItem(new Item(name, desc, price));
        }

        private void DELETE_btn_Click(object sender, EventArgs e)
        {
            items.DeleteItem(int.Parse(DeleteTextBox.Text));
        }

        private void Update_DB_btn_Click(object sender, EventArgs e)
        {
            items.Update((DataTable)dataGridView1.DataSource);
            dataGridView1.DataSource = items.ItemTable();
        }

        private void cancel_filter_btn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = items.ItemTable();
        }

        private void filter_btn_Click(object sender, EventArgs e)
        {
            int priceFilter = int.Parse(priceFilterTextBox.Text);
            dataGridView1.DataSource = items.FilterByAbovePrice(priceFilter);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 0)
            {
                DeleteTextBox.Text = dataGridView1.CurrentCell.Value.ToString();
            }
        }
    }
}
