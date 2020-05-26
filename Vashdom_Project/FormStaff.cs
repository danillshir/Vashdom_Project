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
    public partial class FormStaff : Form
    {
        public FormStaff()
        {
            InitializeComponent();
            ShowStaff();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            StaffSet staffSet = new StaffSet();
            staffSet.FirstName = textBoxFirstName.Text;
            staffSet.MiddleName = textBoxMiddleName.Text;
            staffSet.LastName = textBoxLastName.Text;
            staffSet.Position = textBoxPosition.Text;
            staffSet.Phone = textBoxPhone.Text;
            Program.wftDb.StaffSet.Add(staffSet);
            Program.wftDb.SaveChanges();
            ShowStaff();
        }
        void ShowStaff()
        {
            listViewStaff.Items.Clear();
            foreach(StaffSet staffSet in Program.wftDb.StaffSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    staffSet.id.ToString(), staffSet.FirstName, staffSet.MiddleName, staffSet.LastName, staffSet.Position, staffSet.Phone
                });
                item.Tag = staffSet;
                listViewStaff.Items.Add(item);
                
            }
            listViewStaff.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewStaff.SelectedItems.Count==1)
            {
                StaffSet staffSet = listViewStaff.SelectedItems[0].Tag as StaffSet;
                staffSet.FirstName = textBoxFirstName.Text;
                staffSet.MiddleName = textBoxMiddleName.Text;
                staffSet.LastName = textBoxLastName.Text;
                staffSet.Position = textBoxPosition.Text;
                staffSet.Phone = textBoxPhone.Text;
                Program.wftDb.SaveChanges();
                ShowStaff();
            }
        }

        private void listViewStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewStaff.SelectedItems.Count==1)
            {
                StaffSet staffSet = listViewStaff.SelectedItems[0].Tag as StaffSet;
                textBoxFirstName.Text = staffSet.FirstName;
                textBoxMiddleName.Text = staffSet.MiddleName;
                textBoxLastName.Text = staffSet.LastName;
                textBoxPosition.Text = staffSet.Position;
                textBoxPhone.Text = staffSet.Phone;
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPosition.Text = "";
                textBoxPhone.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewStaff.SelectedItems.Count == 1)
                {
                    StaffSet staffSet = listViewStaff.SelectedItems[0].Tag as StaffSet;
                    Program.wftDb.StaffSet.Remove(staffSet);
                    Program.wftDb.SaveChanges();
                    ShowStaff();
                }
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPosition.Text = "";
                textBoxPhone.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
