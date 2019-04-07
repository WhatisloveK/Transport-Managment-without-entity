namespace WinForm
{
    partial class FrmWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWelcome));
            this.cirularButton1 = new WinForm.CirularButton();
            this.SuspendLayout();
            // 
            // cirularButton1
            // 
            this.cirularButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cirularButton1.BackgroundImage")));
            this.cirularButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cirularButton1.Location = new System.Drawing.Point(12, 522);
            this.cirularButton1.Name = "cirularButton1";
            this.cirularButton1.Size = new System.Drawing.Size(88, 86);
            this.cirularButton1.TabIndex = 0;
            this.cirularButton1.UseVisualStyleBackColor = true;
            this.cirularButton1.Click += new System.EventHandler(this.cirularButton1_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(929, 620);
            this.Controls.Add(this.cirularButton1);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.ResumeLayout(false);

        }

        #endregion

        private CirularButton cirularButton1;
    }
}