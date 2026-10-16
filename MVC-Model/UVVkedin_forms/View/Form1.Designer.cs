namespace UVVkedin_forms
{
    partial class RedeAmigos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonCadastrar = new Button();
            buttonBuscar = new Button();
            labelApelido = new Label();
            labelTelefone = new Label();
            textApelido = new TextBox();
            textTelefone = new TextBox();
            labelEmail = new Label();
            textEmail = new TextBox();
            label1 = new Label();
            buttonRemov = new Button();
            buttonListar = new Button();
            listAmigos = new ListBox();
            SuspendLayout();
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(427, 342);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(75, 23);
            buttonCadastrar.TabIndex = 0;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(545, 342);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(75, 23);
            buttonBuscar.TabIndex = 1;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // labelApelido
            // 
            labelApelido.AutoSize = true;
            labelApelido.Location = new Point(411, 100);
            labelApelido.Name = "labelApelido";
            labelApelido.Size = new Size(48, 15);
            labelApelido.TabIndex = 2;
            labelApelido.Text = "Apelido";
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Location = new Point(407, 175);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(52, 15);
            labelTelefone.TabIndex = 3;
            labelTelefone.Text = "Telefone";
            // 
            // textApelido
            // 
            textApelido.Location = new Point(469, 97);
            textApelido.Name = "textApelido";
            textApelido.Size = new Size(247, 23);
            textApelido.TabIndex = 4;
            // 
            // textTelefone
            // 
            textTelefone.Location = new Point(469, 172);
            textTelefone.Name = "textTelefone";
            textTelefone.Size = new Size(247, 23);
            textTelefone.TabIndex = 5;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(415, 248);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(36, 15);
            labelEmail.TabIndex = 7;
            labelEmail.Text = "Email";
            // 
            // textEmail
            // 
            textEmail.Location = new Point(469, 245);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(247, 23);
            textEmail.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(531, 50);
            label1.Name = "label1";
            label1.Size = new Size(128, 25);
            label1.TabIndex = 9;
            label1.Text = "Rede Amigos";
            // 
            // buttonRemov
            // 
            buttonRemov.Location = new Point(668, 342);
            buttonRemov.Name = "buttonRemov";
            buttonRemov.Size = new Size(75, 23);
            buttonRemov.TabIndex = 10;
            buttonRemov.Text = "Remover";
            buttonRemov.UseVisualStyleBackColor = true;
            // 
            // buttonListar
            // 
            buttonListar.Location = new Point(247, 391);
            buttonListar.Name = "buttonListar";
            buttonListar.Size = new Size(115, 23);
            buttonListar.TabIndex = 11;
            buttonListar.Text = "Listar Todos";
            buttonListar.UseVisualStyleBackColor = true;
            // 
            // listAmigos
            // 
            listAmigos.FormattingEnabled = true;
            listAmigos.Location = new Point(26, 31);
            listAmigos.Name = "listAmigos";
            listAmigos.Size = new Size(363, 334);
            listAmigos.TabIndex = 12;
            // 
            // RedeAmigos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listAmigos);
            Controls.Add(buttonListar);
            Controls.Add(buttonRemov);
            Controls.Add(label1);
            Controls.Add(textEmail);
            Controls.Add(labelEmail);
            Controls.Add(textTelefone);
            Controls.Add(textApelido);
            Controls.Add(labelTelefone);
            Controls.Add(labelApelido);
            Controls.Add(buttonBuscar);
            Controls.Add(buttonCadastrar);
            Name = "RedeAmigos";
            Text = "RedeAmigos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCadastrar;
        private Button buttonBuscar;
        private Label labelApelido;
        private Label labelTelefone;
        private TextBox textApelido;
        private TextBox textTelefone;
        private Label labelEmail;
        private TextBox textEmail;
        private Label label1;
        private Button buttonRemov;
        private Button buttonListar;
        private ListBox listAmigos;
    }
}
