namespace WinFormsApp6
{
    partial class Form2Burger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2Burger));
            groupBox3 = new GroupBox();
            chb1955 = new CheckBox();
            btn1955 = new Button();
            pictureBox3 = new PictureBox();
            groupBox2 = new GroupBox();
            chbSang = new CheckBox();
            btnSang = new Button();
            pictureBox2 = new PictureBox();
            groupBox1 = new GroupBox();
            chbBig = new CheckBox();
            btnBig = new Button();
            pictureBox1 = new PictureBox();
            textBurger = new TextBox();
            btnpriceburger = new Button();
            btnSave = new Button();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(chb1955);
            groupBox3.Controls.Add(btn1955);
            groupBox3.Controls.Add(pictureBox3);
            groupBox3.Location = new Point(474, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(142, 152);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "1955버거";
            // 
            // chb1955
            // 
            chb1955.AutoSize = true;
            chb1955.Location = new Point(3, 127);
            chb1955.Name = "chb1955";
            chb1955.Size = new Size(54, 19);
            chb1955.TabIndex = 3;
            chb1955.Text = "6000";
            chb1955.UseVisualStyleBackColor = true;
            chb1955.CheckedChanged += chb1955_CheckedChanged;
            // 
            // btn1955
            // 
            btn1955.Location = new Point(0, 99);
            btn1955.Name = "btn1955";
            btn1955.Size = new Size(75, 23);
            btn1955.TabIndex = 1;
            btn1955.Text = "1955";
            btn1955.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 22);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(139, 71);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chbSang);
            groupBox2.Controls.Add(btnSang);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Location = new Point(326, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(142, 152);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "상하이스파이시 버거";
            // 
            // chbSang
            // 
            chbSang.AutoSize = true;
            chbSang.Location = new Point(0, 127);
            chbSang.Name = "chbSang";
            chbSang.Size = new Size(54, 19);
            chbSang.TabIndex = 3;
            chbSang.Text = "5500";
            chbSang.UseVisualStyleBackColor = true;
            chbSang.CheckedChanged += chbSang_CheckedChanged;
            // 
            // btnSang
            // 
            btnSang.Location = new Point(0, 99);
            btnSang.Name = "btnSang";
            btnSang.Size = new Size(98, 23);
            btnSang.TabIndex = 1;
            btnSang.Text = "상하이스파이시";
            btnSang.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(139, 71);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chbBig);
            groupBox1.Controls.Add(btnBig);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(178, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(142, 152);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "빅맥버거";
            // 
            // chbBig
            // 
            chbBig.AutoSize = true;
            chbBig.Location = new Point(6, 127);
            chbBig.Name = "chbBig";
            chbBig.Size = new Size(54, 19);
            chbBig.TabIndex = 3;
            chbBig.Text = "5000";
            chbBig.UseVisualStyleBackColor = true;
            chbBig.CheckedChanged += chbBig_CheckedChanged;
            // 
            // btnBig
            // 
            btnBig.Location = new Point(0, 99);
            btnBig.Name = "btnBig";
            btnBig.Size = new Size(75, 23);
            btnBig.TabIndex = 1;
            btnBig.Text = "빅맥";
            btnBig.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBurger
            // 
            textBurger.Location = new Point(294, 353);
            textBurger.Name = "textBurger";
            textBurger.Size = new Size(240, 23);
            textBurger.TabIndex = 9;
            // 
            // btnpriceburger
            // 
            btnpriceburger.Location = new Point(213, 353);
            btnpriceburger.Name = "btnpriceburger";
            btnpriceburger.Size = new Size(75, 23);
            btnpriceburger.TabIndex = 10;
            btnpriceburger.Text = "버거 가격";
            btnpriceburger.UseVisualStyleBackColor = true;
            btnpriceburger.Click += btnpriceburger_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(541, 353);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 27);
            btnSave.TabIndex = 11;
            btnSave.Text = "주문 저장";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form2Burger
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(btnpriceburger);
            Controls.Add(textBurger);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form2Burger";
            Text = "Form2Burger";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox3;
        private Button btn1955;
        private PictureBox pictureBox3;
        private GroupBox groupBox2;
        private Button btnSang;
        private PictureBox pictureBox2;
        private GroupBox groupBox1;
        private Label label1;
        private Button btnBig;
        private PictureBox pictureBox1;
        private CheckBox checkBox3;
        private CheckBox chbSang;
        private CheckBox chb1955;
        private CheckBox chbBig;
        private TextBox textBurger;
        private Button btnpriceburger;
        private Button btnSave;
    }
}