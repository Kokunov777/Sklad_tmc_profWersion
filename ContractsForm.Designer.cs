namespace systemSklad
{
    partial class ContractsForm
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
            this.comboBox1Client = new System.Windows.Forms.ComboBox();
            this.comboBox2Sklad = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1begin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1End = new System.Windows.Forms.DateTimePicker();
            this.textBox1Symma = new System.Windows.Forms.TextBox();
            this.checkBox1oplachen = new System.Windows.Forms.CheckBox();
            this.comboBox1dogovor = new System.Windows.Forms.ComboBox();
            this.button1Save = new System.Windows.Forms.Button();
            this.button2Back = new System.Windows.Forms.Button();
            this.button3DobDogovor = new System.Windows.Forms.Button();
            this.button4DelDogovor = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "id";
            // 
            // comboBox1Client
            // 
            this.comboBox1Client.FormattingEnabled = true;
            this.comboBox1Client.Location = new System.Drawing.Point(816, 12);
            this.comboBox1Client.Name = "comboBox1Client";
            this.comboBox1Client.Size = new System.Drawing.Size(134, 21);
            this.comboBox1Client.TabIndex = 1;
            this.comboBox1Client.Text = "клиент";
            // 
            // comboBox2Sklad
            // 
            this.comboBox2Sklad.FormattingEnabled = true;
            this.comboBox2Sklad.Location = new System.Drawing.Point(676, 12);
            this.comboBox2Sklad.Name = "comboBox2Sklad";
            this.comboBox2Sklad.Size = new System.Drawing.Size(134, 21);
            this.comboBox2Sklad.TabIndex = 2;
            this.comboBox2Sklad.Text = "Sklad";
            // 
            // dateTimePicker1begin
            // 
            this.dateTimePicker1begin.Location = new System.Drawing.Point(12, 700);
            this.dateTimePicker1begin.Name = "dateTimePicker1begin";
            this.dateTimePicker1begin.Size = new System.Drawing.Size(142, 20);
            this.dateTimePicker1begin.TabIndex = 3;
            // 
            // dateTimePicker1End
            // 
            this.dateTimePicker1End.Location = new System.Drawing.Point(803, 700);
            this.dateTimePicker1End.Name = "dateTimePicker1End";
            this.dateTimePicker1End.Size = new System.Drawing.Size(147, 20);
            this.dateTimePicker1End.TabIndex = 4;
            // 
            // textBox1Symma
            // 
            this.textBox1Symma.Location = new System.Drawing.Point(572, 13);
            this.textBox1Symma.Name = "textBox1Symma";
            this.textBox1Symma.Size = new System.Drawing.Size(98, 20);
            this.textBox1Symma.TabIndex = 5;
            this.textBox1Symma.Text = "symma";
            // 
            // checkBox1oplachen
            // 
            this.checkBox1oplachen.AutoSize = true;
            this.checkBox1oplachen.Location = new System.Drawing.Point(883, 668);
            this.checkBox1oplachen.Name = "checkBox1oplachen";
            this.checkBox1oplachen.Size = new System.Drawing.Size(67, 17);
            this.checkBox1oplachen.TabIndex = 6;
            this.checkBox1oplachen.Text = "оплачен";
            this.checkBox1oplachen.UseVisualStyleBackColor = true;
            // 
            // comboBox1dogovor
            // 
            this.comboBox1dogovor.FormattingEnabled = true;
            this.comboBox1dogovor.Location = new System.Drawing.Point(411, 13);
            this.comboBox1dogovor.Name = "comboBox1dogovor";
            this.comboBox1dogovor.Size = new System.Drawing.Size(155, 21);
            this.comboBox1dogovor.TabIndex = 7;
            this.comboBox1dogovor.Text = "tip dogovora";
            // 
            // button1Save
            // 
            this.button1Save.Location = new System.Drawing.Point(380, 665);
            this.button1Save.Name = "button1Save";
            this.button1Save.Size = new System.Drawing.Size(164, 20);
            this.button1Save.TabIndex = 8;
            this.button1Save.Text = "сохранить";
            this.button1Save.UseVisualStyleBackColor = true;
            this.button1Save.Click += new System.EventHandler(this.button1Save_Click);
            // 
            // button2Back
            // 
            this.button2Back.Location = new System.Drawing.Point(550, 665);
            this.button2Back.Name = "button2Back";
            this.button2Back.Size = new System.Drawing.Size(164, 20);
            this.button2Back.TabIndex = 9;
            this.button2Back.Text = "отмена";
            this.button2Back.UseVisualStyleBackColor = true;
            // 
            // button3DobDogovor
            // 
            this.button3DobDogovor.Location = new System.Drawing.Point(27, 665);
            this.button3DobDogovor.Name = "button3DobDogovor";
            this.button3DobDogovor.Size = new System.Drawing.Size(164, 20);
            this.button3DobDogovor.TabIndex = 10;
            this.button3DobDogovor.Text = "добавление договора";
            this.button3DobDogovor.UseVisualStyleBackColor = true;
            // 
            // button4DelDogovor
            // 
            this.button4DelDogovor.Location = new System.Drawing.Point(197, 665);
            this.button4DelDogovor.Name = "button4DelDogovor";
            this.button4DelDogovor.Size = new System.Drawing.Size(164, 20);
            this.button4DelDogovor.TabIndex = 11;
            this.button4DelDogovor.Text = "Удалить договор";
            this.button4DelDogovor.UseVisualStyleBackColor = true;
            this.button4DelDogovor.Click += new System.EventHandler(this.button4DelDogovor_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(636, 500);
            this.dataGridView1.TabIndex = 12;
            // 
            // ContractsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 732);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4DelDogovor);
            this.Controls.Add(this.button3DobDogovor);
            this.Controls.Add(this.button2Back);
            this.Controls.Add(this.button1Save);
            this.Controls.Add(this.comboBox1dogovor);
            this.Controls.Add(this.checkBox1oplachen);
            this.Controls.Add(this.textBox1Symma);
            this.Controls.Add(this.dateTimePicker1End);
            this.Controls.Add(this.dateTimePicker1begin);
            this.Controls.Add(this.comboBox2Sklad);
            this.Controls.Add(this.comboBox1Client);
            this.Controls.Add(this.label1);
            this.Name = "ContractsForm";
            this.Text = "ContractsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1Client;
        private System.Windows.Forms.ComboBox comboBox2Sklad;
        private System.Windows.Forms.DateTimePicker dateTimePicker1begin;
        private System.Windows.Forms.DateTimePicker dateTimePicker1End;
        private System.Windows.Forms.TextBox textBox1Symma;
        private System.Windows.Forms.CheckBox checkBox1oplachen;
        private System.Windows.Forms.ComboBox comboBox1dogovor;
        private System.Windows.Forms.Button button1Save;
        private System.Windows.Forms.Button button2Back;
        private System.Windows.Forms.Button button3DobDogovor;
        private System.Windows.Forms.Button button4DelDogovor;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}