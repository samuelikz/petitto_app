
namespace petitto_app
{
    partial class Tela_Inicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Inicial));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.labelVersion = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonPets = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.buttonCad = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelNavbar = new System.Windows.Forms.Panel();
            this.buttonRestore = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            this.panelNavbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.labelVersion);
            this.panelMenu.Controls.Add(this.buttonDelete);
            this.panelMenu.Controls.Add(this.buttonPets);
            this.panelMenu.Controls.Add(this.buttonAlterar);
            this.panelMenu.Controls.Add(this.buttonUsers);
            this.panelMenu.Controls.Add(this.buttonPesquisar);
            this.panelMenu.Controls.Add(this.buttonCad);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(281, 729);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            this.panelMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panelMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panelMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(204)))));
            this.labelVersion.Location = new System.Drawing.Point(0, 716);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(3);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(23, 13);
            this.labelVersion.TabIndex = 1;
            this.labelVersion.Text = "V.1";
            this.labelVersion.Click += new System.EventHandler(this.labelVersion_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(151)))), ((int)(((byte)(44)))));
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Alef", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.buttonDelete.Location = new System.Drawing.Point(12, 514);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Padding = new System.Windows.Forms.Padding(1);
            this.buttonDelete.Size = new System.Drawing.Size(260, 75);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "EXCLUIR";
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonPets
            // 
            this.buttonPets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(151)))), ((int)(((byte)(44)))));
            this.buttonPets.FlatAppearance.BorderSize = 0;
            this.buttonPets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPets.Font = new System.Drawing.Font("Alef", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonPets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.buttonPets.Location = new System.Drawing.Point(12, 109);
            this.buttonPets.Name = "buttonPets";
            this.buttonPets.Size = new System.Drawing.Size(260, 75);
            this.buttonPets.TabIndex = 1;
            this.buttonPets.Text = "LISTAR PETS";
            this.buttonPets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPets.UseVisualStyleBackColor = false;
            this.buttonPets.Click += new System.EventHandler(this.buttonPets_Click_1);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(151)))), ((int)(((byte)(44)))));
            this.buttonAlterar.FlatAppearance.BorderSize = 0;
            this.buttonAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlterar.Font = new System.Drawing.Font("Alef", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonAlterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.buttonAlterar.Location = new System.Drawing.Point(12, 433);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Padding = new System.Windows.Forms.Padding(1);
            this.buttonAlterar.Size = new System.Drawing.Size(260, 75);
            this.buttonAlterar.TabIndex = 5;
            this.buttonAlterar.Text = "ALTERAR";
            this.buttonAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAlterar.UseVisualStyleBackColor = false;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonUsers
            // 
            this.buttonUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(151)))), ((int)(((byte)(44)))));
            this.buttonUsers.FlatAppearance.BorderSize = 0;
            this.buttonUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsers.Font = new System.Drawing.Font("Alef", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.buttonUsers.Location = new System.Drawing.Point(12, 190);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(260, 75);
            this.buttonUsers.TabIndex = 2;
            this.buttonUsers.Text = "LISTAR USUARIOS";
            this.buttonUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUsers.UseVisualStyleBackColor = false;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click_1);
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(151)))), ((int)(((byte)(44)))));
            this.buttonPesquisar.FlatAppearance.BorderSize = 0;
            this.buttonPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesquisar.Font = new System.Drawing.Font("Alef", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.buttonPesquisar.Location = new System.Drawing.Point(12, 352);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(260, 75);
            this.buttonPesquisar.TabIndex = 4;
            this.buttonPesquisar.Text = "PESQUISAR";
            this.buttonPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPesquisar.UseVisualStyleBackColor = false;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // buttonCad
            // 
            this.buttonCad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(151)))), ((int)(((byte)(44)))));
            this.buttonCad.FlatAppearance.BorderSize = 0;
            this.buttonCad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCad.Font = new System.Drawing.Font("Alef", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonCad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.buttonCad.Location = new System.Drawing.Point(12, 271);
            this.buttonCad.Name = "buttonCad";
            this.buttonCad.Size = new System.Drawing.Size(260, 75);
            this.buttonCad.TabIndex = 3;
            this.buttonCad.Text = "CADASTRAR";
            this.buttonCad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCad.UseVisualStyleBackColor = false;
            this.buttonCad.Click += new System.EventHandler(this.buttonCad_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.panelChildForm.Controls.Add(this.panelNavbar);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(281, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(853, 729);
            this.panelChildForm.TabIndex = 4;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildForm_Paint);
            // 
            // panelNavbar
            // 
            this.panelNavbar.Controls.Add(this.buttonRestore);
            this.panelNavbar.Controls.Add(this.Close);
            this.panelNavbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavbar.Location = new System.Drawing.Point(0, 0);
            this.panelNavbar.Name = "panelNavbar";
            this.panelNavbar.Size = new System.Drawing.Size(853, 55);
            this.panelNavbar.TabIndex = 0;
            this.panelNavbar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelNavbar_Paint);
            this.panelNavbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panelNavbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panelNavbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // buttonRestore
            // 
            this.buttonRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRestore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonRestore.FlatAppearance.BorderSize = 0;
            this.buttonRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestore.Image = ((System.Drawing.Image)(resources.GetObject("buttonRestore.Image")));
            this.buttonRestore.Location = new System.Drawing.Point(754, 3);
            this.buttonRestore.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(48, 48);
            this.buttonRestore.TabIndex = 1;
            this.buttonRestore.UseVisualStyleBackColor = true;
            this.buttonRestore.Click += new System.EventHandler(this.buttonRestore_Click);
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Image = ((System.Drawing.Image)(resources.GetObject("Close.Image")));
            this.Close.Location = new System.Drawing.Point(802, 3);
            this.Close.Margin = new System.Windows.Forms.Padding(0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(48, 48);
            this.Close.TabIndex = 0;
            this.Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(281, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(853, 0);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // Tela_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1134, 729);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Tela_Inicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelChildForm.ResumeLayout(false);
            this.panelNavbar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.Button buttonCad;
        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.Button buttonPets;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelNavbar;
#pragma warning disable CS0108 // "Tela_Inicial.Close" oculta o membro herdado "Form.Close()". Use a nova palavra-chave se foi pretendido ocultar.
        private System.Windows.Forms.Button Close;
#pragma warning restore CS0108 // "Tela_Inicial.Close" oculta o membro herdado "Form.Close()". Use a nova palavra-chave se foi pretendido ocultar.
        private System.Windows.Forms.Button buttonRestore;
    }
}

