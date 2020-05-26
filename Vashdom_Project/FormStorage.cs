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
    public partial class FormStorage : Form
    {
        public FormStorage()
        {
            InitializeComponent();
            ShowMaterials();
            ShowStorage();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxMaterials.SelectedItem != null && textBoxLocation.Text != "")
            {
                StorageSet storage = new StorageSet();
                storage.idNameMaterial = Convert.ToInt32(comboBoxMaterials.SelectedItem.ToString().Split('.')[0]);
                storage.Location = textBoxLocation.Text;
                Program.wftDb.StorageSet.Add(storage);
                Program.wftDb.SaveChanges();
                ShowStorage();
            }
            else MessageBox.Show("Выберите данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
        void ShowMaterials()
        {
            comboBoxMaterials.Items.Clear();
            foreach (MaterialsSet materialsSet in Program.wftDb.MaterialsSet)
            {
                string[] item = { materialsSet.id.ToString() + ".", materialsSet.NameMaterial + " | Количество - ", materialsSet.Count.ToString()+" | Вес - ", materialsSet.Weight.ToString() };
                comboBoxMaterials.Items.Add(string.Join(" ", item));
            }

        }
        void ShowStorage()
        {
            listViewStorage.Items.Clear();
            foreach (StorageSet storage in Program.wftDb.StorageSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    storage.id.ToString(), storage.MaterialsSet.NameMaterial,storage.MaterialsSet.Count.ToString() ,
                    storage.MaterialsSet.Weight.ToString(),
                    storage.Location
                });
                item.Tag = storage;
                listViewStorage.Items.Add(item);
                
            }
            
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewStorage.SelectedItems.Count==1)
            {
                StorageSet storage = listViewStorage.SelectedItems[0].Tag as StorageSet;
                storage.idNameMaterial = Convert.ToInt32(comboBoxMaterials.SelectedItem.ToString().Split('.')[0]);
                storage.Location = textBoxLocation.Text;
                Program.wftDb.SaveChanges();
                ShowStorage();

            }
        }

        private void listViewStorage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewStorage.SelectedItems.Count==1)
            {
                StorageSet storage = listViewStorage.SelectedItems[0].Tag as StorageSet;
                comboBoxMaterials.SelectedIndex = comboBoxMaterials.FindString(storage.idNameMaterial.ToString());
                textBoxLocation.Text = storage.Location;
            }
            else
            {
                comboBoxMaterials.SelectedItem = null;
                textBoxLocation.Text = "";
            }

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewStorage.SelectedItems.Count==1)
                {
                    StorageSet storage = listViewStorage.SelectedItems[0].Tag as StorageSet;
                    Program.wftDb.StorageSet.Remove(storage);
                    Program.wftDb.SaveChanges();
                    ShowStorage();
                }
                comboBoxMaterials.SelectedItem = null;
                textBoxLocation.Text = "";
            }
            

            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormStorage_Load(object sender, EventArgs e)
        {

        }
    }

}
