
namespace list
{
    partial class frmMenu
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtListName = new System.Windows.Forms.TextBox();
            this.btmAddBeginning = new System.Windows.Forms.Button();
            this.btmAddEnd = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btmClearList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(309, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name:";
            // 
            // txtListName
            // 
            this.txtListName.Location = new System.Drawing.Point(312, 33);
            this.txtListName.Name = "txtListName";
            this.txtListName.Size = new System.Drawing.Size(169, 20);
            this.txtListName.TabIndex = 8;
            // 
            // btmAddBeginning
            // 
            this.btmAddBeginning.Location = new System.Drawing.Point(312, 81);
            this.btmAddBeginning.Name = "btmAddBeginning";
            this.btmAddBeginning.Size = new System.Drawing.Size(169, 48);
            this.btmAddBeginning.TabIndex = 7;
            this.btmAddBeginning.Text = "Add to the beginning";
            this.btmAddBeginning.UseVisualStyleBackColor = true;
            this.btmAddBeginning.Click += new System.EventHandler(this.btmAddBeginning_Click);
            // 
            // btmAddEnd
            // 
            this.btmAddEnd.Location = new System.Drawing.Point(312, 139);
            this.btmAddEnd.Name = "btmAddEnd";
            this.btmAddEnd.Size = new System.Drawing.Size(169, 48);
            this.btmAddEnd.TabIndex = 6;
            this.btmAddEnd.Text = "Add to the end";
            this.btmAddEnd.UseVisualStyleBackColor = true;
            this.btmAddEnd.Click += new System.EventHandler(this.btmAddEnd_Click);
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToResizeColumns = false;
            this.dgvList.AllowUserToResizeRows = false;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvName});
            this.dgvList.Location = new System.Drawing.Point(12, 12);
            this.dgvList.Name = "dgvList";
            this.dgvList.Size = new System.Drawing.Size(276, 426);
            this.dgvList.TabIndex = 5;
            // 
            // dgvName
            // 
            this.dgvName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvName.HeaderText = "Name";
            this.dgvName.Name = "dgvName";
            this.dgvName.ReadOnly = true;
            // 
            // btmClearList
            // 
            this.btmClearList.Location = new System.Drawing.Point(312, 197);
            this.btmClearList.Name = "btmClearList";
            this.btmClearList.Size = new System.Drawing.Size(169, 48);
            this.btmClearList.TabIndex = 10;
            this.btmClearList.Text = "Clear List";
            this.btmClearList.UseVisualStyleBackColor = true;
            this.btmClearList.Click += new System.EventHandler(this.btmClearDGV_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 449);
            this.Controls.Add(this.btmClearList);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtListName);
            this.Controls.Add(this.btmAddBeginning);
            this.Controls.Add(this.btmAddEnd);
            this.Controls.Add(this.dgvList);
            this.Name = "frmMenu";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtListName;
        private System.Windows.Forms.Button btmAddBeginning;
        private System.Windows.Forms.Button btmAddEnd;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.Button btmClearList;
    }
}

