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
            BlackCoffee.Location = new Point(185, 35);
            BlackCoffee.Margin = new Padding(3, 2, 3, 2);
            BlackCoffee.Name = "BlackCoffee";
            BlackCoffee.Size = new Size(76, 68);
            BlackCoffee.TabIndex = 0;
            BlackCoffee.UseVisualStyleBackColor = true;
            BlackCoffee.Click += BlackCoffee_Click;
            // 
            // Mocha
            // 
            Mocha.Image = Properties.Resources.mocha;
            Mocha.Location = new Point(185, 179);
            Mocha.Margin = new Padding(3, 2, 3, 2);
            Mocha.Name = "Mocha";
            Mocha.RightToLeft = RightToLeft.No;
            Mocha.Size = new Size(76, 68);
            Mocha.TabIndex = 1;
            Mocha.UseVisualStyleBackColor = true;
            Mocha.Click += Mocha_Click;
            // 
            // Latte
            // 
            Latte.Image = Properties.Resources.latte;
            Latte.Location = new Point(185, 107);
            Latte.Margin = new Padding(3, 2, 3, 2);
            Latte.Name = "Latte";
            Latte.Size = new Size(76, 68);
            Latte.TabIndex = 2;
            Latte.UseVisualStyleBackColor = true;
            Latte.Click += Latte_Click;
            // 
            // Hotchocolate
            // 
            Hotchocolate.BackgroundImage = Properties.Resources.Hotchocolate;
            Hotchocolate.Location = new Point(185, 251);
            Hotchocolate.Margin = new Padding(3, 2, 3, 2);
            Hotchocolate.Name = "Hotchocolate";
            Hotchocolate.Size = new Size(76, 68);
            Hotchocolate.TabIndex = 3;
            Hotchocolate.UseVisualStyleBackColor = true;
            Hotchocolate.Click += Hotchocolate_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackColor = Color.LightGray;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(185, 377);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // ReStockButton
            // 
            ReStockButton.BackColor = Color.LightCoral;
            ReStockButton.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReStockButton.Location = new Point(284, 535);
            ReStockButton.Margin = new Padding(3, 2, 3, 2);
            ReStockButton.Name = "ReStockButton";
            ReStockButton.Size = new Size(127, 130);
            ReStockButton.TabIndex = 5;
            ReStockButton.Text = "ปุ่มเติม";
            ReStockButton.UseVisualStyleBackColor = false;
            ReStockButton.Click += ReStockButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.TAOBIN1;
            ClientSize = new Size(411, 676);
            Controls.Add(ReStockButton);
            Controls.Add(pictureBox1);
            Controls.Add(Hotchocolate);
            Controls.Add(Latte);
            Controls.Add(Mocha);
            Controls.Add(BlackCoffee);
            Margin = new Padding(3, 2, 3, 2);
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
