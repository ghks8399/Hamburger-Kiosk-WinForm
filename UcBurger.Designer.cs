namespace WinFormsApp6
{
    partial class UcBurger
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcBurger));
            groupBox3 = new GroupBox();
            label3 = new Label();
            btn1955 = new Button();
            pictureBox3 = new PictureBox();
            groupBox2 = new GroupBox();
            label2 = new Label();
            btnSang = new Button();
            pictureBox2 = new PictureBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            btnBig = new Button();
            pictureBox1 = new PictureBox();
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
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(btn1955);
            groupBox3.Controls.Add(pictureBox3);
            groupBox3.Location = new Point(299, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(142, 152);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 125);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 2;
            label3.Text = "6000";
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
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(btnSang);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Location = new Point(151, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(142, 152);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 125);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 2;
            label2.Text = "5500";
            // 
            // btnSang
            // 
            btnSang.Location = new Point(0, 99);
            btnSang.Name = "btnSang";
            btnSang.Size = new Size(113, 23);
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
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnBig);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(142, 152);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 125);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 2;
            label1.Text = "5000";
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
            // UcBurger
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "UcBurger";
            Size = new Size(581, 487);
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
        }

        #endregion

        private GroupBox groupBox3;
        private Button btn1955;
        private PictureBox pictureBox3;
        private GroupBox groupBox2;
        private Button btnSang;
        private PictureBox pictureBox2;
        private GroupBox groupBox1;
        private Button btnBig;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
