
namespace stack
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
            this.dgvStack = new System.Windows.Forms.DataGridView();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btmPop = new System.Windows.Forms.Button();
            this.btmPush = new System.Windows.Forms.Button();
            this.txtStackName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btmClearStack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStack)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStack
            // 
            this.dgvStack.AllowUserToAddRows = false;
            this.dgvStack.AllowUserToDeleteRows = false;
            this.dgvStack.AllowUserToResizeColumns = false;
            this.dgvStack.AllowUserToResizeRows = false;
            this.dgvStack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStack.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvName});
            this.dgvStack.Location = new System.Drawing.Point(17, 12);
            this.dgvStack.Name = "dgvStack";
            this.dgvStack.Size = new System.Drawing.Size(276, 426);
            this.dgvStack.TabIndex = 0;
            // 
            // dgvName
            // 
            this.dgvName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvName.HeaderText = "Name";
            this.dgvName.Name = "dgvName";
            this.dgvName.ReadOnly = true;
            // 
            // btmPop
            // 
            this.btmPop.Location = new System.Drawing.Point(317, 139);
            this.btmPop.Name = "btmPop";
            this.btmPop.Size = new System.Drawing.Size(169, 48);
            this.btmPop.TabIndex = 1;
            this.btmPop.Text = "Pop";
            this.btmPop.UseVisualStyleBackColor = true;
            this.btmPop.Click += new System.EventHandler(this.btmPop_Click);
            // 
            // btmPush
            // 
            this.btmPush.Location = new System.Drawing.Point(317, 81);
            this.btmPush.Name = "btmPush";
            this.btmPush.Size = new System.Drawing.Size(169, 48);
            this.btmPush.TabIndex = 2;
            this.btmPush.Text = "Push";
            this.btmPush.UseVisualStyleBackColor = true;
            this.btmPush.Click += new System.EventHandler(this.btmPush_Click);
            // 
            // txtStackName
            // 
            this.txtStackName.Location = new System.Drawing.Point(317, 33);
            this.txtStackName.Name = "txtStackName";
            this.txtStackName.Size = new System.Drawing.Size(169, 20);
            this.txtStackName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(314, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name:";
            // 
            // btmClearStack
            // 
            this.btmClearStack.Location = new System.Drawing.Point(317, 198);
            this.btmClearStack.Name = "btmClearStack";
            this.btmClearStack.Size = new System.Drawing.Size(169, 48);
            this.btmClearStack.TabIndex = 12;
            this.btmClearStack.Text = "Clear Stack";
            this.btmClearStack.UseVisualStyleBackColor = true;
            this.btmClearStack.Click += new System.EventHandler(this.btmClearStack_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 455);
            this.Controls.Add(this.btmClearStack);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtStackName);
            this.Controls.Add(this.btmPush);
            this.Controls.Add(this.btmPop);
            this.Controls.Add(this.dgvStack);
            this.Name = "frmMenu";
            this.Text = "Stack";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStack;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.Button btmPop;
        private System.Windows.Forms.Button btmPush;
        private System.Windows.Forms.TextBox txtStackName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btmClearStack;
    }
}

