namespace example
{
    partial class Form1
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
            this.captureImageBox = new Emgu.CV.UI.ImageBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grayscaleImageBox = new Emgu.CV.UI.ImageBox();
            this.smoothedGrayscaleImageBox = new Emgu.CV.UI.ImageBox();
            this.cannyImageBox = new Emgu.CV.UI.ImageBox();
            this.pbConnect = new System.Windows.Forms.Button();
            this.lbStatusCom = new System.Windows.Forms.Label();
            this.cbSelectCom = new System.Windows.Forms.ComboBox();
            this.tbReceiveData = new System.Windows.Forms.TextBox();
            this.tbSendData = new System.Windows.Forms.TextBox();
            this.btSendCom = new System.Windows.Forms.Button();
            this.ComPort = new System.IO.Ports.SerialPort(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.captureImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayscaleImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smoothedGrayscaleImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cannyImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // captureButton
            // 
            this.captureButton.Location = new System.Drawing.Point(358, 12);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(75, 23);
            this.captureButton.TabIndex = 0;
            this.captureButton.Text = "Start";
            this.captureButton.UseVisualStyleBackColor = true;
            this.captureButton.Click += new System.EventHandler(this.btStart_Click);
            // 
            // captureImageBox
            // 
            this.captureImageBox.Location = new System.Drawing.Point(12, 12);
            this.captureImageBox.Name = "captureImageBox";
            this.captureImageBox.Size = new System.Drawing.Size(226, 156);
            this.captureImageBox.TabIndex = 2;
            this.captureImageBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(506, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "TEN DE TAI......";
            // 
            // grayscaleImageBox
            // 
            this.grayscaleImageBox.Location = new System.Drawing.Point(12, 187);
            this.grayscaleImageBox.Name = "grayscaleImageBox";
            this.grayscaleImageBox.Size = new System.Drawing.Size(318, 230);
            this.grayscaleImageBox.TabIndex = 2;
            this.grayscaleImageBox.TabStop = false;
            // 
            // smoothedGrayscaleImageBox
            // 
            this.smoothedGrayscaleImageBox.Location = new System.Drawing.Point(244, 12);
            this.smoothedGrayscaleImageBox.Name = "smoothedGrayscaleImageBox";
            this.smoothedGrayscaleImageBox.Size = new System.Drawing.Size(60, 46);
            this.smoothedGrayscaleImageBox.TabIndex = 2;
            this.smoothedGrayscaleImageBox.TabStop = false;
            // 
            // cannyImageBox
            // 
            this.cannyImageBox.Location = new System.Drawing.Point(372, 57);
            this.cannyImageBox.Name = "cannyImageBox";
            this.cannyImageBox.Size = new System.Drawing.Size(247, 111);
            this.cannyImageBox.TabIndex = 2;
            this.cannyImageBox.TabStop = false;
            // 
            // pbConnect
            // 
            this.pbConnect.Location = new System.Drawing.Point(936, 208);
            this.pbConnect.Name = "pbConnect";
            this.pbConnect.Size = new System.Drawing.Size(92, 29);
            this.pbConnect.TabIndex = 5;
            this.pbConnect.Text = "Connected";
            this.pbConnect.UseVisualStyleBackColor = true;
            this.pbConnect.Click += new System.EventHandler(this.pbConnect_Click);
            // 
            // lbStatusCom
            // 
            this.lbStatusCom.AutoSize = true;
            this.lbStatusCom.Location = new System.Drawing.Point(790, 188);
            this.lbStatusCom.Name = "lbStatusCom";
            this.lbStatusCom.Size = new System.Drawing.Size(61, 13);
            this.lbStatusCom.TabIndex = 6;
            this.lbStatusCom.Text = "Disconnect";
            // 
            // cbSelectCom
            // 
            this.cbSelectCom.Location = new System.Drawing.Point(736, 216);
            this.cbSelectCom.Name = "cbSelectCom";
            this.cbSelectCom.Size = new System.Drawing.Size(121, 21);
            this.cbSelectCom.TabIndex = 7;
            // 
            // tbReceiveData
            // 
            this.tbReceiveData.Location = new System.Drawing.Point(493, 279);
            this.tbReceiveData.Multiline = true;
            this.tbReceiveData.Name = "tbReceiveData";
            this.tbReceiveData.Size = new System.Drawing.Size(218, 160);
            this.tbReceiveData.TabIndex = 8;
            // 
            // tbSendData
            // 
            this.tbSendData.Location = new System.Drawing.Point(793, 343);
            this.tbSendData.Multiline = true;
            this.tbSendData.Name = "tbSendData";
            this.tbSendData.Size = new System.Drawing.Size(224, 54);
            this.tbSendData.TabIndex = 9;
            // 
            // btSendCom
            // 
            this.btSendCom.Location = new System.Drawing.Point(1029, 355);
            this.btSendCom.Name = "btSendCom";
            this.btSendCom.Size = new System.Drawing.Size(75, 23);
            this.btSendCom.TabIndex = 10;
            this.btSendCom.Text = "Send";
            this.btSendCom.UseVisualStyleBackColor = true;
            this.btSendCom.Click += new System.EventHandler(this.btSendCom_Click);
            // 
            // ComPort
            // 
            this.ComPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.OnCom);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Receive Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(816, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Send Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 670);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btSendCom);
            this.Controls.Add(this.tbSendData);
            this.Controls.Add(this.tbReceiveData);
            this.Controls.Add(this.cbSelectCom);
            this.Controls.Add(this.lbStatusCom);
            this.Controls.Add(this.pbConnect);
            this.Controls.Add(this.cannyImageBox);
            this.Controls.Add(this.smoothedGrayscaleImageBox);
            this.Controls.Add(this.grayscaleImageBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.captureImageBox);
            this.Controls.Add(this.captureButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.captureImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grayscaleImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smoothedGrayscaleImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cannyImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button captureButton;
        private Emgu.CV.UI.ImageBox captureImageBox;
        private System.Windows.Forms.Label label1;
        private Emgu.CV.UI.ImageBox grayscaleImageBox;
        private Emgu.CV.UI.ImageBox smoothedGrayscaleImageBox;
        private Emgu.CV.UI.ImageBox cannyImageBox;
        private System.Windows.Forms.Button pbConnect;
        private System.Windows.Forms.Label lbStatusCom;
        private System.Windows.Forms.ComboBox cbSelectCom;
        private System.Windows.Forms.TextBox tbReceiveData;
        private System.Windows.Forms.TextBox tbSendData;
        private System.Windows.Forms.Button btSendCom;
        private System.IO.Ports.SerialPort ComPort;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

