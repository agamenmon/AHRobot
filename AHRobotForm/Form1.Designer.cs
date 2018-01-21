namespace AHRobotForm
{
    partial class AHRobotForm
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
            this.components = new System.ComponentModel.Container();
            this.captureButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.captureImageBox = new Emgu.CV.UI.ImageBox();
            this.grayscaleImageBox = new Emgu.CV.UI.ImageBox();
            this.smoothedGrayscaleImageBox = new Emgu.CV.UI.ImageBox();
            this.cannyImageBox = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.captureImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayscaleImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smoothedGrayscaleImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cannyImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // captureButton
            // 
            this.captureButton.Location = new System.Drawing.Point(12, 12);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(54, 56);
            this.captureButton.TabIndex = 0;
            this.captureButton.Text = "captureButton";
            this.captureButton.UseVisualStyleBackColor = true;
            this.captureButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(42, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 82);
            this.button2.TabIndex = 1;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(124, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 27);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(196, 52);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(46, 26);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // captureImageBox
            // 
            this.captureImageBox.Location = new System.Drawing.Point(12, 277);
            this.captureImageBox.Name = "captureImageBox";
            this.captureImageBox.Size = new System.Drawing.Size(331, 107);
            this.captureImageBox.TabIndex = 2;
            this.captureImageBox.TabStop = false;
            // 
            // grayscaleImageBox
            // 
            this.grayscaleImageBox.Location = new System.Drawing.Point(358, 260);
            this.grayscaleImageBox.Name = "grayscaleImageBox";
            this.grayscaleImageBox.Size = new System.Drawing.Size(309, 124);
            this.grayscaleImageBox.TabIndex = 4;
            this.grayscaleImageBox.TabStop = false;
            // 
            // smoothedGrayscaleImageBox
            // 
            this.smoothedGrayscaleImageBox.Location = new System.Drawing.Point(369, 41);
            this.smoothedGrayscaleImageBox.Name = "smoothedGrayscaleImageBox";
            this.smoothedGrayscaleImageBox.Size = new System.Drawing.Size(298, 197);
            this.smoothedGrayscaleImageBox.TabIndex = 5;
            this.smoothedGrayscaleImageBox.TabStop = false;
            // 
            // cannyImageBox
            // 
            this.cannyImageBox.Location = new System.Drawing.Point(682, 120);
            this.cannyImageBox.Name = "cannyImageBox";
            this.cannyImageBox.Size = new System.Drawing.Size(411, 238);
            this.cannyImageBox.TabIndex = 6;
            this.cannyImageBox.TabStop = false;
            // 
            // s
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 408);
            this.Controls.Add(this.cannyImageBox);
            this.Controls.Add(this.smoothedGrayscaleImageBox);
            this.Controls.Add(this.grayscaleImageBox);
            this.Controls.Add(this.captureImageBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.captureButton);
            this.Name = "s";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.captureImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayscaleImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smoothedGrayscaleImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cannyImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button captureButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private Emgu.CV.UI.ImageBox captureImageBox;
        private Emgu.CV.UI.ImageBox grayscaleImageBox;
        private Emgu.CV.UI.ImageBox smoothedGrayscaleImageBox;
        private Emgu.CV.UI.ImageBox cannyImageBox;
    }
}

