
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace petitto_app
{
    partial class Tela_Pesquisa
    {
        class User
        {
            public String nome { get; set; }
            public String telefone { get; set; }
            public String email { get; set; }


            public User(string nome, string telefone, string email)
            {
                this.nome = nome;
                this.telefone = telefone;
                this.email = email;
            }

        }
        private Boolean pesquisarUsuarioNaLista(int id)
        {
            try
            {

                string rota = "https://json-serverikz.herokuapp.com/doacao/" + textBox1; 
                //string rota = "http://localhost:3000/listaRoute/";

                var requisicaoWeb = WebRequest.CreateHttp(rota);
                requisicaoWeb.Method = "GET";

                using (var resposta = requisicaoWeb.GetResponse())

                {
                    var streamDados = resposta.GetResponseStream();
                    StreamReader reader = new StreamReader(streamDados);
                    object objResponse = reader.ReadToEnd();

                    List<User> listas = JsonConvert.DeserializeObject<List<User>>(objResponse.ToString());
                    streamDados.Close();
                    resposta.Close();

                    Boolean achou = false;
                    foreach (User lista in listas)
                    {
                        //MessageBox.Show(lista.getTitulo());
                        //if (lista.getIdUsuario() == id)
                        //{
                        //    achou = true;
                        //}
                    }

                    return achou;
                }
            }
            catch (System.Net.WebException error)
            {
                MessageBox.Show("Erro: " + error.Message);
                return false;
            }

        }
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textcategoria = new System.Windows.Forms.TextBox();
            this.textidade = new System.Windows.Forms.TextBox();
            this.textsexo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textDescrincao = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textUrl = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textRaca = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textNome_pet = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textTelefone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textCpf = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "PESQUISAR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textcategoria);
            this.panel2.Controls.Add(this.textidade);
            this.panel2.Controls.Add(this.textsexo);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.textDescrincao);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.textUrl);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textRaca);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textNome_pet);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textTelefone);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textCpf);
            this.panel2.Controls.Add(this.textEmail);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textNome);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(837, 537);
            this.panel2.TabIndex = 1;
            // 
            // textcategoria
            // 
            this.textcategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textcategoria.Cursor = System.Windows.Forms.Cursors.Default;
            this.textcategoria.Font = new System.Drawing.Font("Arial", 21F);
            this.textcategoria.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textcategoria.Location = new System.Drawing.Point(674, 243);
            this.textcategoria.Name = "textcategoria";
            this.textcategoria.ReadOnly = true;
            this.textcategoria.Size = new System.Drawing.Size(121, 40);
            this.textcategoria.TabIndex = 57;
            // 
            // textidade
            // 
            this.textidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textidade.Cursor = System.Windows.Forms.Cursors.Default;
            this.textidade.Font = new System.Drawing.Font("Arial", 21F);
            this.textidade.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textidade.Location = new System.Drawing.Point(560, 243);
            this.textidade.Name = "textidade";
            this.textidade.ReadOnly = true;
            this.textidade.Size = new System.Drawing.Size(108, 40);
            this.textidade.TabIndex = 56;
            // 
            // textsexo
            // 
            this.textsexo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textsexo.Cursor = System.Windows.Forms.Cursors.Default;
            this.textsexo.Font = new System.Drawing.Font("Arial", 21F);
            this.textsexo.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textsexo.Location = new System.Drawing.Point(446, 243);
            this.textsexo.Name = "textsexo";
            this.textsexo.ReadOnly = true;
            this.textsexo.Size = new System.Drawing.Size(108, 40);
            this.textsexo.TabIndex = 55;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label14.Location = new System.Drawing.Point(666, 215);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 24);
            this.label14.TabIndex = 51;
            this.label14.Text = "Categoria *";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label13.Location = new System.Drawing.Point(439, 442);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 24);
            this.label13.TabIndex = 50;
            this.label13.Text = "Descrinção *";
            // 
            // textDescrincao
            // 
            this.textDescrincao.BackColor = System.Drawing.Color.White;
            this.textDescrincao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDescrincao.Cursor = System.Windows.Forms.Cursors.Default;
            this.textDescrincao.Font = new System.Drawing.Font("Arial", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDescrincao.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textDescrincao.Location = new System.Drawing.Point(441, 467);
            this.textDescrincao.Name = "textDescrincao";
            this.textDescrincao.ReadOnly = true;
            this.textDescrincao.Size = new System.Drawing.Size(349, 40);
            this.textDescrincao.TabIndex = 49;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label12.Location = new System.Drawing.Point(441, 368);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 24);
            this.label12.TabIndex = 48;
            this.label12.Text = "UrlImagem *";
            // 
            // textUrl
            // 
            this.textUrl.BackColor = System.Drawing.Color.White;
            this.textUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textUrl.Cursor = System.Windows.Forms.Cursors.Default;
            this.textUrl.Font = new System.Drawing.Font("Arial", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUrl.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textUrl.Location = new System.Drawing.Point(443, 397);
            this.textUrl.Name = "textUrl";
            this.textUrl.ReadOnly = true;
            this.textUrl.Size = new System.Drawing.Size(349, 40);
            this.textUrl.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(102)))));
            this.label11.Location = new System.Drawing.Point(433, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 33);
            this.label11.TabIndex = 46;
            this.label11.Text = "Pet";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(102)))));
            this.label10.Location = new System.Drawing.Point(12, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 33);
            this.label10.TabIndex = 45;
            this.label10.Text = "Doador";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(441, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 24);
            this.label6.TabIndex = 44;
            this.label6.Text = "Raça *";
            // 
            // textRaca
            // 
            this.textRaca.BackColor = System.Drawing.Color.White;
            this.textRaca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textRaca.Cursor = System.Windows.Forms.Cursors.Default;
            this.textRaca.Font = new System.Drawing.Font("Arial", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRaca.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textRaca.Location = new System.Drawing.Point(443, 320);
            this.textRaca.Name = "textRaca";
            this.textRaca.ReadOnly = true;
            this.textRaca.Size = new System.Drawing.Size(349, 40);
            this.textRaca.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(561, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 24);
            this.label7.TabIndex = 42;
            this.label7.Text = "Idade *";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(442, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 24);
            this.label8.TabIndex = 41;
            this.label8.Text = "Sexo *";
            // 
            // textNome_pet
            // 
            this.textNome_pet.BackColor = System.Drawing.Color.White;
            this.textNome_pet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNome_pet.Cursor = System.Windows.Forms.Cursors.Default;
            this.textNome_pet.Font = new System.Drawing.Font("Arial", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNome_pet.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textNome_pet.Location = new System.Drawing.Point(446, 155);
            this.textNome_pet.Name = "textNome_pet";
            this.textNome_pet.ReadOnly = true;
            this.textNome_pet.Size = new System.Drawing.Size(349, 40);
            this.textNome_pet.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label9.Location = new System.Drawing.Point(442, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 24);
            this.label9.TabIndex = 39;
            this.label9.Text = "Nome *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(18, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 24);
            this.label5.TabIndex = 38;
            this.label5.Text = "Telefone *";
            // 
            // textTelefone
            // 
            this.textTelefone.BackColor = System.Drawing.Color.White;
            this.textTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTelefone.Cursor = System.Windows.Forms.Cursors.Default;
            this.textTelefone.Font = new System.Drawing.Font("Arial", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTelefone.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textTelefone.Location = new System.Drawing.Point(22, 396);
            this.textTelefone.Name = "textTelefone";
            this.textTelefone.ReadOnly = true;
            this.textTelefone.Size = new System.Drawing.Size(349, 40);
            this.textTelefone.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(18, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 24);
            this.label4.TabIndex = 36;
            this.label4.Text = "CPF *";
            // 
            // textCpf
            // 
            this.textCpf.BackColor = System.Drawing.Color.White;
            this.textCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCpf.Cursor = System.Windows.Forms.Cursors.Default;
            this.textCpf.Font = new System.Drawing.Font("Arial", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCpf.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textCpf.Location = new System.Drawing.Point(22, 320);
            this.textCpf.Name = "textCpf";
            this.textCpf.ReadOnly = true;
            this.textCpf.Size = new System.Drawing.Size(349, 40);
            this.textCpf.TabIndex = 35;
            // 
            // textEmail
            // 
            this.textEmail.BackColor = System.Drawing.Color.White;
            this.textEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textEmail.Cursor = System.Windows.Forms.Cursors.Default;
            this.textEmail.Font = new System.Drawing.Font("Arial", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textEmail.Location = new System.Drawing.Point(22, 242);
            this.textEmail.Name = "textEmail";
            this.textEmail.ReadOnly = true;
            this.textEmail.Size = new System.Drawing.Size(349, 40);
            this.textEmail.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(18, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 33;
            this.label2.Text = "Email *";
            // 
            // textNome
            // 
            this.textNome.BackColor = System.Drawing.Color.White;
            this.textNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNome.Cursor = System.Windows.Forms.Cursors.Default;
            this.textNome.Font = new System.Drawing.Font("Arial", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNome.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textNome.Location = new System.Drawing.Point(22, 155);
            this.textNome.Name = "textNome";
            this.textNome.ReadOnly = true;
            this.textNome.Size = new System.Drawing.Size(349, 40);
            this.textNome.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(18, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 31;
            this.label3.Text = "Nome *";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Arial", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBox1.Location = new System.Drawing.Point(15, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 40);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(178)))), ((int)(((byte)(54)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(231, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "PESQUISAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Tela_Pesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 637);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tela_Pesquisa";
            this.Text = "Tela_Pesquisa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private Label label14;
        private Label label13;
        private TextBox textDescrincao;
        private Label label12;
        private TextBox textUrl;
        private Label label11;
        private Label label10;
        private Label label6;
        private TextBox textRaca;
        private Label label7;
        private Label label8;
        private TextBox textNome_pet;
        private Label label9;
        private Label label5;
        private TextBox textTelefone;
        private Label label4;
        private TextBox textCpf;
        private TextBox textEmail;
        private Label label2;
        private TextBox textNome;
        private Label label3;
        private TextBox textcategoria;
        private TextBox textidade;
        private TextBox textsexo;
    }
}