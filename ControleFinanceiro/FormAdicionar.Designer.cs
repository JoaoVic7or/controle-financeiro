namespace ControleFinanceiro
{
    partial class FormAdicionar
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
            groupBox1 = new GroupBox();
            radioDespesa = new RadioButton();
            radioReceita = new RadioButton();
            buttonCadastrar = new Button();
            inputNome = new TextBox();
            inputValor = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioDespesa);
            groupBox1.Controls.Add(radioReceita);
            groupBox1.Location = new Point(12, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(349, 57);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo";
            // 
            // radioDespesa
            // 
            radioDespesa.AutoSize = true;
            radioDespesa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioDespesa.ForeColor = Color.Red;
            radioDespesa.Location = new Point(173, 22);
            radioDespesa.Name = "radioDespesa";
            radioDespesa.Size = new Size(91, 25);
            radioDespesa.TabIndex = 1;
            radioDespesa.TabStop = true;
            radioDespesa.Text = "Despesa";
            radioDespesa.UseVisualStyleBackColor = true;
            // 
            // radioReceita
            // 
            radioReceita.AutoSize = true;
            radioReceita.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioReceita.ForeColor = Color.Green;
            radioReceita.Location = new Point(83, 22);
            radioReceita.Name = "radioReceita";
            radioReceita.Size = new Size(84, 25);
            radioReceita.TabIndex = 0;
            radioReceita.TabStop = true;
            radioReceita.Text = "Receita";
            radioReceita.UseVisualStyleBackColor = true;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Cursor = Cursors.Hand;
            buttonCadastrar.Location = new Point(12, 294);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(349, 47);
            buttonCadastrar.TabIndex = 1;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // inputNome
            // 
            inputNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inputNome.Location = new Point(12, 154);
            inputNome.Name = "inputNome";
            inputNome.Size = new Size(349, 29);
            inputNome.TabIndex = 2;
            // 
            // inputValor
            // 
            inputValor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            inputValor.Location = new Point(12, 219);
            inputValor.Name = "inputValor";
            inputValor.Size = new Size(349, 29);
            inputValor.TabIndex = 3;
            inputValor.KeyPress += inputValor_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 130);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 4;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 195);
            label2.Name = "label2";
            label2.Size = new Size(46, 21);
            label2.TabIndex = 5;
            label2.Text = "Valor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(49, 18);
            label3.Name = "label3";
            label3.Size = new Size(270, 30);
            label3.TabIndex = 6;
            label3.Text = "Cadastrar Despesa/Receita";
            // 
            // FormAdicionar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 363);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(inputValor);
            Controls.Add(inputNome);
            Controls.Add(buttonCadastrar);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormAdicionar";
            Text = "Cadastro";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioDespesa;
        private RadioButton radioReceita;
        private Button buttonCadastrar;
        private TextBox inputNome;
        private TextBox inputValor;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}