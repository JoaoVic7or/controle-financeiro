namespace ControleFinanceiro
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
            buttonAdd = new Button();
            searchBox = new TextBox();
            buttonSearch = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            ColumnType = new DataGridViewTextBoxColumn();
            Columnname = new DataGridViewTextBoxColumn();
            ColumnValue = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Cursor = Cursors.Hand;
            buttonAdd.Location = new Point(12, 83);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(192, 43);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Cadastrar Receita/Despesa";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // searchBox
            // 
            searchBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            searchBox.Location = new Point(802, 94);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(186, 32);
            searchBox.TabIndex = 2;
            // 
            // buttonSearch
            // 
            buttonSearch.Cursor = Cursors.Hand;
            buttonSearch.Location = new Point(994, 94);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(87, 32);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "Buscar";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(802, 77);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 5;
            label1.Text = "Buscar pelo nome";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnType, Columnname, ColumnValue });
            dataGridView1.Location = new Point(12, 132);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1069, 484);
            dataGridView1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(259, 34);
            label2.TabIndex = 6;
            label2.Text = "Controle Financeiro";
            // 
            // ColumnType
            // 
            ColumnType.HeaderText = "Tipo";
            ColumnType.Name = "ColumnType";
            // 
            // Columnname
            // 
            Columnname.HeaderText = "Nome";
            Columnname.Name = "Columnname";
            Columnname.Width = 745;
            // 
            // ColumnValue
            // 
            ColumnValue.HeaderText = "Valor";
            ColumnValue.Name = "ColumnValue";
            ColumnValue.Width = 180;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 628);
            Controls.Add(label2);
            Controls.Add(buttonAdd);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(buttonSearch);
            Controls.Add(searchBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Controle Financeiro";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonAdd;
        private TextBox searchBox;
        private Button buttonSearch;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn ColumnType;
        private DataGridViewTextBoxColumn Columnname;
        private DataGridViewTextBoxColumn ColumnValue;
    }
}