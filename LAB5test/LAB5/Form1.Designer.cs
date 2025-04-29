using System;

namespace lab5
{
    partial class JuiceBarForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.noSizeRadioButton = new System.Windows.Forms.RadioButton();
            this.twentyOunceRadioButton = new System.Windows.Forms.RadioButton();
            this.sixteenOunceRadioButton = new System.Windows.Forms.RadioButton();
            this.twelveOunceRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ladiesCheckBox = new System.Windows.Forms.CheckBox();
            this.energyBoosterCheckBox = new System.Windows.Forms.CheckBox();
            this.vitaminPackCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.wheatberrySmoothieRadioButton = new System.Windows.Forms.RadioButton();
            this.strawberryBananaRadioButton = new System.Windows.Forms.RadioButton();
            this.pomegranateSmoothieRadioButton = new System.Windows.Forms.RadioButton();
            this.veggieJuiceRadioButton = new System.Windows.Forms.RadioButton();
            this.fruitJuiceRadioButton = new System.Windows.Forms.RadioButton();
            this.addToOrderButton = new System.Windows.Forms.Button();
            this.orderCompleteButton = new System.Windows.Forms.Button();
            this.summaryButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.itemPriceTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.noSizeRadioButton);
            this.groupBox1.Controls.Add(this.twentyOunceRadioButton);
            this.groupBox1.Controls.Add(this.sixteenOunceRadioButton);
            this.groupBox1.Controls.Add(this.twelveOunceRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(36, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(237, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // noSizeRadioButton
            // 
            this.noSizeRadioButton.AutoSize = true;
            this.noSizeRadioButton.Checked = true;
            this.noSizeRadioButton.Location = new System.Drawing.Point(147, 126);
            this.noSizeRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.noSizeRadioButton.Name = "noSizeRadioButton";
            this.noSizeRadioButton.Size = new System.Drawing.Size(84, 20);
            this.noSizeRadioButton.TabIndex = 3;
            this.noSizeRadioButton.TabStop = true;
            this.noSizeRadioButton.Text = "Invincible";
            this.noSizeRadioButton.UseVisualStyleBackColor = true;
            this.noSizeRadioButton.Visible = false;
            this.noSizeRadioButton.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // twentyOunceRadioButton
            // 
            this.twentyOunceRadioButton.AutoSize = true;
            this.twentyOunceRadioButton.Location = new System.Drawing.Point(17, 82);
            this.twentyOunceRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.twentyOunceRadioButton.Name = "twentyOunceRadioButton";
            this.twentyOunceRadioButton.Size = new System.Drawing.Size(111, 20);
            this.twentyOunceRadioButton.TabIndex = 2;
            this.twentyOunceRadioButton.TabStop = true;
            this.twentyOunceRadioButton.Text = "20 Ounce 4.00";
            this.twentyOunceRadioButton.UseVisualStyleBackColor = true;
            // 
            // sixteenOunceRadioButton
            // 
            this.sixteenOunceRadioButton.AutoSize = true;
            this.sixteenOunceRadioButton.Location = new System.Drawing.Point(17, 57);
            this.sixteenOunceRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sixteenOunceRadioButton.Name = "sixteenOunceRadioButton";
            this.sixteenOunceRadioButton.Size = new System.Drawing.Size(111, 20);
            this.sixteenOunceRadioButton.TabIndex = 1;
            this.sixteenOunceRadioButton.TabStop = true;
            this.sixteenOunceRadioButton.Text = "16 Ounce 3.50";
            this.sixteenOunceRadioButton.UseVisualStyleBackColor = true;
            // 
            // twelveOunceRadioButton
            // 
            this.twelveOunceRadioButton.AutoSize = true;
            this.twelveOunceRadioButton.Location = new System.Drawing.Point(17, 31);
            this.twelveOunceRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.twelveOunceRadioButton.Name = "twelveOunceRadioButton";
            this.twelveOunceRadioButton.Size = new System.Drawing.Size(111, 20);
            this.twelveOunceRadioButton.TabIndex = 0;
            this.twelveOunceRadioButton.TabStop = true;
            this.twelveOunceRadioButton.Text = "12 Ounce 3.00";
            this.twelveOunceRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ladiesCheckBox);
            this.groupBox2.Controls.Add(this.energyBoosterCheckBox);
            this.groupBox2.Controls.Add(this.vitaminPackCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(37, 218);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(237, 130);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Extras - 0.50$ Each ";
            // 
            // ladiesCheckBox
            // 
            this.ladiesCheckBox.AutoSize = true;
            this.ladiesCheckBox.Location = new System.Drawing.Point(17, 84);
            this.ladiesCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ladiesCheckBox.Name = "ladiesCheckBox";
            this.ladiesCheckBox.Size = new System.Drawing.Size(114, 20);
            this.ladiesCheckBox.TabIndex = 2;
            this.ladiesCheckBox.Text = "For the &Ladies";
            this.ladiesCheckBox.UseVisualStyleBackColor = true;
            // 
            // energyBoosterCheckBox
            // 
            this.energyBoosterCheckBox.AutoSize = true;
            this.energyBoosterCheckBox.Location = new System.Drawing.Point(17, 58);
            this.energyBoosterCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.energyBoosterCheckBox.Name = "energyBoosterCheckBox";
            this.energyBoosterCheckBox.Size = new System.Drawing.Size(122, 20);
            this.energyBoosterCheckBox.TabIndex = 1;
            this.energyBoosterCheckBox.Text = "Energy &Booster";
            this.energyBoosterCheckBox.UseVisualStyleBackColor = true;
            // 
            // vitaminPackCheckBox
            // 
            this.vitaminPackCheckBox.AutoSize = true;
            this.vitaminPackCheckBox.Location = new System.Drawing.Point(17, 32);
            this.vitaminPackCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vitaminPackCheckBox.Name = "vitaminPackCheckBox";
            this.vitaminPackCheckBox.Size = new System.Drawing.Size(107, 20);
            this.vitaminPackCheckBox.TabIndex = 0;
            this.vitaminPackCheckBox.Text = "&Vitamin Pack";
            this.vitaminPackCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.wheatberrySmoothieRadioButton);
            this.groupBox3.Controls.Add(this.strawberryBananaRadioButton);
            this.groupBox3.Controls.Add(this.pomegranateSmoothieRadioButton);
            this.groupBox3.Controls.Add(this.veggieJuiceRadioButton);
            this.groupBox3.Controls.Add(this.fruitJuiceRadioButton);
            this.groupBox3.Location = new System.Drawing.Point(356, 26);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(237, 265);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select the drink type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Smoothies";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Juices";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // wheatberrySmoothieRadioButton
            // 
            this.wheatberrySmoothieRadioButton.AutoSize = true;
            this.wheatberrySmoothieRadioButton.Location = new System.Drawing.Point(13, 206);
            this.wheatberrySmoothieRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wheatberrySmoothieRadioButton.Name = "wheatberrySmoothieRadioButton";
            this.wheatberrySmoothieRadioButton.Size = new System.Drawing.Size(99, 20);
            this.wheatberrySmoothieRadioButton.TabIndex = 5;
            this.wheatberrySmoothieRadioButton.Text = "&WheatBerry";
            this.wheatberrySmoothieRadioButton.UseVisualStyleBackColor = true;
            // 
            // strawberryBananaRadioButton
            // 
            this.strawberryBananaRadioButton.AutoSize = true;
            this.strawberryBananaRadioButton.Location = new System.Drawing.Point(13, 180);
            this.strawberryBananaRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.strawberryBananaRadioButton.Name = "strawberryBananaRadioButton";
            this.strawberryBananaRadioButton.Size = new System.Drawing.Size(142, 20);
            this.strawberryBananaRadioButton.TabIndex = 4;
            this.strawberryBananaRadioButton.Text = "&Strawberry Banana";
            this.strawberryBananaRadioButton.UseVisualStyleBackColor = true;
            // 
            // pomegranateSmoothieRadioButton
            // 
            this.pomegranateSmoothieRadioButton.AutoSize = true;
            this.pomegranateSmoothieRadioButton.Location = new System.Drawing.Point(13, 154);
            this.pomegranateSmoothieRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pomegranateSmoothieRadioButton.Name = "pomegranateSmoothieRadioButton";
            this.pomegranateSmoothieRadioButton.Size = new System.Drawing.Size(110, 20);
            this.pomegranateSmoothieRadioButton.TabIndex = 3;
            this.pomegranateSmoothieRadioButton.Text = "&Pomegranate";
            this.pomegranateSmoothieRadioButton.UseVisualStyleBackColor = true;
            this.pomegranateSmoothieRadioButton.CheckedChanged += new System.EventHandler(this.radioButton13_CheckedChanged);
            // 
            // veggieJuiceRadioButton
            // 
            this.veggieJuiceRadioButton.AutoSize = true;
            this.veggieJuiceRadioButton.Location = new System.Drawing.Point(13, 82);
            this.veggieJuiceRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.veggieJuiceRadioButton.Name = "veggieJuiceRadioButton";
            this.veggieJuiceRadioButton.Size = new System.Drawing.Size(72, 20);
            this.veggieJuiceRadioButton.TabIndex = 1;
            this.veggieJuiceRadioButton.Text = "Ve&ggie";
            this.veggieJuiceRadioButton.UseVisualStyleBackColor = true;
            // 
            // fruitJuiceRadioButton
            // 
            this.fruitJuiceRadioButton.AutoSize = true;
            this.fruitJuiceRadioButton.Checked = true;
            this.fruitJuiceRadioButton.Location = new System.Drawing.Point(13, 57);
            this.fruitJuiceRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fruitJuiceRadioButton.Name = "fruitJuiceRadioButton";
            this.fruitJuiceRadioButton.Size = new System.Drawing.Size(53, 20);
            this.fruitJuiceRadioButton.TabIndex = 0;
            this.fruitJuiceRadioButton.TabStop = true;
            this.fruitJuiceRadioButton.Text = "&Fruit";
            this.fruitJuiceRadioButton.UseVisualStyleBackColor = true;
            this.fruitJuiceRadioButton.CheckedChanged += new System.EventHandler(this.radioButton11_CheckedChanged);
            // 
            // addToOrderButton
            // 
            this.addToOrderButton.Location = new System.Drawing.Point(397, 313);
            this.addToOrderButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addToOrderButton.Name = "addToOrderButton";
            this.addToOrderButton.Size = new System.Drawing.Size(164, 37);
            this.addToOrderButton.TabIndex = 5;
            this.addToOrderButton.Text = "&Add to Order";
            this.addToOrderButton.UseVisualStyleBackColor = true;
            this.addToOrderButton.Click += new System.EventHandler(this.addToOrderButton_Click_1);
            // 
            // orderCompleteButton
            // 
            this.orderCompleteButton.Enabled = false;
            this.orderCompleteButton.Location = new System.Drawing.Point(397, 354);
            this.orderCompleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.orderCompleteButton.Name = "orderCompleteButton";
            this.orderCompleteButton.Size = new System.Drawing.Size(164, 37);
            this.orderCompleteButton.TabIndex = 6;
            this.orderCompleteButton.Text = "Order &Complete";
            this.orderCompleteButton.UseVisualStyleBackColor = true;
            this.orderCompleteButton.Click += new System.EventHandler(this.orderCompleteButton_Click_1);
            // 
            // summaryButton
            // 
            this.summaryButton.Enabled = false;
            this.summaryButton.Location = new System.Drawing.Point(397, 398);
            this.summaryButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.summaryButton.Name = "summaryButton";
            this.summaryButton.Size = new System.Drawing.Size(164, 37);
            this.summaryButton.TabIndex = 7;
            this.summaryButton.Text = "Summary &Report";
            this.summaryButton.UseVisualStyleBackColor = true;
            this.summaryButton.Click += new System.EventHandler(this.summaryButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(397, 441);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(164, 37);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "&Quantity";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(105, 377);
            this.quantityTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(56, 22);
            this.quantityTextBox.TabIndex = 10;
            // 
            // itemPriceTextBox
            // 
            this.itemPriceTextBox.Location = new System.Drawing.Point(105, 409);
            this.itemPriceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemPriceTextBox.Name = "itemPriceTextBox";
            this.itemPriceTextBox.ReadOnly = true;
            this.itemPriceTextBox.Size = new System.Drawing.Size(119, 22);
            this.itemPriceTextBox.TabIndex = 12;
            this.itemPriceTextBox.TabStop = false;
            this.itemPriceTextBox.TextChanged += new System.EventHandler(this.itemPriceTextBox_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Item Price";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // JuiceBarForm
            // 
            this.AcceptButton = this.addToOrderButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(609, 553);
            this.Controls.Add(this.itemPriceTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.summaryButton);
            this.Controls.Add(this.orderCompleteButton);
            this.Controls.Add(this.addToOrderButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "JuiceBarForm";
            this.Text = "Juice Bar Orders";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();




            // In InitializeComponent(), connect the handlers:
            this.orderCompleteButton.Click += new System.EventHandler(this.orderCompleteButton_Click_1);
            this.twelveOunceRadioButton.CheckedChanged += new System.EventHandler(this.twelveOunceRadioButton_CheckedChanged_1);
            this.sixteenOunceRadioButton.CheckedChanged += new System.EventHandler(this.twelveOunceRadioButton_CheckedChanged_1);
            this.twentyOunceRadioButton.CheckedChanged += new System.EventHandler(this.twelveOunceRadioButton_CheckedChanged_1);
            this.vitaminPackCheckBox.CheckedChanged += new System.EventHandler(this.twelveOunceRadioButton_CheckedChanged_1);
            this.energyBoosterCheckBox.CheckedChanged += new System.EventHandler(this.twelveOunceRadioButton_CheckedChanged_1);
            this.ladiesCheckBox.CheckedChanged += new System.EventHandler(this.twelveOunceRadioButton_CheckedChanged_1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton noSizeRadioButton;
        private System.Windows.Forms.RadioButton twentyOunceRadioButton;
        private System.Windows.Forms.RadioButton sixteenOunceRadioButton;
        private System.Windows.Forms.RadioButton twelveOunceRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton wheatberrySmoothieRadioButton;
        private System.Windows.Forms.RadioButton strawberryBananaRadioButton;
        private System.Windows.Forms.RadioButton pomegranateSmoothieRadioButton;
        private System.Windows.Forms.RadioButton veggieJuiceRadioButton;
        private System.Windows.Forms.RadioButton fruitJuiceRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addToOrderButton;
        private System.Windows.Forms.Button orderCompleteButton;
        private System.Windows.Forms.Button summaryButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox itemPriceTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ladiesCheckBox;
        private System.Windows.Forms.CheckBox energyBoosterCheckBox;
        private System.Windows.Forms.CheckBox vitaminPackCheckBox;
    }
}

