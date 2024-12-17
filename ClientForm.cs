using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace systemSklad
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void button1Save_Click(object sender, EventArgs e)
        {
            // Проверка на заполнение полей
            if (string.IsNullOrEmpty(textBox1Namen.Text) || string.IsNullOrEmpty(textBox2ZKontakt.Text))
            {
                MessageBox.Show("Пожалуйста, заполните поля \"Наименование\" и \"Контакты\".", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {/*
                ClientForm newClient = new ClientForm();
                newClient.Naimenovanie = textBox1Namen.Text;
                newClient.Kontakty = textBox2ZKontakt.Text;


                //Добавление или изменение клиента
                if (selectedKlient != null)
                { // Редактирование
                    int index = klienti.IndexOf(selectedKlient);
                    klienti[index] = newKlient;
                }
                else
                { //Добавление
                    newKlient.Id = klienti.Count > 0 ? klienti.Max(k => k.Id) + 1 : 1;
                    klienti.Add(newKlient);
                }*/

                UpdateDataGridView();
                MessageBox.Show("Данные о клиенте сохранены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateDataGridView()
        {
            dataGridView1.DataSource = null;
          //  dataGridView1.DataSource = cluent;
        }
    }
}
