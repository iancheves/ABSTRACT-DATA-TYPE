
namespace queue
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvQueue = new System.Windows.Forms.DataGridView();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNameQueue = new System.Windows.Forms.TextBox();
            this.btmEnqueue = new System.Windows.Forms.Button();
            this.btmDequeue = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.btmClearQueue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueue)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQueue
            // 
            this.dgvQueue.AllowUserToAddRows = false;
            this.dgvQueue.AllowUserToDeleteRows = false;
            this.dgvQueue.AllowUserToResizeColumns = false;
            this.dgvQueue.AllowUserToResizeRows = false;
            this.dgvQueue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQueue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvName});
            this.dgvQueue.Location = new System.Drawing.Point(17, 12);
            this.dgvQueue.Name = "dgvQueue";
            this.dgvQueue.Size = new System.Drawing.Size(281, 426);
            this.dgvQueue.TabIndex = 0;
            // 
            // dgvName
            // 
            this.dgvName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvName.HeaderText = "Name";
            this.dgvName.Name = "dgvName";
            this.dgvName.ReadOnly = true;
            this.dgvName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // txtNameQueue
            // 
            this.txtNameQueue.Location = new System.Drawing.Point(317, 35);
            this.txtNameQueue.Name = "txtNameQueue";
            this.txtNameQueue.Size = new System.Drawing.Size(169, 20);
            this.txtNameQueue.TabIndex = 1;
            // 
            // btmEnqueue
            // 
            this.btmEnqueue.Location = new System.Drawing.Point(317, 80);
            this.btmEnqueue.Name = "btmEnqueue";
            this.btmEnqueue.Size = new System.Drawing.Size(169, 48);
            this.btmEnqueue.TabIndex = 3;
            this.btmEnqueue.Text = "Enqueue";
            this.btmEnqueue.UseVisualStyleBackColor = true;
            this.btmEnqueue.Click += new System.EventHandler(this.btmEnqueue_Click);
            // 
            // btmDequeue
            // 
            this.btmDequeue.Location = new System.Drawing.Point(317, 134);
            this.btmDequeue.Name = "btmDequeue";
            this.btmDequeue.Size = new System.Drawing.Size(169, 48);
            this.btmDequeue.TabIndex = 4;
            this.btmDequeue.Text = "Dequeue";
            this.btmDequeue.UseVisualStyleBackColor = true;
            this.btmDequeue.Click += new System.EventHandler(this.btmDequeue_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(316, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name:";
            // 
            // btmClearQueue
            // 
            this.btmClearQueue.Location = new System.Drawing.Point(317, 188);
            this.btmClearQueue.Name = "btmClearQueue";
            this.btmClearQueue.Size = new System.Drawing.Size(169, 48);
            this.btmClearQueue.TabIndex = 11;
            this.btmClearQueue.Text = "Clear Queue";
            this.btmClearQueue.UseVisualStyleBackColor = true;
            this.btmClearQueue.Click += new System.EventHandler(this.btmClearQueue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 449);
            this.Controls.Add(this.btmClearQueue);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btmDequeue);
            this.Controls.Add(this.btmEnqueue);
            this.Controls.Add(this.txtNameQueue);
            this.Controls.Add(this.dgvQueue);
            this.Name = "Form1";
            this.Text = "Queue";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQueue;
        private System.Windows.Forms.TextBox txtNameQueue;
        private System.Windows.Forms.Button btmEnqueue;
        private System.Windows.Forms.Button btmDequeue;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.Button btmClearQueue;
    }
}

