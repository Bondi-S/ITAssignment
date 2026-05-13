using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITAssignment
{
    public partial class UC_Inventory : UserControl
    {
        private BindingList<Product> _inventoryList = new BindingList<Product>();
        private BindingSource _bindingSource = new BindingSource();
        string filepath = "./product.csv";
        public UC_Inventory()
        {
            InitializeComponent();
        }

        private void UC_Inventory_Load(object sender, EventArgs e)
        {
            var tempData = InventoryService.LoadFromCSV(filepath);
            _inventoryList.Clear();

            foreach (var item in tempData)
            {
                _inventoryList.Add(item);
            }
            dgvInventory.DataSource = _inventoryList;
        }

        private void UC_Inventory_Load_1(object sender, EventArgs e)
        {

        }
    }
}
