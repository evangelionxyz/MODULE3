namespace Modul3_103022300164
{
    partial class Form1
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
            Cb_Unit_In = new ComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label5 = new Label();
            Tb_In = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Bt_Convert = new Button();
            label4 = new Label();
            Tb_Out = new TextBox();
            Cb_Unit_Out = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Cb_Unit_In
            // 
            Cb_Unit_In.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Cb_Unit_In.FormattingEnabled = true;
            Cb_Unit_In.Items.AddRange(new object[] { "Celcius", "Fahrenheit", "Kelvin", "Reamur" });
            Cb_Unit_In.Location = new Point(3, 44);
            Cb_Unit_In.Name = "Cb_Unit_In";
            Cb_Unit_In.Size = new Size(190, 23);
            Cb_Unit_In.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(Tb_In, 1, 1);
            tableLayoutPanel1.Controls.Add(Cb_Unit_In, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(Bt_Convert, 2, 1);
            tableLayoutPanel1.Controls.Add(label4, 1, 2);
            tableLayoutPanel1.Controls.Add(Tb_Out, 1, 3);
            tableLayoutPanel1.Controls.Add(Cb_Unit_Out, 0, 3);
            tableLayoutPanel1.Location = new Point(12, 62);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel1.Size = new Size(784, 330);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 164);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 9;
            label5.Text = "Satuan Akhir";
            // 
            // Tb_In
            // 
            Tb_In.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Tb_In.Location = new Point(199, 44);
            Tb_In.Name = "Tb_In";
            Tb_In.Size = new Size(386, 23);
            Tb_In.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 2;
            label1.Text = "Satuan Awal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(199, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Nilai Awal";
            // 
            // Bt_Convert
            // 
            Bt_Convert.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Bt_Convert.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Bt_Convert.Location = new Point(591, 44);
            Bt_Convert.Name = "Bt_Convert";
            Bt_Convert.Size = new Size(190, 117);
            Bt_Convert.TabIndex = 4;
            Bt_Convert.Text = "Convert";
            Bt_Convert.UseVisualStyleBackColor = true;
            Bt_Convert.Click += Bt_Convert_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(199, 164);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 6;
            label4.Text = "Nilai Akhir";
            // 
            // Tb_Out
            // 
            Tb_Out.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Tb_Out.Location = new Point(199, 208);
            Tb_Out.Name = "Tb_Out";
            Tb_Out.Size = new Size(386, 23);
            Tb_Out.TabIndex = 10;
            // 
            // Cb_Unit_Out
            // 
            Cb_Unit_Out.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Cb_Unit_Out.FormattingEnabled = true;
            Cb_Unit_Out.Items.AddRange(new object[] { "Celcius", "Fahrenheit", "Kelvin", "Reamur" });
            Cb_Unit_Out.Location = new Point(3, 208);
            Cb_Unit_Out.Name = "Cb_Unit_Out";
            Cb_Unit_Out.Size = new Size(190, 23);
            Cb_Unit_Out.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Konversi Suhu";
            Text = "Konversi Suhu";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox Cb_Unit_In;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox Tb_In;
        private Label label1;
        private Label label2;
        private Button Bt_Convert;
        private Label label4;
        private Label label5;
        private ComboBox Cb_Unit_Out;
        private TextBox Tb_Out;
    }
}
