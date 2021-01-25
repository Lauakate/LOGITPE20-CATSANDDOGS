namespace CatAndDogs
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
            this.pictureDog = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDog)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureDog
            // 
            this.pictureDog.Location = new System.Drawing.Point(642, 149);
            this.pictureDog.Name = "pictureDog";
            this.pictureDog.Size = new System.Drawing.Size(370, 413);
            this.pictureDog.TabIndex = 0;
            this.pictureDog.TabStop = false;
            this.pictureDog.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(642, 605);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(370, 69);
            this.button1.TabIndex = 1;
            this.button1.Text = "Get Dog Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 774);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureDog);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureDog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureDog;
        private System.Windows.Forms.Button button1;
    }
}

