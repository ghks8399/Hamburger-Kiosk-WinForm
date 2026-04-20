namespace WinFormsApp6
{
    partial class Form2Side
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2Side));
            groupBox3 = new GroupBox();
            chbSnack = new CheckBox();
            button3 = new Button();
            pictureBox3 = new PictureBox();
            groupBox2 = new GroupBox();
            chbTotato = new CheckBox();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            groupBox1 = new GroupBox();
            chbMacwing = new CheckBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            textSide = new TextBox();
            button4 = new Button();
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
            groupBox3.Controls.Add(chbSnack);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(pictureBox3);
            groupBox3.Location = new Point(479, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(142, 152);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "스낵랩";
            // 
            // chbSnack
            // 
            chbSnack.AutoSize = true;
            chbSnack.Location = new Point(6, 125);
            chbSnack.Name = "chbSnack";
            chbSnack.Size = new Size(54, 19);
            chbSnack.TabIndex = 4;
            chbSnack.Text = "3000";
            chbSnack.UseVisualStyleBackColor = true;
            chbSnack.CheckedChanged += chbSnack_CheckedChanged;
            // 
            // button3
            // 
            button3.Location = new Point(0, 99);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 1;
            button3.Text = "스낵랩";
            button3.UseVisualStyleBackColor = true;
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
            groupBox2.Controls.Add(chbTotato);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Location = new Point(331, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(142, 152);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "감자튀김";
            // 
            // chbTotato
            // 
            chbTotato.AutoSize = true;
            chbTotato.Location = new Point(6, 125);
            chbTotato.Name = "chbTotato";
            chbTotato.Size = new Size(54, 19);
            chbTotato.TabIndex = 4;
            chbTotato.Text = "1400";
            chbTotato.UseVisualStyleBackColor = true;
            chbTotato.CheckedChanged += chbTotato_CheckedChanged;
            // 
            // button2
            // 
            button2.Location = new Point(0, 99);
            button2.Name = "button2";
            button2.Size = new Size(82, 23);
            button2.TabIndex = 1;
            button2.Text = "감자튀김";
            button2.UseVisualStyleBackColor = true;
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
            groupBox1.Controls.Add(chbMacwing);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(183, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(142, 152);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "맥윙";
            // 
            // chbMacwing
            // 
            chbMacwing.AutoSize = true;
            chbMacwing.Location = new Point(6, 125);
            chbMacwing.Name = "chbMacwing";
            chbMacwing.Size = new Size(54, 19);
            chbMacwing.TabIndex = 4;
            chbMacwing.Text = "4000";
            chbMacwing.UseVisualStyleBackColor = true;
            chbMacwing.CheckedChanged += chbMacwing_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(0, 99);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "맥윙";
            button1.UseVisualStyleBackColor = true;
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
            // textSide
            // 
            textSide.Location = new Point(381, 371);
            textSide.Name = "textSide";
            textSide.Size = new Size(240, 23);
            textSide.TabIndex = 12;
            // 
            // button4
            // 
            button4.Location = new Point(270, 371);
            button4.Name = "button4";
            button4.Size = new Size(105, 23);
            button4.TabIndex = 13;
            button4.Text = "사이드 가격확인";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(627, 367);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 27);
            btnSave.TabIndex = 14;
            btnSave.Text = "주문 저장";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form2Side
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(button4);
            Controls.Add(textSide);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form2Side";
            Text = "Form2Side";
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
        private Button button3;
        private PictureBox pictureBox3;
        private GroupBox groupBox2;
        private Button button2;
        private PictureBox pictureBox2;
        private GroupBox groupBox1;
        private Button button1;
        private PictureBox pictureBox1;
        private CheckBox chbSnack;
        private CheckBox chbTotato;
        private CheckBox chbMacwing;
        private TextBox textSide;
        private Button button4;
        private Button btnSave;
    }
}