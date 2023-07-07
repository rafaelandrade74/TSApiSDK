namespace TSControl
{
    partial class FrmZonasVisualizar
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
            this.sfDataGrid1 = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPaginas = new System.Windows.Forms.Label();
            this.btnPageFinal = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnPageAnterior = new System.Windows.Forms.Button();
            this.btnPageInicial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sfDataGrid1
            // 
            this.sfDataGrid1.AccessibleName = "Table";
            this.sfDataGrid1.AllowEditing = false;
            this.sfDataGrid1.AllowFiltering = true;
            this.sfDataGrid1.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.AllCellsWithLastColumnFill;
            this.sfDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfDataGrid1.Location = new System.Drawing.Point(0, 0);
            this.sfDataGrid1.Name = "sfDataGrid1";
            this.sfDataGrid1.Size = new System.Drawing.Size(800, 427);
            this.sfDataGrid1.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.sfDataGrid1.Style.CheckBoxStyle.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.sfDataGrid1.Style.CheckBoxStyle.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.sfDataGrid1.Style.CheckBoxStyle.IndeterminateBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.sfDataGrid1.Style.HyperlinkStyle.DefaultLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.sfDataGrid1.TabIndex = 0;
            this.sfDataGrid1.Text = "sfDataGrid1";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblPaginas);
            this.panel1.Controls.Add(this.btnPageFinal);
            this.panel1.Controls.Add(this.btnProximo);
            this.panel1.Controls.Add(this.btnPageAnterior);
            this.panel1.Controls.Add(this.btnPageInicial);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 370);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 57);
            this.panel1.TabIndex = 1;
            // 
            // lblPaginas
            // 
            this.lblPaginas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPaginas.AutoSize = true;
            this.lblPaginas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPaginas.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblPaginas.Location = new System.Drawing.Point(347, 23);
            this.lblPaginas.Name = "lblPaginas";
            this.lblPaginas.Size = new System.Drawing.Size(103, 17);
            this.lblPaginas.TabIndex = 8;
            this.lblPaginas.Text = "Pagina 1 de 1000";
            // 
            // btnPageFinal
            // 
            this.btnPageFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPageFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPageFinal.Location = new System.Drawing.Point(749, 18);
            this.btnPageFinal.Name = "btnPageFinal";
            this.btnPageFinal.Size = new System.Drawing.Size(35, 26);
            this.btnPageFinal.TabIndex = 6;
            this.btnPageFinal.Text = ">>";
            this.btnPageFinal.UseVisualStyleBackColor = true;
            this.btnPageFinal.Click += new System.EventHandler(this.BtnPageFinal_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProximo.Location = new System.Drawing.Point(707, 18);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(36, 26);
            this.btnProximo.TabIndex = 5;
            this.btnProximo.Text = ">";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.BtnProximo_Click);
            // 
            // btnPageAnterior
            // 
            this.btnPageAnterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPageAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPageAnterior.Location = new System.Drawing.Point(60, 18);
            this.btnPageAnterior.Name = "btnPageAnterior";
            this.btnPageAnterior.Size = new System.Drawing.Size(35, 26);
            this.btnPageAnterior.TabIndex = 4;
            this.btnPageAnterior.Text = "<";
            this.btnPageAnterior.UseVisualStyleBackColor = true;
            this.btnPageAnterior.Click += new System.EventHandler(this.BtnPageAnterior_Click);
            // 
            // btnPageInicial
            // 
            this.btnPageInicial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPageInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPageInicial.Location = new System.Drawing.Point(18, 18);
            this.btnPageInicial.Name = "btnPageInicial";
            this.btnPageInicial.Size = new System.Drawing.Size(36, 26);
            this.btnPageInicial.TabIndex = 3;
            this.btnPageInicial.Text = "<<";
            this.btnPageInicial.UseVisualStyleBackColor = true;
            this.btnPageInicial.Click += new System.EventHandler(this.BtnPageInicial_Click);
            // 
            // FrmZonasVisualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 427);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sfDataGrid1);
            this.Name = "FrmZonasVisualizar";
            this.Text = "FrmZonasVisualizar";
            this.Load += new System.EventHandler(this.FrmZonasVisualizar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid1;
        private Panel panel1;
        private Label lblPaginas;
        private Button btnPageFinal;
        private Button btnProximo;
        private Button btnPageAnterior;
        private Button btnPageInicial;
    }
}