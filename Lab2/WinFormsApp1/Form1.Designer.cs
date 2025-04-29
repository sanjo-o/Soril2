namespace WinFormsApp1
{
    partial class FlightResForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelBig = new Label();
            lblFlightNum = new Label();
            lblPassName = new Label();
            lblPassNum = new Label();
            lblFrom = new Label();
            lblTo = new Label();
            lblFlightDate = new Label();
            lblType = new Label();
            lblService = new Label();
            txtFlightNum = new TextBox();
            txtPassName = new TextBox();
            txtPassNum = new TextBox();
            cbService = new CheckedListBox();
            lbType = new ListBox();
            btnCheck = new Button();
            btnClear = new Button();
            datePick = new DateTimePicker();
            lbTo = new ListBox();
            lbFrom = new ListBox();
            SuspendLayout();
            // 
            // labelBig
            // 
            labelBig.AutoSize = true;
            labelBig.BackColor = SystemColors.GradientInactiveCaption;
            labelBig.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBig.ForeColor = SystemColors.ControlText;
            labelBig.Location = new Point(48, 36);
            labelBig.Margin = new Padding(4, 0, 4, 0);
            labelBig.Name = "labelBig";
            labelBig.Size = new Size(417, 27);
            labelBig.TabIndex = 0;
            labelBig.Text = "Нислэгийн Захиалгын Дэлгэрэнгүй";
            // 
            // lblFlightNum
            // 
            lblFlightNum.AutoSize = true;
            lblFlightNum.Enabled = false;
            lblFlightNum.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFlightNum.Location = new Point(22, 108);
            lblFlightNum.Margin = new Padding(4, 0, 4, 0);
            lblFlightNum.Name = "lblFlightNum";
            lblFlightNum.Size = new Size(118, 24);
            lblFlightNum.TabIndex = 1;
            lblFlightNum.Text = "Нислэгийн №:";
            lblFlightNum.Click += lblFlightNum_Click;
            // 
            // lblPassName
            // 
            lblPassName.AutoSize = true;
            lblPassName.Enabled = false;
            lblPassName.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassName.Location = new Point(22, 152);
            lblPassName.Margin = new Padding(4, 0, 4, 0);
            lblPassName.Name = "lblPassName";
            lblPassName.Size = new Size(134, 24);
            lblPassName.TabIndex = 1;
            lblPassName.Text = "Зорчигчийн нэр:";
            // 
            // lblPassNum
            // 
            lblPassNum.AutoSize = true;
            lblPassNum.Enabled = false;
            lblPassNum.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassNum.Location = new Point(22, 198);
            lblPassNum.Margin = new Padding(4, 0, 4, 0);
            lblPassNum.Name = "lblPassNum";
            lblPassNum.Size = new Size(131, 24);
            lblPassNum.TabIndex = 1;
            lblPassNum.Text = "Пасспортын №:";
            lblPassNum.Click += passNum_Click;
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Enabled = false;
            lblFrom.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFrom.Location = new Point(22, 250);
            lblFrom.Margin = new Padding(4, 0, 4, 0);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(79, 24);
            lblFrom.TabIndex = 1;
            lblFrom.Text = "Хаанаас:";
            lblFrom.Click += passNum_Click;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Enabled = false;
            lblTo.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTo.Location = new Point(22, 318);
            lblTo.Margin = new Padding(4, 0, 4, 0);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(75, 24);
            lblTo.TabIndex = 1;
            lblTo.Text = "Хаашаа:";
            lblTo.Click += passNum_Click;
            // 
            // lblFlightDate
            // 
            lblFlightDate.AutoSize = true;
            lblFlightDate.Enabled = false;
            lblFlightDate.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFlightDate.Location = new Point(22, 384);
            lblFlightDate.Margin = new Padding(4, 0, 4, 0);
            lblFlightDate.Name = "lblFlightDate";
            lblFlightDate.Size = new Size(142, 24);
            lblFlightDate.TabIndex = 1;
            lblFlightDate.Text = "Нислэгийн огноо:";
            lblFlightDate.Click += lblFlightNum_Click;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Enabled = false;
            lblType.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblType.Location = new Point(22, 434);
            lblType.Margin = new Padding(4, 0, 4, 0);
            lblType.Name = "lblType";
            lblType.Size = new Size(79, 24);
            lblType.TabIndex = 1;
            lblType.Text = "Ангилал:";
            lblType.Click += lblFlightNum_Click;
            // 
            // lblService
            // 
            lblService.AutoSize = true;
            lblService.Enabled = false;
            lblService.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblService.Location = new Point(22, 509);
            lblService.Margin = new Padding(4, 0, 4, 0);
            lblService.Name = "lblService";
            lblService.Size = new Size(93, 24);
            lblService.TabIndex = 1;
            lblService.Text = "Үйлчилгээ:";
            lblService.Click += lblFlightNum_Click;
            // 
            // txtFlightNum
            // 
            txtFlightNum.BorderStyle = BorderStyle.FixedSingle;
            txtFlightNum.Location = new Point(176, 106);
            txtFlightNum.Margin = new Padding(4);
            txtFlightNum.Name = "txtFlightNum";
            txtFlightNum.Size = new Size(320, 30);
            txtFlightNum.TabIndex = 0;
            txtFlightNum.TextChanged += txtFlightNum_TextChanged;
            // 
            // txtPassName
            // 
            txtPassName.BorderStyle = BorderStyle.FixedSingle;
            txtPassName.Location = new Point(176, 152);
            txtPassName.Margin = new Padding(4);
            txtPassName.Name = "txtPassName";
            txtPassName.Size = new Size(320, 30);
            txtPassName.TabIndex = 1;
            txtPassName.TextChanged += txtPassName_TextChanged;
            // 
            // txtPassNum
            // 
            txtPassNum.BorderStyle = BorderStyle.FixedSingle;
            txtPassNum.Location = new Point(176, 198);
            txtPassNum.Margin = new Padding(4);
            txtPassNum.Name = "txtPassNum";
            txtPassNum.Size = new Size(320, 30);
            txtPassNum.TabIndex = 2;
            txtPassNum.TextChanged += txtPassNum_TextChanged;
            // 
            // cbService
            // 
            cbService.BorderStyle = BorderStyle.FixedSingle;
            cbService.FormattingEnabled = true;
            cbService.Items.AddRange(new object[] { "Сувилагч", "Хүүхэд асрагч" });
            cbService.Location = new Point(176, 509);
            cbService.Margin = new Padding(4);
            cbService.Name = "cbService";
            cbService.Size = new Size(320, 52);
            cbService.TabIndex = 7;
            cbService.SelectedIndexChanged += cbService_SelectedIndexChanged;
            // 
            // lbType
            // 
            lbType.BorderStyle = BorderStyle.FixedSingle;
            lbType.FormattingEnabled = true;
            lbType.ItemHeight = 24;
            lbType.Items.AddRange(new object[] { "Ганцаарчилсан", "Бизнес" });
            lbType.Location = new Point(176, 434);
            lbType.Margin = new Padding(4);
            lbType.Name = "lbType";
            lbType.Size = new Size(320, 50);
            lbType.TabIndex = 6;
            lbType.SelectedIndexChanged += lbType_SelectedIndexChanged;
            // 
            // btnCheck
            // 
            btnCheck.BackColor = Color.Silver;
            btnCheck.FlatStyle = FlatStyle.Flat;
            btnCheck.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCheck.Location = new Point(91, 619);
            btnCheck.Margin = new Padding(4);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(143, 34);
            btnCheck.TabIndex = 8;
            btnCheck.Text = "Шалгах";
            btnCheck.UseVisualStyleBackColor = false;
            btnCheck.Click += btnCheck_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Silver;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(270, 619);
            btnClear.Margin = new Padding(4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(149, 34);
            btnClear.TabIndex = 9;
            btnClear.Text = "Цэвэрлэх";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // datePick
            // 
            datePick.Location = new Point(176, 379);
            datePick.Name = "datePick";
            datePick.Size = new Size(320, 30);
            datePick.TabIndex = 10;
            datePick.ValueChanged += datePick_ValueChanged;
            // 
            // lbTo
            // 
            lbTo.BorderStyle = BorderStyle.FixedSingle;
            lbTo.FormattingEnabled = true;
            lbTo.ItemHeight = 24;
            lbTo.Items.AddRange(new object[] { "Монгол", "Америк" });
            lbTo.Location = new Point(176, 318);
            lbTo.Margin = new Padding(4);
            lbTo.Name = "lbTo";
            lbTo.Size = new Size(320, 50);
            lbTo.TabIndex = 6;
            lbTo.SelectedIndexChanged += lbTo_SelectedIndexChanged;
            // 
            // lbFrom
            // 
            lbFrom.BorderStyle = BorderStyle.FixedSingle;
            lbFrom.FormattingEnabled = true;
            lbFrom.ItemHeight = 24;
            lbFrom.Items.AddRange(new object[] { "Монгол", "Америк" });
            lbFrom.Location = new Point(176, 250);
            lbFrom.Margin = new Padding(4);
            lbFrom.Name = "lbFrom";
            lbFrom.Size = new Size(320, 50);
            lbFrom.TabIndex = 6;
            lbFrom.SelectedIndexChanged += lbFrom_SelectedIndexChanged;
            // 
            // FlightResForm
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(505, 681);
            Controls.Add(datePick);
            Controls.Add(btnClear);
            Controls.Add(btnCheck);
            Controls.Add(lbFrom);
            Controls.Add(lbTo);
            Controls.Add(lbType);
            Controls.Add(cbService);
            Controls.Add(txtPassNum);
            Controls.Add(txtPassName);
            Controls.Add(txtFlightNum);
            Controls.Add(lblTo);
            Controls.Add(lblFrom);
            Controls.Add(lblPassNum);
            Controls.Add(lblPassName);
            Controls.Add(lblService);
            Controls.Add(lblType);
            Controls.Add(lblFlightDate);
            Controls.Add(lblFlightNum);
            Controls.Add(labelBig);
            Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FlightResForm";
            Text = "Flight Reservation Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelBig;
        private Label lblFlightNum;
        private Label lblPassName;
        private Label lblPassNum;
        private Label lblFrom;
        private Label lblTo;
        private Label lblFlightDate;
        private Label lblType;
        private Label lblService;
        private TextBox txtFlightNum;
        private TextBox txtPassName;
        private TextBox txtPassNum;
        private CheckedListBox cbService;
        private ListBox lbType;
        private Button btnCheck;
        private Button btnClear;
        private DateTimePicker datePick;
        private ListBox lbTo;
        private ListBox lbFrom;
    }
}
