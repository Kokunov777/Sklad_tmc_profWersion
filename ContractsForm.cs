using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace systemSklad
{
   ///public List<Contract> Contracts = new List<Contracts>();
    public partial class ContractsForm : Form
    {
        public ContractsForm()
        {
            InitializeComponent();
        }

        private void button1Save_Click(object sender, EventArgs e)
        {
            // Проверка на заполнение полей и валидация дат
            if (string.IsNullOrEmpty(comboBox1Client.Text) || string.IsNullOrEmpty(comboBox2Sklad.Text) ||
                string.IsNullOrEmpty(textBox1Symma.Text) || dateTimePicker1begin.Value > dateTimePicker1End.Value)
            {
                MessageBox.Show("Пожалуйста, заполните все поля корректно и убедитесь, что дата начала раньше даты окончания.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                contractsForm newContracts = new contractsForm();
                newContracts.KlientId = (int)comboBox1Client.SelectedValue;
                newContracts.SkladId = (int)comboBox2Sklad.SelectedValue;
                newContracts.DataNachala = dateTimePicker1begin.Value;
                newContracts.DataOkonchaniya = dateTimePicker1End.Value;
                newContracts.Summa = double.Parse(textBox1Symma.Text);
                newContracts.Oplachen = checkBox1oplachen.Checked;
                newContracts.TipDogovora = comboBox1dogovor.Text;

               /* // Добавление или редактирование договора
                if (newContracts != null) // Редактирование
                {
                    int index = Contract.IndexOf(newContracts);
                    Contract[index] = newContracts;
                }
                else // Добавление
                {
                    Contract.Add(newContracts);
                }*/

                UpdateDataGridView(); // Обновление DataGridView
                MessageBox.Show("Данные о договоре сохранены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Закрытие формы
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверный формат суммы. Введите число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = null; // dogovor dol
        }

        private void button4DelDogovor_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите договор для удаления.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Вы уверены, что хотите удалить выбранный договор?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                //Contract.RemoveAt(index);
                UpdateDataGridView();
                MessageBox.Show("Договор успешно удален.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       
    }
}
