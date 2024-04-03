using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stack
{
    public partial class frmMenu : Form
    {
        Stack _stack = new Stack();
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btmPush_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtStackName.Text))
            {
                _stack.Push(new Nodo(txtStackName.Text));
                txtStackName.Clear();
                ShowStack();
            }
            else MessageBox.Show("The name textbox is empty.");
        }

        private void btmPop_Click(object sender, EventArgs e)
        {
            if (_stack.Top != null)
            {
                _stack.Pop();
                ShowStack();
            }
            else MessageBox.Show("The Stack is empty.");
        }

        private void btmClearStack_Click(object sender, EventArgs e)
        {
            dgvStack.Rows.Clear();
            _stack.Top = null;
        }

        void ShowStack()
        {
            dgvStack.Rows.Clear();
            if (_stack.Top != null) ShowDgv(_stack.Top);
        }

        void ShowDgv(Nodo nodo)
        {
            dgvStack.Rows.Add(nodo.ToString());
            if (nodo.NextNode != null) ShowDgv(nodo.NextNode);
        }
    }
}
