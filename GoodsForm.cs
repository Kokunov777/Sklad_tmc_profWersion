using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace systemSklad
{
   // public static List<GoodsForm> Goods = new List<GoodsForm>();
    public partial class GoodsForm : Form
    {
        public GoodsForm()
        {
            InitializeComponent();
        }

       

        private void button1Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1namen.Text) || string.IsNullOrEmpty(textBox1namen.Text))
            {
                MessageBox.Show("Пожалуйста, заполните поле \"Адрес\" .", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                goodsForm newTMC = new goodsForm();
                newTMC.Naimenovanie = textBox1namen.Text;
                newTMC.Tip = comboBox1Tip.Text;
                newTMC.Kolichestvo = (int)numericUpDown1kolvo.Value;
                newTMC.KlientId = (int)comboBox1Client.SelectedValue; // предполагается что SelectedValue - это ID клиента
                newTMC.SkladId = (int)comboBox2Sklad.SelectedValue;   // предполагается что SelectedValue - это ID склада

                //Добавление или изменение товара (аналогично обработке склада)
                // ...

                MessageBox.Show("Данные о товаре сохранены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3DobTovar_Click(object sender, EventArgs e)
        {
            ClearFields(); // Очищаем поля формы

        }
        private void ClearFields()
        {
            textBox1namen.Clear();
            comboBox1Tip.SelectedIndex = -1;
            numericUpDown1kolvo.Value = 0;
            comboBox1Client.SelectedIndex = -1;
            comboBox2Sklad.SelectedIndex = -1;
        }

        private void button4DelTovar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите товар для удаления.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           /* if (MessageBox.Show("Вы уверены, что хотите удалить выбранный товар?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                goodsForm selectedTMC = IDataErrorInfo[selectedIndex]; // Получаем удаляемый товар
                goodsForm.RemoveAt(selectedIndex);
                UpdateBounds();
                MessageBox.Show("Товар успешно удален.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.AutoGenerateColumns = false; // Отключаем автоматическое создание столбцов
            dataGridView1.DataSource = null; // сдесь должно быть тмц 
            // Настройка столбцов DataGridView (добавление столбцов, если нужно)
            // ...
        }
    }
}
