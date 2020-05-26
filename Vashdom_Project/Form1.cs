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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            labelHello.Text = "Приветствуем вас, " + FormAuthorization.users.login;
            
        }

        private void buttonOpenStaff_Click(object sender, EventArgs e)
        {
            Form formStaff = new FormStaff();
            formStaff.Show();
        }

        private void buttonOpenClients_Click(object sender, EventArgs e)
        {
            Form formClient = new FormClient();
            formClient.Show();
        }

        private void buttonOpenMaterials_Click(object sender, EventArgs e)
        {
            Form formMaterials = new FormMaterials();
            formMaterials.Show();
        }

        private void buttonOpenStorage_Click(object sender, EventArgs e)
        {
            Form formStorage = new FormStorage();
            formStorage.Show();
        }

        private void buttonOpenOrders_Click(object sender, EventArgs e)
        {
            Form formOrders = new FormOrders();
            formOrders.Show();
        }

        private void buttonComeback_Click(object sender, EventArgs e)
        {
            Form formComeback = new FormComeback();
            formComeback.Show();
        }
    }
}
