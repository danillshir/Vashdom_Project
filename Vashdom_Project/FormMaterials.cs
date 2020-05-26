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
    public partial class FormMaterials : Form
    {
        public FormMaterials()
        {
            InitializeComponent();
            ShowMaterial();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            MaterialsSet materialsSet = new MaterialsSet();
            materialsSet.NameMaterial = textBoxNameMaterial.Text;
            materialsSet.Price = Convert.ToInt32(textBoxPrice.Text);
            materialsSet.Count = Convert.ToInt32(textBoxCount.Text);
            materialsSet.Weight = Convert.ToInt32(textBoxWeight.Text);
            materialsSet.Supplier = textBoxSupplier.Text;
            Program.wftDb.MaterialsSet.Add(materialsSet);
            Program.wftDb.SaveChanges();
            ShowMaterial();
        }
        void ShowMaterial()
        {
            listViewMaterials.Items.Clear();
            foreach (MaterialsSet materialsSet in Program.wftDb.MaterialsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        materialsSet.id.ToString(), materialsSet.NameMaterial, materialsSet.Price.ToString(),materialsSet.Count.ToString(),
                        materialsSet.Weight.ToString(),materialsSet.Supplier
                    }
                    );
                item.Tag = materialsSet;
                listViewMaterials.Items.Add(item);
            }
            listViewMaterials.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listViewMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewMaterials.SelectedItems.Count == 1)
            {
                MaterialsSet materialsSet = listViewMaterials.SelectedItems[0].Tag as MaterialsSet;
                textBoxNameMaterial.Text = materialsSet.NameMaterial;
                textBoxPrice.Text = materialsSet.Price.ToString();
                textBoxCount.Text = materialsSet.Count.ToString();
                textBoxWeight.Text = materialsSet.Weight.ToString();
                textBoxSupplier.Text = materialsSet.Supplier;

            }
            else
            {
                textBoxNameMaterial.Text = "";
                textBoxPrice.Text = "";
                textBoxCount.Text = "";
                textBoxWeight.Text = "";
                textBoxSupplier.Text = "";
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewMaterials.SelectedItems.Count == 1)
            {
                MaterialsSet materialsSet = listViewMaterials.SelectedItems[0].Tag as MaterialsSet;
                materialsSet.NameMaterial = textBoxNameMaterial.Text;
                materialsSet.Price = Convert.ToInt32(textBoxPrice.Text);
                materialsSet.Count = Convert.ToInt32(textBoxCount.Text);
                materialsSet.Weight = Convert.ToInt32(textBoxWeight.Text);
                materialsSet.Supplier = textBoxSupplier.Text;
                Program.wftDb.SaveChanges();
                ShowMaterial();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewMaterials.SelectedItems.Count == 1)
                {
                    MaterialsSet materialsSet = listViewMaterials.SelectedItems[0].Tag as MaterialsSet;
                    Program.wftDb.MaterialsSet.Remove(materialsSet);
                    Program.wftDb.SaveChanges();
                    ShowMaterial();
                }
                textBoxNameMaterial.Text = "";
                textBoxPrice.Text = "";
                textBoxCount.Text = "";
                textBoxWeight.Text = "";
                textBoxSupplier.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
