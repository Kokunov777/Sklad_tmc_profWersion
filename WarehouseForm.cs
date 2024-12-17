using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace systemSklad
{
   //  public static List<WarehouseForm> slad = new List<WarehouseForm>();
    public partial class WarehouseForm : Form
    {
        public WarehouseForm()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void Save_Click(object sender, EventArgs e) {



            // Serialize to JSON
           //sssssssssssssssssssssss string jsonData = JsonConvert.SerializeObject(dataToSave, Formatting.Indented);

            // Save to file (replace "data.json" with your desired file path)
            try
            {
                File.WriteAllText("data.json", jsonData);
                MessageBox.Show("Data saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data: {ex.Message}");
            }
        }
         /*{
            if (string.IsNullOrEmpty(adres.Text) || string.IsNullOrEmpty(ploshad.Text))
            {
                MessageBox.Show("Пожалуйста, заполните поля \"Адрес\" и \"Площадь\".", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                double ploshad_value = double.Parse(ploshad.Text); // Используем ploshad.Text
                if (ploshad_value <= 0)
                    throw new ArgumentException("Площадь должна быть больше нуля.");

            *//*    if (dob_sklad != null) // Редактирование существующего склада
                {
                    dob_sklad.Adres = adres.Text;
                    dob_sklad.Ploshad = ploshad_value;
                    dob_sklad.TipyTMC = tip_TMC.Items.Cast<string>().ToList();
                    dob_sklad.SvobodnayaPloshad = ploshad_value;
                }
                else // Добавление нового склада
                {
                    int nextId = dob_sklad.Count > 0 ? sklady.Max(s => s.Id) + 1 : 1;
                    Sklad newSklad = new Sklad
                    {
                        Id = nextId,
                        Adres = adres.Text,
                        Ploshad = ploshad_value,
                        TipyTMC = tip_TMC.Items.Cast<string>().ToList(),
                        SvobodnayaPloshad = ploshad_value
                    };
                    sklady.Add(newSklad);*//*
                }

                MessageBox.Show("Данные о складе сохранены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // Указывает, что данные сохранены успешно
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверный формат площади. Введите число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла непредвиденная ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }*/

        private void dob_tip_TMC_Click(object sender, EventArgs e)
        {
            string newTip = tip_TMC.Text.Trim();
            if (!(string.IsNullOrEmpty(newTip) || tip_TMC.Items.Contains(newTip)))
            {
                tip_TMC.Items.Add(newTip);
                tip_TMC.ClearSelected();
            }
        }

        private void del_sklad_Click(object sender, EventArgs e)
        {
            if (dob_sklad == null)
            {
                MessageBox.Show("Пожалуйста, выберите склад для удаления.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            /*    if (MessageBox.Show($"Вы уверены, что хотите удалить склад {dob_sklad.Adres}? Эта операция необратима!", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    // Удаление склада из списка sklady
                    sklady.Remove(selectedSklad);

                    // Обновление интерфейса (например, DataGridView на главной форме)
                    // ...  (код для обновления DataGridView) ...
                    MessageBox.Show("Склад успешно удален.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Закрыть форму
                }       */
        }

        private void del_TMC_Click(object sender, EventArgs e)
        {
            if (tip_TMC.SelectedIndex == -1)
            {
                MessageBox.Show("Пожалуйста, выберите тип ТМЦ для удаления.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedTip = tip_TMC.SelectedItem.ToString();
            tip_TMC.Items.Remove(selectedTip);
        }
    }

    
}
