namespace WinFormsApp6
{
    partial class Form2Drink
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2Drink));
            button3 = new Button();
            pictureBox3 = new PictureBox();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            groupBox1 = new GroupBox();
            RBcider = new RadioButton();
            RBicetea = new RadioButton();
            RBcoke = new RadioButton();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            textDrink = new TextBox();
            btnchoicedrink = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(151, 99);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 1;
            button3.Text = "아이스티";
            button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(151, 22);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(139, 71);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(296, 99);
            button2.Name = "button2";
            button2.Size = new Size(82, 23);
            button2.TabIndex = 1;
            button2.Text = "사이다";
            button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(296, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(139, 71);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RBcider);
            groupBox1.Controls.Add(RBicetea);
            groupBox1.Controls.Add(RBcoke);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(183, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(441, 154);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "음료수";
            // 
            // RBcider
            // 
            RBcider.AutoSize = true;
            RBcider.Location = new Point(296, 127);
            RBcider.Name = "RBcider";
            RBcider.Size = new Size(53, 19);
            RBcider.TabIndex = 12;
            RBcider.TabStop = true;
            RBcider.Text = "2000";
            RBcider.UseVisualStyleBackColor = true;
            // 
            // RBicetea
            // 
            RBicetea.AutoSize = true;
            RBicetea.Location = new Point(151, 127);
            RBicetea.Name = "RBicetea";
            RBicetea.Size = new Size(53, 19);
            RBicetea.TabIndex = 12;
            RBicetea.TabStop = true;
            RBicetea.Text = "3000";
            RBicetea.UseVisualStyleBackColor = true;
            // 
            // RBcoke
            // 
            RBcoke.AutoSize = true;
            RBcoke.Location = new Point(6, 128);
            RBcoke.Name = "RBcoke";
            RBcoke.Size = new Size(53, 19);
            RBcoke.TabIndex = 12;
            RBcoke.TabStop = true;
            RBcoke.Text = "2000";
            RBcoke.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(6, 99);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "콜라";
            button1.UseVisualStyleBackColor = true;
            // 
            // textDrink
            // 
            textDrink.Location = new Point(378, 359);
            textDrink.Name = "textDrink";
            textDrink.Size = new Size(240, 23);
            textDrink.TabIndex = 11;
            // 
            // btnchoicedrink
            // 
            btnchoicedrink.Location = new Point(253, 361);
            btnchoicedrink.Name = "btnchoicedrink";
            btnchoicedrink.Size = new Size(119, 23);
            btnchoicedrink.TabIndex = 12;
            btnchoicedrink.Text = "음료 가격확인";
            btnchoicedrink.UseVisualStyleBackColor = true;
            btnchoicedrink.Click += btnchoicedrink_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(624, 357);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 27);
            btnSave.TabIndex = 13;
            btnSave.Text = "주문 저장";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form2Drink
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(btnchoicedrink);
            Controls.Add(textDrink);
            Controls.Add(groupBox1);
            Name = "Form2Drink";
            Text = "Form2Drink";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button3;
        private PictureBox pictureBox3;
        private Button button2;
        private PictureBox pictureBox2;
        private GroupBox groupBox1;
        private Button button1;
        private PictureBox pictureBox1;
        private TextBox textDrink;
        private RadioButton RBcider;
        private RadioButton RBicetea;
        private RadioButton RBcoke;
        private Button btnchoicedrink;
        private Button btnSave;
    }
}