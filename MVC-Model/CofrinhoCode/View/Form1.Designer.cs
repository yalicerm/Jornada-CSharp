namespace CofrinhoCode
{
    partial class Form1
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
            label1 = new Label();
            butAdd = new Button();
            butCalcular = new Button();
            butOutros = new Button();
            textboxNome = new TextBox();
            label2 = new Label();
            textBoxValor = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(320, 26);
            label1.Name = "label1";
            label1.Size = new Size(154, 25);
            label1.TabIndex = 0;
            label1.Text = "Cofrinho Digital";
            // 
            // butAdd
            // 
            butAdd.Location = new Point(37, 282);
            butAdd.Name = "butAdd";
            butAdd.Size = new Size(110, 36);
            butAdd.TabIndex = 1;
            butAdd.Text = "Adicionar";
            butAdd.UseVisualStyleBackColor = true;
            butAdd.Click += butAdd_Click;
            // 
            // butCalcular
            // 
            butCalcular.Location = new Point(468, 389);
            butCalcular.Name = "butCalcular";
            butCalcular.Size = new Size(127, 38);
            butCalcular.TabIndex = 2;
            butCalcular.Text = "Calcular Total";
            butCalcular.UseVisualStyleBackColor = true;
            // 
            // butOutros
            // 
            butOutros.Location = new Point(621, 389);
            butOutros.Name = "butOutros";
            butOutros.Size = new Size(155, 39);
            butOutros.TabIndex = 3;
            butOutros.Text = "Outros";
            butOutros.UseVisualStyleBackColor = true;
            butOutros.Click += butOutros_Click;
            // 
            // textboxNome
            // 
            textboxNome.Location = new Point(37, 161);
            textboxNome.Multiline = true;
            textboxNome.Name = "textboxNome";
            textboxNome.Size = new Size(264, 31);
            textboxNome.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(294, 67);
            label2.Name = "label2";
            label2.Size = new Size(225, 15);
            label2.TabIndex = 6;
            label2.Text = "Crie seu cofrinho e utilize as suas funções";
            // 
            // textBoxValor
            // 
            textBoxValor.Location = new Point(37, 223);
            textBoxValor.Multiline = true;
            textBoxValor.Name = "textBoxValor";
            textBoxValor.Size = new Size(264, 27);
            textBoxValor.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 127);
            label3.Name = "label3";
            label3.Size = new Size(176, 15);
            label3.TabIndex = 8;
            label3.Text = "Digite o nome e valor da moeda";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(textBoxValor);
            Controls.Add(label2);
            Controls.Add(textboxNome);
            Controls.Add(butOutros);
            Controls.Add(butCalcular);
            Controls.Add(butAdd);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button butAdd;
        private Button butCalcular;
        private Button butOutros;
        private TextBox textboxNome;
        private Label label2;
        private TextBox textBoxValor;
        private Label label3;
    }
}
