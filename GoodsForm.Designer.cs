namespace systemSklad
{
    partial class GoodsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1namen = new System.Windows.Forms.TextBox();
            this.comboBox1Tip = new System.Windows.Forms.ComboBox();
            this.numericUpDown1kolvo = new System.Windows.Forms.NumericUpDown();
            this.comboBox1Client = new System.Windows.Forms.ComboBox();
            this.comboBox2Sklad = new System.Windows.Forms.ComboBox();
            this.button1Save = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.button3DobTovar = new System.Windows.Forms.Button();
            this.button4DelTovar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1kolvo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "id";
            // 
            // textBox1namen
            // 
            this.textBox1namen.Location = new System.Drawing.Point(11, 42);
            this.textBox1namen.Name = "textBox1namen";
            this.textBox1namen.Size = new System.Drawing.Size(115, 20);
            this.textBox1namen.TabIndex = 1;
            this.textBox1namen.Text = "наименоание";
            // 
            // comboBox1Tip
            // 
            this.comboBox1Tip.FormattingEnabled = true;
            this.comboBox1Tip.Location = new System.Drawing.Point(813, 12);
            this.comboBox1Tip.Name = "comboBox1Tip";
            this.comboBox1Tip.Size = new System.Drawing.Size(98, 21);
            this.comboBox1Tip.TabIndex = 2;
            // 
            // numericUpDown1kolvo
            // 
            this.numericUpDown1kolvo.Location = new System.Drawing.Point(483, 13);
            this.numericUpDown1kolvo.Name = "numericUpDown1kolvo";
            this.numericUpDown1kolvo.Size = new System.Drawing.Size(112, 20);
            this.numericUpDown1kolvo.TabIndex = 3;
            // 
            // comboBox1Client
            // 
            this.comboBox1Client.FormattingEnabled = true;
            this.comboBox1Client.Location = new System.Drawing.Point(707, 12);
            this.comboBox1Client.Name = "comboBox1Client";
            this.comboBox1Client.Size = new System.Drawing.Size(100, 21);
            this.comboBox1Client.TabIndex = 4;
            // 
            // comboBox2Sklad
            // 
            this.comboBox2Sklad.FormattingEnabled = true;
            this.comboBox2Sklad.Location = new System.Drawing.Point(601, 12);
            this.comboBox2Sklad.Name = "comboBox2Sklad";
            this.comboBox2Sklad.Size = new System.Drawing.Size(100, 21);
            this.comboBox2Sklad.TabIndex = 5;
            // 
            // button1Save
            // 
            this.button1Save.Location = new System.Drawing.Point(339, 589);
            this.button1Save.Name = "button1Save";
            this.button1Save.Size = new System.Drawing.Size(74, 32);
            this.button1Save.TabIndex = 6;
            this.button1Save.Text = "сохранить";
            this.button1Save.UseVisualStyleBackColor = true;
            this.button1Save.Click += new System.EventHandler(this.button1Save_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(499, 589);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(74, 32);
            this.back.TabIndex = 7;
            this.back.Text = "отмена";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // button3DobTovar
            // 
            this.button3DobTovar.Location = new System.Drawing.Point(208, 589);
            this.button3DobTovar.Name = "button3DobTovar";
            this.button3DobTovar.Size = new System.Drawing.Size(116, 32);
            this.button3DobTovar.TabIndex = 8;
            this.button3DobTovar.Text = "Добавить товар";
            this.button3DobTovar.UseVisualStyleBackColor = true;
            this.button3DobTovar.Click += new System.EventHandler(this.button3DobTovar_Click);
            // 
            // button4DelTovar
            // 
            this.button4DelTovar.Location = new System.Drawing.Point(419, 589);
            this.button4DelTovar.Name = "button4DelTovar";
            this.button4DelTovar.Size = new System.Drawing.Size(74, 32);
            this.button4DelTovar.TabIndex = 9;
            this.button4DelTovar.Text = "удаление товара ";
            this.button4DelTovar.UseVisualStyleBackColor = true;
            this.button4DelTovar.Click += new System.EventHandler(this.button4DelTovar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(595, 482);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // GoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 633);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4DelTovar);
            this.Controls.Add(this.button3DobTovar);
            this.Controls.Add(this.back);
            this.Controls.Add(this.button1Save);
            this.Controls.Add(this.comboBox2Sklad);
            this.Controls.Add(this.comboBox1Client);
            this.Controls.Add(this.numericUpDown1kolvo);
            this.Controls.Add(this.comboBox1Tip);
            this.Controls.Add(this.textBox1namen);
            this.Controls.Add(this.label1);
            this.Name = "GoodsForm";
            this.Text = "GoodsForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1kolvo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1namen;
        private System.Windows.Forms.ComboBox comboBox1Tip;
        private System.Windows.Forms.NumericUpDown numericUpDown1kolvo;
        private System.Windows.Forms.ComboBox comboBox1Client;
        private System.Windows.Forms.ComboBox comboBox2Sklad;
        private System.Windows.Forms.Button button1Save;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button button3DobTovar;
        private System.Windows.Forms.Button button4DelTovar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}