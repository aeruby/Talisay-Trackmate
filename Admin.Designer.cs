namespace TrackMate
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            artanPanel1 = new ArtanPanel();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            richTextBox2 = new RichTextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            artanPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // artanPanel1
            // 
            artanPanel1.BackColor = Color.White;
            artanPanel1.BorderRadius = 45;
            artanPanel1.Controls.Add(pictureBox1);
            artanPanel1.Controls.Add(button1);
            artanPanel1.Controls.Add(label2);
            artanPanel1.Controls.Add(label3);
            artanPanel1.Controls.Add(label1);
            artanPanel1.Controls.Add(richTextBox2);
            artanPanel1.Controls.Add(richTextBox1);
            artanPanel1.ForeColor = Color.Black;
            artanPanel1.GradientAngle = 120F;
            artanPanel1.GradientBottomColor = Color.PaleTurquoise;
            artanPanel1.GradientTopColor = Color.LightSkyBlue;
            artanPanel1.Location = new Point(855, 83);
            artanPanel1.Name = "artanPanel1";
            artanPanel1.Size = new Size(386, 420);
            artanPanel1.TabIndex = 0;
            artanPanel1.Paint += artanPanel1_Paint;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(63, 172);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(288, 29);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(63, 149);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(63, 221);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(63, 244);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(288, 29);
            richTextBox2.TabIndex = 0;
            richTextBox2.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(156, 307);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(135, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(135, 387);
            label3.Name = "label3";
            label3.Size = new Size(141, 20);
            label3.TabIndex = 1;
            label3.Text = "Powered by Amarille";
            label3.Click += label3_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1280, 720);
            Controls.Add(artanPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            Load += Admin_Load;
            artanPanel1.ResumeLayout(false);
            artanPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ArtanPanel artanPanel1;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label2;
        private Label label1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox1;
        private Label label3;
    }
}