namespace systemSklad
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnWarehouse = new System.Windows.Forms.Button();
            this.btnGoods = new System.Windows.Forms.Button();
            this.btnContracts = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnReportPayment = new System.Windows.Forms.Button();
            this.Playment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWarehouse
            // 
            this.btnWarehouse.Location = new System.Drawing.Point(12, 34);
            this.btnWarehouse.Name = "btnWarehouse";
            this.btnWarehouse.Size = new System.Drawing.Size(130, 38);
            this.btnWarehouse.TabIndex = 0;
            this.btnWarehouse.Text = "Склад";
            this.btnWarehouse.UseVisualStyleBackColor = true;
            this.btnWarehouse.Click += new System.EventHandler(this.btnWarehouse_Click);
            // 
            // btnGoods
            // 
            this.btnGoods.Location = new System.Drawing.Point(12, 97);
            this.btnGoods.Name = "btnGoods";
            this.btnGoods.Size = new System.Drawing.Size(130, 38);
            this.btnGoods.TabIndex = 1;
            this.btnGoods.Text = "ТМЦ";
            this.btnGoods.UseVisualStyleBackColor = true;
            this.btnGoods.Click += new System.EventHandler(this.btnGoods_Click);
            // 
            // btnContracts
            // 
            this.btnContracts.Location = new System.Drawing.Point(12, 167);
            this.btnContracts.Name = "btnContracts";
            this.btnContracts.Size = new System.Drawing.Size(130, 38);
            this.btnContracts.TabIndex = 2;
            this.btnContracts.Text = "Договоры";
            this.btnContracts.UseVisualStyleBackColor = true;
            this.btnContracts.Click += new System.EventHandler(this.btnContracts_Click);
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(12, 226);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(130, 38);
            this.btnClient.TabIndex = 3;
            this.btnClient.Text = "Клиент";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnReportPayment
            // 
            this.btnReportPayment.Location = new System.Drawing.Point(12, 284);
            this.btnReportPayment.Name = "btnReportPayment";
            this.btnReportPayment.Size = new System.Drawing.Size(127, 36);
            this.btnReportPayment.TabIndex = 4;
            this.btnReportPayment.Text = "Отчет и оплата";
            this.btnReportPayment.UseVisualStyleBackColor = true;
            this.btnReportPayment.Click += new System.EventHandler(this.btnReportPayment_Click);
            // 
            // Playment
            // 
            this.Playment.Location = new System.Drawing.Point(12, 326);
            this.Playment.Name = "Playment";
            this.Playment.Size = new System.Drawing.Size(127, 29);
            this.Playment.TabIndex = 5;
            this.Playment.Text = "оплата";
            this.Playment.UseVisualStyleBackColor = true;
            this.Playment.Click += new System.EventHandler(this.Playment_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 447);
            this.Controls.Add(this.Playment);
            this.Controls.Add(this.btnReportPayment);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.btnContracts);
            this.Controls.Add(this.btnGoods);
            this.Controls.Add(this.btnWarehouse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWarehouse;
        private System.Windows.Forms.Button btnGoods;
        private System.Windows.Forms.Button btnContracts;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnReportPayment;
        private System.Windows.Forms.Button Playment;
    }
}

