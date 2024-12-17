namespace systemSklad
{
    partial class ClientForm
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
            this.textBox1Namen = new System.Windows.Forms.TextBox();
            this.textBox2ZKontakt = new System.Windows.Forms.TextBox();
            this.button1Save = new System.Windows.Forms.Button();
            this.button2Back = new System.Windows.Forms.Button();
            this.button3dobklient = new System.Windows.Forms.Button();
            this.button4Delklient = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1Namen
            // 
            this.textBox1Namen.Location = new System.Drawing.Point(681, 12);
            this.textBox1Namen.Name = "textBox1Namen";
            this.textBox1Namen.Size = new System.Drawing.Size(91, 20);
            this.textBox1Namen.TabIndex = 0;
            this.textBox1Namen.Text = "Наименование";
           
            // 
            // textBox2ZKontakt
            // 
            this.textBox2ZKontakt.Location = new System.Drawing.Point(584, 12);
            this.textBox2ZKontakt.Name = "textBox2ZKontakt";
            this.textBox2ZKontakt.Size = new System.Drawing.Size(91, 20);
            this.textBox2ZKontakt.TabIndex = 1;
            this.textBox2ZKontakt.Text = "Контакты";
            // 
            // button1Save
            // 
            this.button1Save.Location = new System.Drawing.Point(125, 405);
            this.button1Save.Name = "button1Save";
            this.button1Save.Size = new System.Drawing.Size(99, 28);
            this.button1Save.TabIndex = 2;
            this.button1Save.Text = "Сохранить";
            this.button1Save.UseVisualStyleBackColor = true;
            this.button1Save.Click += new System.EventHandler(this.button1Save_Click);
            // 
            // button2Back
            // 
            this.button2Back.Location = new System.Drawing.Point(414, 405);
            this.button2Back.Name = "button2Back";
            this.button2Back.Size = new System.Drawing.Size(99, 28);
            this.button2Back.TabIndex = 3;
            this.button2Back.Text = "Отмена";
            this.button2Back.UseVisualStyleBackColor = true;
            // 
            // button3dobklient
            // 
            this.button3dobklient.Location = new System.Drawing.Point(9, 394);
            this.button3dobklient.Name = "button3dobklient";
            this.button3dobklient.Size = new System.Drawing.Size(99, 39);
            this.button3dobklient.TabIndex = 4;
            this.button3dobklient.Text = "Добавить клиента";
            this.button3dobklient.UseVisualStyleBackColor = true;
            // 
            // button4Delklient
            // 
            this.button4Delklient.Location = new System.Drawing.Point(275, 405);
            this.button4Delklient.Name = "button4Delklient";
            this.button4Delklient.Size = new System.Drawing.Size(99, 28);
            this.button4Delklient.TabIndex = 5;
            this.button4Delklient.Text = "Удалить клиента";
            this.button4Delklient.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(504, 301);
            this.dataGridView1.TabIndex = 6;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4Delklient);
            this.Controls.Add(this.button3dobklient);
            this.Controls.Add(this.button2Back);
            this.Controls.Add(this.button1Save);
            this.Controls.Add(this.textBox2ZKontakt);
            this.Controls.Add(this.textBox1Namen);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1Namen;
        private System.Windows.Forms.TextBox textBox2ZKontakt;
        private System.Windows.Forms.Button button1Save;
        private System.Windows.Forms.Button button2Back;
        private System.Windows.Forms.Button button3dobklient;
        private System.Windows.Forms.Button button4Delklient;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}