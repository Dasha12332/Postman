namespace Postman
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
            pbMap = new PictureBox();
            panelRadio = new Panel();
            panelCheck = new Panel();
            label1 = new Label();
            label2 = new Label();
            buttonCreateMap = new Button();
            buttonWay = new Button();
            textBoxBag = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbMap).BeginInit();
            SuspendLayout();
            // 
            // pbMap
            // 
            pbMap.Location = new Point(20, 25);
            pbMap.Name = "pbMap";
            pbMap.Size = new Size(635, 635);
            pbMap.TabIndex = 0;
            pbMap.TabStop = false;
            // 
            // panelRadio
            // 
            panelRadio.AutoScroll = true;
            panelRadio.Location = new Point(672, 95);
            panelRadio.Name = "panelRadio";
            panelRadio.Size = new Size(187, 423);
            panelRadio.TabIndex = 1;
            // 
            // panelCheck
            // 
            panelCheck.AutoScroll = true;
            panelCheck.Location = new Point(875, 95);
            panelCheck.Name = "panelCheck";
            panelCheck.Size = new Size(187, 423);
            panelCheck.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(672, 53);
            label1.Name = "label1";
            label1.Size = new Size(169, 20);
            label1.TabIndex = 3;
            label1.Text = "Выберите адрес почты";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(875, 53);
            label2.Name = "label2";
            label2.Size = new Size(187, 20);
            label2.TabIndex = 4;
            label2.Text = "Выберите адреса ящиков";
            label2.Click += label2_Click;
            // 
            // buttonCreateMap
            // 
            buttonCreateMap.Location = new Point(711, 606);
            buttonCreateMap.Name = "buttonCreateMap";
            buttonCreateMap.Size = new Size(130, 54);
            buttonCreateMap.TabIndex = 6;
            buttonCreateMap.Text = "Создать карту";
            buttonCreateMap.UseVisualStyleBackColor = true;
            buttonCreateMap.Click += buttonCreateMap_Click;
            // 
            // buttonWay
            // 
            buttonWay.Location = new Point(894, 606);
            buttonWay.Name = "buttonWay";
            buttonWay.Size = new Size(130, 54);
            buttonWay.TabIndex = 7;
            buttonWay.Text = "Поиск пути";
            buttonWay.UseVisualStyleBackColor = true;
            buttonWay.Click += buttonWay_Click;
            // 
            // textBoxBag
            // 
            textBoxBag.Location = new Point(672, 558);
            textBoxBag.Name = "textBoxBag";
            textBoxBag.Size = new Size(125, 27);
            textBoxBag.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(672, 535);
            label3.Name = "label3";
            label3.Size = new Size(246, 20);
            label3.TabIndex = 9;
            label3.Text = "Введите объем сумки почтальона";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 674);
            Controls.Add(label3);
            Controls.Add(textBoxBag);
            Controls.Add(buttonWay);
            Controls.Add(buttonCreateMap);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panelCheck);
            Controls.Add(panelRadio);
            Controls.Add(pbMap);
            Name = "Form1";
            Text = "Почтальон";
            ((System.ComponentModel.ISupportInitialize)pbMap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbMap;
        private Panel panelRadio;
        private Panel panelCheck;
        private Label label1;
        private Label label2;
        private Button buttonCreateMap;
        private Button buttonWay;
        private TextBox textBoxBag;
        private Label label3;
    }
}
