using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace queue
{
    public partial class Form1 : Form
    {
        Queue queue = new Queue();
        public Form1()
        {
            InitializeComponent();
        }

        private void btmEnqueue_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtNameQueue.Text))
            {
                queue.Enqueue(new Nodo(txtNameQueue.Text));
                txtNameQueue.Clear();
                ShowQueue();
            }
            else MessageBox.Show("The name textbox is empty.");
        }

        private void btmDequeue_Click(object sender, EventArgs e)
        {
            if (queue.Start != null)
            {
                queue.Dequeue();
                ShowQueue();
            }
            else MessageBox.Show("The queue is empty.");
        }

        private void btmClearQueue_Click(object sender, EventArgs e)
        {
            dgvQueue.Rows.Clear();
            queue.Start = null;
        }

        void ShowQueue()
        {
            dgvQueue.Rows.Clear();
            if (queue.Start != null) ShowDgv(queue.Start);
        }

        void ShowDgv(Nodo nodo)
        {
            dgvQueue.Rows.Add(nodo.ToString());
            if (nodo.NextNodo != null) ShowDgv(nodo.NextNodo);
        }
    }
}
