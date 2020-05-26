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
    public partial class FormComeback : Form
    {
        public FormComeback()
        {
            InitializeComponent();
            ShowMaterials();
            ShowClients();
            ShowStaff();
            ShowComeback();
        }

        private void FormComeback_Load(object sender, EventArgs e)
        {

        }

        private void listViewComeback_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewComeback.SelectedItems.Count==1)
            {
                ComebackSet comeback = listViewComeback.SelectedItems[0].Tag as ComebackSet;
                comboBoxMaterials.SelectedIndex = comboBoxMaterials.FindString(comeback.idNameMaterial.ToString());
                comboBoxClients.SelectedIndex = comboBoxClients.FindString(comeback.idClient.ToString());
                comboBoxStaff.SelectedIndex = comboBoxStaff.FindString(comeback.idStaff.ToString());
            }
            else
            {
                comboBoxMaterials.SelectedItem = null;
                comboBoxClients.SelectedItem = null;
                comboBoxStaff.SelectedItem = null;
            }
        }
        void ShowMaterials()
        {
            comboBoxMaterials.Items.Clear();
            foreach (MaterialsSet materialsSet in Program.wftDb.MaterialsSet)
            {
                string[] item = { materialsSet.id.ToString() + ".", materialsSet.NameMaterial + " | Количество - ", materialsSet.Price.ToString() };
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxMaterials.SelectedItem != null && comboBoxStaff.SelectedItem != null && comboBoxClients.SelectedItem != null)
            {
                ComebackSet comeback = new ComebackSet();
                comeback.idNameMaterial = Convert.ToInt32(comboBoxMaterials.SelectedItem.ToString().Split('.')[0]);
                comeback.idClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                comeback.idStaff = Convert.ToInt32(comboBoxStaff.SelectedItem.ToString().Split('.')[0]);
                Program.wftDb.ComebackSet.Add(comeback);
                Program.wftDb.SaveChanges();
                ShowComeback();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void ShowComeback()
        {
            listViewComeback.Items.Clear();
            foreach (ComebackSet comeback in Program.wftDb.ComebackSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    
                    comeback.MaterialsSet.NameMaterial,
                    
                    comeback.ClientsSet.LastName+" "+comeback.ClientsSet.FirstName+" " +comeback.ClientsSet.MiddleName,
                    
                    comeback.StaffSet.LastName+" "+ comeback.StaffSet.FirstName+" "+ comeback.StaffSet.MiddleName
                });
                item.Tag = comeback;
                listViewComeback.Items.Add(item);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewComeback.SelectedItems.Count==1)
            {
                ComebackSet comeback = listViewComeback.SelectedItems[0].Tag as ComebackSet;
                comeback.idNameMaterial = Convert.ToInt32(comboBoxMaterials.SelectedItem.ToString().Split('.')[0]);
                comeback.idClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                comeback.idStaff = Convert.ToInt32(comboBoxStaff.SelectedItem.ToString().Split('.')[0]);
                Program.wftDb.SaveChanges();
                ShowComeback();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewComeback.SelectedItems.Count==1)
                {
                    ComebackSet comeback = listViewComeback.SelectedItems[0].Tag as ComebackSet;
                    Program.wftDb.ComebackSet.Remove(comeback);
                    Program.wftDb.SaveChanges();
                    ShowComeback();
                }
                comboBoxMaterials.SelectedItem = null;
                comboBoxClients.SelectedItem = null;
                comboBoxStaff.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
