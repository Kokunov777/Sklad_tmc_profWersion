namespace systemSklad
{
    partial class WarehouseForm
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
            this.back = new System.Windows.Forms.Button();
            this.label1Id = new System.Windows.Forms.Label();
            this.adres = new System.Windows.Forms.TextBox();
            this.ploshad = new System.Windows.Forms.TextBox();
            this.svod_ploshad = new System.Windows.Forms.TextBox();
            this.tip_TMC = new System.Windows.Forms.ListBox();
            this.dob_tip_TMC = new System.Windows.Forms.Button();
            this.del_TMC = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.dob_sklad = new System.Windows.Forms.Button();
            this.del_sklad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(921, 514);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(124, 28);
            this.back.TabIndex = 0;
            this.back.Text = "Отмена";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label1Id
            // 
            this.label1Id.AutoSize = true;
            this.label1Id.Location = new System.Drawing.Point(9, 11);
            this.label1Id.Name = "label1Id";
            this.label1Id.Size = new System.Drawing.Size(16, 13);
            this.label1Id.TabIndex = 1;
            this.label1Id.Text = "Id";
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(12, 39);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(110, 20);
            this.adres.TabIndex = 2;
            // 
            // ploshad
            // 
            this.ploshad.Location = new System.Drawing.Point(12, 65);
            this.ploshad.Name = "ploshad";
            this.ploshad.Size = new System.Drawing.Size(110, 20);
            this.ploshad.TabIndex = 3;
            // 
            // svod_ploshad
            // 
            this.svod_ploshad.Location = new System.Drawing.Point(12, 91);
            this.svod_ploshad.Name = "svod_ploshad";
            this.svod_ploshad.Size = new System.Drawing.Size(110, 20);
            this.svod_ploshad.TabIndex = 4;
            // 
            // tip_TMC
            // 
            this.tip_TMC.FormattingEnabled = true;
            this.tip_TMC.Location = new System.Drawing.Point(212, 12);
            this.tip_TMC.Name = "tip_TMC";
            this.tip_TMC.Size = new System.Drawing.Size(833, 446);
            this.tip_TMC.TabIndex = 5;
            // 
            // dob_tip_TMC
            // 
            this.dob_tip_TMC.Location = new System.Drawing.Point(28, 178);
            this.dob_tip_TMC.Name = "dob_tip_TMC";
            this.dob_tip_TMC.Size = new System.Drawing.Size(161, 28);
            this.dob_tip_TMC.TabIndex = 6;
            this.dob_tip_TMC.Text = "Добавить тип ТМЦ";
            this.dob_tip_TMC.UseVisualStyleBackColor = true;
            this.dob_tip_TMC.Click += new System.EventHandler(this.dob_tip_TMC_Click);
            // 
            // del_TMC
            // 
            this.del_TMC.Location = new System.Drawing.Point(28, 350);
            this.del_TMC.Name = "del_TMC";
            this.del_TMC.Size = new System.Drawing.Size(161, 28);
            this.del_TMC.TabIndex = 7;
            this.del_TMC.Text = "Удалить тип ТМЦ";
            this.del_TMC.UseVisualStyleBackColor = true;
            this.del_TMC.Click += new System.EventHandler(this.del_TMC_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(704, 514);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(161, 28);
            this.Save.TabIndex = 8;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // dob_sklad
            // 
            this.dob_sklad.Location = new System.Drawing.Point(28, 212);
            this.dob_sklad.Name = "dob_sklad";
            this.dob_sklad.Size = new System.Drawing.Size(161, 28);
            this.dob_sklad.TabIndex = 9;
            this.dob_sklad.Text = "Добавить склад";
            this.dob_sklad.UseVisualStyleBackColor = true;
            // 
            // del_sklad
            // 
            this.del_sklad.Location = new System.Drawing.Point(28, 384);
            this.del_sklad.Name = "del_sklad";
            this.del_sklad.Size = new System.Drawing.Size(161, 28);
            this.del_sklad.TabIndex = 10;
            this.del_sklad.Text = "Удалить склад";
            this.del_sklad.UseVisualStyleBackColor = true;
            this.del_sklad.Click += new System.EventHandler(this.del_sklad_Click);
            // 
            // WarehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 577);
            this.Controls.Add(this.del_sklad);
            this.Controls.Add(this.dob_sklad);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.del_TMC);
            this.Controls.Add(this.dob_tip_TMC);
            this.Controls.Add(this.tip_TMC);
            this.Controls.Add(this.svod_ploshad);
            this.Controls.Add(this.ploshad);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.label1Id);
            this.Controls.Add(this.back);
            this.Name = "WarehouseForm";
            this.Text = "WarehouseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label1Id;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.TextBox ploshad;
        private System.Windows.Forms.TextBox svod_ploshad;
        private System.Windows.Forms.ListBox tip_TMC;
        private System.Windows.Forms.Button dob_tip_TMC;
        private System.Windows.Forms.Button del_TMC;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button dob_sklad;
        private System.Windows.Forms.Button del_sklad;
    }
}