namespace WinFormsApp6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnBuger = new Button();
            btnDrink = new Button();
            btnSide = new Button();
            pictureBox1 = new PictureBox();
            textMain = new TextBox();
            btnTotal = new Button();
            label1 = new Label();
            label2 = new Label();
            cbPay = new ComboBox();
            lbPayInfo = new ListBox();
            btnPay = new Button();
            lbCart = new ListBox();
            btnReset = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnBuger
            // 
            btnBuger.BackgroundImage = (Image)resources.GetObject("btnBuger.BackgroundImage");
            btnBuger.BackgroundImageLayout = ImageLayout.Zoom;
            btnBuger.Location = new Point(12, 12);
            btnBuger.Name = "btnBuger";
            btnBuger.Size = new Size(249, 113);
            btnBuger.TabIndex = 2;
            btnBuger.Text = "버거";
            btnBuger.UseVisualStyleBackColor = true;
            btnBuger.Click += btnBuger_Click;
            // 
            // btnDrink
            // 
            btnDrink.BackgroundImage = (Image)resources.GetObject("btnDrink.BackgroundImage");
            btnDrink.BackgroundImageLayout = ImageLayout.Zoom;
            btnDrink.Location = new Point(12, 131);
            btnDrink.Name = "btnDrink";
            btnDrink.Size = new Size(249, 113);
            btnDrink.TabIndex = 2;
            btnDrink.Text = "음료";
            btnDrink.UseVisualStyleBackColor = true;
            btnDrink.Click += btnDrink_Click;
            // 
            // btnSide
            // 
            btnSide.BackgroundImage = (Image)resources.GetObject("btnSide.BackgroundImage");
            btnSide.BackgroundImageLayout = ImageLayout.Zoom;
            btnSide.Location = new Point(12, 250);
            btnSide.Name = "btnSide";
            btnSide.Size = new Size(249, 113);
            btnSide.TabIndex = 2;
            btnSide.Text = "사이드";
            btnSide.UseVisualStyleBackColor = true;
            btnSide.Click += btnSide_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(565, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(223, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // textMain
            // 
            textMain.Location = new Point(432, 170);
            textMain.Name = "textMain";
            textMain.Size = new Size(304, 23);
            textMain.TabIndex = 4;
            // 
            // btnTotal
            // 
            btnTotal.Location = new Point(317, 170);
            btnTotal.Name = "btnTotal";
            btnTotal.Size = new Size(109, 23);
            btnTotal.TabIndex = 5;
            btnTotal.Text = "총 주문 금액";
            btnTotal.UseVisualStyleBackColor = true;
            btnTotal.Click += btnTotal_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 366);
            label1.Name = "label1";
            label1.Size = new Size(97, 30);
            label1.TabIndex = 6;
            label1.Text = "결제방법";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(187, 366);
            label2.Name = "label2";
            label2.Size = new Size(97, 30);
            label2.TabIndex = 6;
            label2.Text = "결제정보";
            // 
            // cbPay
            // 
            cbPay.FormattingEnabled = true;
            cbPay.Items.AddRange(new object[] { "신용카드", "무통장입금", "포인트" });
            cbPay.Location = new Point(12, 399);
            cbPay.Name = "cbPay";
            cbPay.Size = new Size(121, 23);
            cbPay.TabIndex = 7;
            cbPay.SelectedIndexChanged += cbPay_SelectedIndexChanged;
            // 
            // lbPayInfo
            // 
            lbPayInfo.FormattingEnabled = true;
            lbPayInfo.ItemHeight = 15;
            lbPayInfo.Items.AddRange(new object[] { "일시불", "3개월 할부", "6개월 할부" });
            lbPayInfo.Location = new Point(187, 399);
            lbPayInfo.Name = "lbPayInfo";
            lbPayInfo.Size = new Size(120, 94);
            lbPayInfo.TabIndex = 8;
            // 
            // btnPay
            // 
            btnPay.BackColor = SystemColors.Info;
            btnPay.Location = new Point(354, 398);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(99, 52);
            btnPay.TabIndex = 9;
            btnPay.Text = "결제";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // lbCart
            // 
            lbCart.FormattingEnabled = true;
            lbCart.ItemHeight = 15;
            lbCart.Location = new Point(565, 199);
            lbCart.Name = "lbCart";
            lbCart.Size = new Size(223, 259);
            lbCart.TabIndex = 10;
            lbCart.SelectedIndexChanged += lbCart_SelectedIndexChanged;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(693, 464);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(95, 51);
            btnReset.TabIndex = 11;
            btnReset.Text = "주문 취소";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // button1
            // 
            button1.Location = new Point(267, 12);
            button1.Name = "button1";
            button1.Size = new Size(186, 60);
            button1.TabIndex = 12;
            button1.Text = "초기화면으로 이동";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 527);
            Controls.Add(button1);
            Controls.Add(btnReset);
            Controls.Add(lbCart);
            Controls.Add(btnPay);
            Controls.Add(lbPayInfo);
            Controls.Add(cbPay);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnTotal);
            Controls.Add(textMain);
            Controls.Add(pictureBox1);
            Controls.Add(btnSide);
            Controls.Add(btnDrink);
            Controls.Add(btnBuger);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnBuger;
        private Button btnDrink;
        private Button btnSide;
        private PictureBox pictureBox1;
        private TextBox textMain;
        private Button btnTotal;
        private Label label1;
        private Label label2;
        private ComboBox cbPay;
        private ListBox lbPayInfo;
        private Button btnPay;
        private ListBox lbCart;
        private Button btnReset;
        private Button button1;
    }
}
