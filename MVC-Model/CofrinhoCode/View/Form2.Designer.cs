namespace CofrinhoCode.View
{
    partial class Form2
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
            labelOutros1 = new Label();
            butMaior = new Button();
            butNumMoedas = new Button();
            buttipoMoeda = new Button();
            labelNumMoedas = new Label();
            labeltipoMoeda = new Label();
            labelMaiorMoeda = new Label();
            textOutros = new TextBox();
            SuspendLayout();
            // 
            // labelOutros1
            // 
            labelOutros1.AutoSize = true;
            labelOutros1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelOutros1.Location = new Point(209, 35);
            labelOutros1.Name = "labelOutros1";
            labelOutros1.Size = new Size(333, 21);
            labelOutros1.TabIndex = 0;
            labelOutros1.Text = "Acessando outros funcionalidades do Cofrinho";
            // 
            // butMaior
            // 
            butMaior.Font = new Font("Segoe UI", 9.75F);
            butMaior.Location = new Point(31, 360);
            butMaior.Name = "butMaior";
            butMaior.Size = new Size(90, 28);
            butMaior.TabIndex = 1;
            butMaior.Text = "Exibir";
            butMaior.UseVisualStyleBackColor = true;
            // 
            // butNumMoedas
            // 
            butNumMoedas.Font = new Font("Segoe UI", 9.75F);
            butNumMoedas.Location = new Point(24, 239);
            butNumMoedas.Name = "butNumMoedas";
            butNumMoedas.Size = new Size(90, 26);
            butNumMoedas.TabIndex = 2;
            butNumMoedas.Text = "Exibir";
            butNumMoedas.UseVisualStyleBackColor = true;
            // 
            // buttipoMoeda
            // 
            buttipoMoeda.Font = new Font("Segoe UI", 9.75F);
            buttipoMoeda.Location = new Point(435, 111);
            buttipoMoeda.Name = "buttipoMoeda";
            buttipoMoeda.Size = new Size(90, 28);
            buttipoMoeda.TabIndex = 3;
            buttipoMoeda.Text = "Exibir";
            buttipoMoeda.UseVisualStyleBackColor = true;
            // 
            // labelNumMoedas
            // 
            labelNumMoedas.AutoSize = true;
            labelNumMoedas.Font = new Font("Segoe UI", 9.75F);
            labelNumMoedas.Location = new Point(24, 203);
            labelNumMoedas.Name = "labelNumMoedas";
            labelNumMoedas.Size = new Size(169, 17);
            labelNumMoedas.TabIndex = 4;
            labelNumMoedas.Text = "Contar número de moedas:";
            // 
            // labeltipoMoeda
            // 
            labeltipoMoeda.AutoSize = true;
            labeltipoMoeda.Font = new Font("Segoe UI", 9.75F);
            labeltipoMoeda.Location = new Point(31, 111);
            labeltipoMoeda.Name = "labeltipoMoeda";
            labeltipoMoeda.Size = new Size(162, 17);
            labeltipoMoeda.TabIndex = 5;
            labeltipoMoeda.Text = "Contar determinado valor:";
            // 
            // labelMaiorMoeda
            // 
            labelMaiorMoeda.AutoSize = true;
            labelMaiorMoeda.Font = new Font("Segoe UI", 9.75F);
            labelMaiorMoeda.Location = new Point(31, 317);
            labelMaiorMoeda.Name = "labelMaiorMoeda";
            labelMaiorMoeda.Size = new Size(91, 17);
            labelMaiorMoeda.TabIndex = 6;
            labelMaiorMoeda.Text = "Maior moeda:";
            // 
            // textOutros
            // 
            textOutros.Location = new Point(209, 110);
            textOutros.Name = "textOutros";
            textOutros.Size = new Size(205, 23);
            textOutros.TabIndex = 7;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 455);
            Controls.Add(textOutros);
            Controls.Add(labelMaiorMoeda);
            Controls.Add(labeltipoMoeda);
            Controls.Add(labelNumMoedas);
            Controls.Add(buttipoMoeda);
            Controls.Add(butNumMoedas);
            Controls.Add(butMaior);
            Controls.Add(labelOutros1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelOutros1;
        private Button butMaior;
        private Button butNumMoedas;
        private Button buttipoMoeda;
        private Label labelNumMoedas;
        private Label labeltipoMoeda;
        private Label labelMaiorMoeda;
        private TextBox textOutros;
    }
}