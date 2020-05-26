using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vashdom_Project
{
    public partial class FormOrders : Form
    {
        public FormOrders()
        {
            InitializeComponent();
            ShowClients();
            ShowStaff();
            ShowMaterials();
            ShowOrders();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxMaterials.SelectedItem != null && comboBoxStaff.SelectedItem != null && comboBoxClients.SelectedItem != null && textBoxDate.Text != "")
            {
                OrdersSet orders = new OrdersSet();
                orders.idNameMaterial = Convert.ToInt32(comboBoxMaterials.SelectedItem.ToString().Split('.')[0]);
                orders.idClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                orders.idStaff = Convert.ToInt32(comboBoxStaff.SelectedItem.ToString().Split('.')[0]);
                orders.Date = textBoxDate.Text;
                Program.wftDb.OrdersSet.Add(orders);
                Program.wftDb.SaveChanges();
                ShowOrders();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void ShowMaterials()
        {
            comboBoxMaterials.Items.Clear();
            foreach (MaterialsSet materialsSet in Program.wftDb.MaterialsSet)
            {
                string[] item = { materialsSet.id.ToString() + ".", materialsSet.NameMaterial + " | Количество - ", materialsSet.Price.ToString()};
                comboBoxMaterials.Items.Add(string.Join(" ", item));
            }
        }
        void ShowClients()
        {
            comboBoxClients.Items.Clear();
            foreach (ClientsSet clientsSet in Program.wftDb.ClientsSet)
            {
                string[] item = { clientsSet.id.ToString() + ".", clientsSet.FirstName, clientsSet.MiddleName, clientsSet.LastName };

                comboBoxClients.Items.Add(string.Join(" ", item));
            }
        }
        void ShowStaff()
        {
            comboBoxStaff.Items.Clear();
            foreach (StaffSet staffSet in Program.wftDb.StaffSet)
            {
                string[] item = { staffSet.id.ToString() + ".", staffSet.FirstName, staffSet.MiddleName, staffSet.LastName };

                comboBoxStaff.Items.Add(string.Join(" ", item));
            }
        }
        void ShowOrders()
        {
            listViewOrders.Items.Clear();
            foreach (OrdersSet orders in Program.wftDb.OrdersSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                   orders.idNameMaterial.ToString(), 
                   orders.MaterialsSet.NameMaterial,orders.MaterialsSet.Price.ToString(),
                   orders.idClient.ToString(),
                   orders.ClientsSet.LastName+" "+orders.ClientsSet.FirstName+" "+orders.ClientsSet.MiddleName,
                   orders.idStaff.ToString(),
                   orders.StaffSet.LastName+" "+orders.StaffSet.FirstName+" "+orders.StaffSet.MiddleName,
                   orders.Date
                }) ;
                item.Tag = orders;
                listViewOrders.Items.Add(item);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewOrders.SelectedItems.Count==1)
            {
                OrdersSet orders = listViewOrders.SelectedItems[0].Tag as OrdersSet;
                orders.idNameMaterial = Convert.ToInt32(comboBoxMaterials.SelectedItem.ToString().Split('.')[0]);
                orders.idClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                orders.idStaff = Convert.ToInt32(comboBoxStaff.SelectedItem.ToString().Split('.')[0]);
                orders.Date = textBoxDate.Text;
                Program.wftDb.SaveChanges();
                ShowOrders();
            }
        }

        private void listViewOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewOrders.SelectedItems.Count==1)
            {
                OrdersSet orders = listViewOrders.SelectedItems[0].Tag as OrdersSet;
                comboBoxMaterials.SelectedIndex = comboBoxMaterials.FindString(orders.idNameMaterial.ToString());
                comboBoxClients.SelectedIndex = comboBoxClients.FindString(orders.idClient.ToString());
                comboBoxStaff.SelectedIndex = comboBoxStaff.FindString(orders.idStaff.ToString());
                textBoxDate.Text = orders.Date;
            }
            else
            {
                comboBoxMaterials.SelectedItem = null;
                comboBoxClients.SelectedItem = null;
                comboBoxStaff.SelectedItem = null;
                textBoxDate.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewOrders.SelectedItems.Count==1)
                {
                    OrdersSet orders = listViewOrders.SelectedItems[0].Tag as OrdersSet;
                    Program.wftDb.OrdersSet.Remove(orders);
                    Program.wftDb.SaveChanges();
                    ShowOrders();
                }
                comboBoxMaterials.SelectedItem = null;
                comboBoxClients.SelectedItem = null;
                comboBoxStaff.SelectedItem = null;
                textBoxDate.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelMaterials_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxClients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
