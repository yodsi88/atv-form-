namespace ProjetoTabajara
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.btncliente = new System.Windows.Forms.Button();
            this.btnproduto = new System.Windows.Forms.Button();
            this.btnfornecedor = new System.Windows.Forms.Button();
            this.btncontaapagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncliente
            // 
            this.btncliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncliente.Location = new System.Drawing.Point(297, 45);
            this.btncliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncliente.Name = "btncliente";
            this.btncliente.Size = new System.Drawing.Size(165, 49);
            this.btncliente.TabIndex = 0;
            this.btncliente.Text = "Cliente";
            this.btncliente.UseVisualStyleBackColor = false;
            this.btncliente.Click += new System.EventHandler(this.btncliente_Click);
            // 
            // btnproduto
            // 
            this.btnproduto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnproduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproduto.Location = new System.Drawing.Point(297, 131);
            this.btnproduto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnproduto.Name = "btnproduto";
            this.btnproduto.Size = new System.Drawing.Size(165, 49);
            this.btnproduto.TabIndex = 1;
            this.btnproduto.Text = "Produto";
            this.btnproduto.UseVisualStyleBackColor = false;
            this.btnproduto.Click += new System.EventHandler(this.btnproduto_Click);
            // 
            // btnfornecedor
            // 
            this.btnfornecedor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnfornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfornecedor.Location = new System.Drawing.Point(297, 214);
            this.btnfornecedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnfornecedor.Name = "btnfornecedor";
            this.btnfornecedor.Size = new System.Drawing.Size(165, 49);
            this.btnfornecedor.TabIndex = 2;
            this.btnfornecedor.Text = "Fornecedor";
            this.btnfornecedor.UseVisualStyleBackColor = false;
            this.btnfornecedor.Click += new System.EventHandler(this.btnfornecedor_Click);
            // 
            // btncontaapagar
            // 
            this.btncontaapagar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncontaapagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncontaapagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncontaapagar.Location = new System.Drawing.Point(297, 292);
            this.btncontaapagar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncontaapagar.Name = "btncontaapagar";
            this.btncontaapagar.Size = new System.Drawing.Size(165, 49);
            this.btncontaapagar.TabIndex = 3;
            this.btncontaapagar.Text = "Contas  á Pagar";
            this.btncontaapagar.UseVisualStyleBackColor = false;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(734, 396);
            this.Controls.Add(this.btncontaapagar);
            this.Controls.Add(this.btnfornecedor);
            this.Controls.Add(this.btnproduto);
            this.Controls.Add(this.btncliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncliente;
        private System.Windows.Forms.Button btnproduto;
        private System.Windows.Forms.Button btnfornecedor;
        private System.Windows.Forms.Button btncontaapagar;
    }
}