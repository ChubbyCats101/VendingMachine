namespace VendingMachine
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
            BlackCoffee = new Button();
            Mocha = new Button();
            Latte = new Button();
            Hotchocolate = new Button();
            pictureBox1 = new PictureBox();
            ReStockButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BlackCoffee
            // 
            BlackCoffee.Image = (Image)resources.GetObject("BlackCoffee.Image");
            BlackCoffee.Location = new Point(132, 32);
            BlackCoffee.Name = "BlackCoffee";
            BlackCoffee.Size = new Size(177, 90);
            BlackCoffee.TabIndex = 0;
            BlackCoffee.UseVisualStyleBackColor = true;
            BlackCoffee.Click += BlackCoffee_Click;
            // 
            // Mocha
            // 
            Mocha.Image = Properties.Resources.mocha;
            Mocha.Location = new Point(133, 128);
            Mocha.Name = "Mocha";
            Mocha.RightToLeft = RightToLeft.No;
            Mocha.Size = new Size(92, 90);
            Mocha.TabIndex = 1;
            Mocha.UseVisualStyleBackColor = true;
            Mocha.Click += Mocha_Click;
            // 
            // Latte
            // 
            Latte.Image = Properties.Resources.latte;
            Latte.Location = new Point(132, 224);
            Latte.Name = "Latte";
            Latte.Size = new Size(177, 90);
            Latte.TabIndex = 2;
            Latte.UseVisualStyleBackColor = true;
            Latte.Click += Latte_Click;
            // 
            // Hotchocolate
            // 
            Hotchocolate.BackgroundImage = Properties.Resources.Hotchocolate;
            Hotchocolate.Location = new Point(231, 128);
            Hotchocolate.Name = "Hotchocolate";
            Hotchocolate.Size = new Size(78, 90);
            Hotchocolate.TabIndex = 3;
            Hotchocolate.UseVisualStyleBackColor = true;
            Hotchocolate.Click += Hotchocolate_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackColor = Color.LightGray;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(169, 360);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // ReStockButton
            // 
            ReStockButton.Location = new Point(306, 574);
            ReStockButton.Name = "ReStockButton";
            ReStockButton.Size = new Size(94, 83);
            ReStockButton.TabIndex = 5;
            ReStockButton.Text = "ปุ่มเติม";
            ReStockButton.UseVisualStyleBackColor = true;
            ReStockButton.Click += ReStockButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(412, 696);
            Controls.Add(ReStockButton);
            Controls.Add(pictureBox1);
            Controls.Add(Hotchocolate);
            Controls.Add(Latte);
            Controls.Add(Mocha);
            Controls.Add(BlackCoffee);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BlackCoffee;
        private Button Mocha;
        private Button Latte;
        private Button Hotchocolate;
        private PictureBox pictureBox1;
        private Button ReStockButton;
    }
}
