namespace TSControl
{
    partial class FrmMenu
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
            this.components = new System.ComponentModel.Container();
            this.validaTokenExp = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsExpiraToken = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.testeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meuPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zonasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // validaTokenExp
            // 
            this.validaTokenExp.Enabled = true;
            this.validaTokenExp.Interval = 1000;
            this.validaTokenExp.Tick += new System.EventHandler(this.ValidaTokenExp_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsUsuario,
            this.tsExpiraToken});
            this.statusStrip1.Location = new System.Drawing.Point(0, 262);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(426, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsUsuario
            // 
            this.tsUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsUsuario.Name = "tsUsuario";
            this.tsUsuario.Size = new System.Drawing.Size(19, 17);
            this.tsUsuario.Text = "🧑";
            // 
            // tsExpiraToken
            // 
            this.tsExpiraToken.Name = "tsExpiraToken";
            this.tsExpiraToken.Size = new System.Drawing.Size(19, 17);
            this.tsExpiraToken.Text = "⏱️";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testeToolStripMenuItem,
            this.zonasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(426, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // testeToolStripMenuItem
            // 
            this.testeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarSenhaToolStripMenuItem,
            this.meuPerfilToolStripMenuItem});
            this.testeToolStripMenuItem.Name = "testeToolStripMenuItem";
            this.testeToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.testeToolStripMenuItem.Text = "Usuario";
            // 
            // alterarSenhaToolStripMenuItem
            // 
            this.alterarSenhaToolStripMenuItem.Name = "alterarSenhaToolStripMenuItem";
            this.alterarSenhaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alterarSenhaToolStripMenuItem.Text = "Alterar Senha";
            // 
            // meuPerfilToolStripMenuItem
            // 
            this.meuPerfilToolStripMenuItem.Name = "meuPerfilToolStripMenuItem";
            this.meuPerfilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.meuPerfilToolStripMenuItem.Text = "Meu Perfil";
            this.meuPerfilToolStripMenuItem.Click += new System.EventHandler(this.MeuPerfilToolStripMenuItem_Click);
            // 
            // zonasToolStripMenuItem
            // 
            this.zonasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarToolStripMenuItem});
            this.zonasToolStripMenuItem.Name = "zonasToolStripMenuItem";
            this.zonasToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.zonasToolStripMenuItem.Text = "Zonas";
            // 
            // visualizarToolStripMenuItem
            // 
            this.visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
            this.visualizarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.visualizarToolStripMenuItem.Text = "Visualizar";
            this.visualizarToolStripMenuItem.Click += new System.EventHandler(this.visualizarToolStripMenuItem_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 284);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMenu_FormClosed);
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer validaTokenExp;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsUsuario;
        private ToolStripStatusLabel tsExpiraToken;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem testeToolStripMenuItem;
        private ToolStripMenuItem alterarSenhaToolStripMenuItem;
        private ToolStripMenuItem meuPerfilToolStripMenuItem;
        private ToolStripMenuItem zonasToolStripMenuItem;
        private ToolStripMenuItem visualizarToolStripMenuItem;
    }
}