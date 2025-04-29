using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Lab6
{
    public partial class Form1 : Form
    {
        Dictionary<string, decimal> foodMenu = new Dictionary<string, decimal>()
        {
            { "Цуйван", 12m },
            { "Будаатай хуурга", 11m },
            { "Гурилтай шөл", 10m },
            { "Банштай шөл", 10.5m }
        };

        Dictionary<string, decimal> drinkMenu = new Dictionary<string, decimal>()
        {
            { "Жигнэмэг", 6m },
            { "Ногоотой котлет", 5.5m },
            { "Амттан", 5m }
        };


        public Form1()
        {
            InitializeComponent();
        }

        private string GetSelectedFood()
        {
            if (radioButton1.Checked) return radioButton1.Text;
            if (radioButton2.Checked) return radioButton2.Text;
            if (radioButton3.Checked) return radioButton3.Text;
            if (radioButton4.Checked) return radioButton4.Text;
            return null;
        }

        private string GetSelectedDrink()
        {
            if (radioButton6.Checked) return radioButton6.Text;
            if (radioButton7.Checked) return radioButton7.Text;
            if (radioButton8.Checked) return radioButton8.Text;
            return null;
        }

        private void button1_Click(object sender, EventArgs e) // "Захиалах"
        {
            string food = GetSelectedFood();
            string drink = GetSelectedDrink();

            if (food == null)
            {
                MessageBox.Show("Үндсэн хоол сонгоно уу!");
                return;
            }

            if (!int.TryParse(textBox1.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Тоо ширхэгийг зөв оруулна уу!");
                return;
            }

            decimal foodTotal = foodMenu[food] * quantity;
            decimal drinkTotal = 0;

            if (drink != null)
            {
                drinkTotal = drinkMenu[drink] * quantity;
            }

            decimal total = foodTotal + drinkTotal;

            // Apply discount
            int foodCount = 1;
            int drinkCount = drink != null ? 1 : 0;

            decimal discount = 0;

            if (foodCount == 2 && drinkCount == 1)
                discount = 0.04m;
            else if (foodCount == 2 && drinkCount == 2)
                discount = 0.08m;

            if (total > 150)
                discount += 0.15m;

            decimal discountedTotal = total * (1 - discount);
            textBox2.Text = discountedTotal.ToString("F2");
        }
        private List<string> GetSelectedFoods()
        {
            List<string> selectedFoods = new List<string>();

            foreach (var control in groupBox1.Controls)
            {
                if (control is System.Windows.Forms.RadioButton cb && cb.Checked)
                {
                    selectedFoods.Add(cb.Text);
                }
            }

            return selectedFoods;
        }

        private List<string> GetSelectedDrinks()
        {
            List<string> selectedDrinks = new List<string>();

            foreach (var control in groupBox2.Controls)
            {
                if (control is System.Windows.Forms.RadioButton cb && cb.Checked)
                {
                    selectedDrinks.Add(cb.Text);
                }
            }

            return selectedDrinks;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string food = GetSelectedFood() ?? "Сонгогдоогүй";
            string drink = GetSelectedDrink() ?? "Сонгогдоогүй";
            string quantity = textBox1.Text.Trim();
            string total = textBox2.Text.Trim();

            string message = $"""
        🍽️ Хоол: {food}
        🥤 Зууш: {drink}
        🔢 Тоо ширхэг: {quantity}
        💰 Нийт үнэ: {total}
    """;

            MessageBox.Show(message, "Захиалгын мэдээлэл", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void button3_Click(object sender, EventArgs e) // "Хөнгөлөлт"
        {
            string info = "Хөнгөлөлтийн нөхцөл:\n" +
                          "✔ 2 хоол + 1 зууш → 4% хөнгөлөлт\n" +
                          "✔ 2 хоол + 2 зууш → 8% хөнгөлөлт\n" +
                          "✔ Нийт дүн 150$-аас их бол → 15% хөнгөлөлт";
            MessageBox.Show(info, "Хөнгөлөлтийн нөхцөл");
        }

        // You can leave these empty if not used
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void groupBox2_Enter(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
