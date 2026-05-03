namespace StansGrocery
{
    partial class SplashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
            MainPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)MainPictureBox).BeginInit();
            SuspendLayout();
            // 
            // MainPictureBox
            // 
            MainPictureBox.BackgroundImage = (Image)resources.GetObject("MainPictureBox.BackgroundImage");
            MainPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            MainPictureBox.Location = new Point(-7, -29);
            MainPictureBox.Name = "MainPictureBox";
            MainPictureBox.Size = new Size(814, 486);
            MainPictureBox.TabIndex = 0;
            MainPictureBox.TabStop = false;
            // 
            // SplashForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(MainPictureBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashForm";
            Text = "SplashForm";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)MainPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox MainPictureBox;
    }
}