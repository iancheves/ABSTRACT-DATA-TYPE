using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace list
{
    public partial class frmMenu : Form
    {
        List list = new List();
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btmAddBeginning_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtListName.Text))
            {
                list.AddToBeginning(new Nodo(txtListName.Text));
                ShowList();
                txtListName.Clear();
            }
            else MessageBox.Show("The name is empty.");
        }

        private void btmAddEnd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtListName.Text))
            {
                list.AddToEnd(new Nodo(txtListName.Text));
                ShowList();
                txtListName.Clear();
            }
            else MessageBox.Show("The name is empty.");
        }

        void ShowList()
        {
            dgvList.Rows.Clear();
            if (list.Start != null) ShowDgv(list.Start);
        }

        void ShowDgv (Nodo nodo)
        {
            dgvList.Rows.Add(nodo.ToString());
            if (nodo.NextNodo != null) ShowDgv(nodo.NextNodo);
        }

        private void btmClearDGV_Click(object sender, EventArgs e)
        {
            dgvList.Rows.Clear();
            list.Start = null;
        }
    }
}
