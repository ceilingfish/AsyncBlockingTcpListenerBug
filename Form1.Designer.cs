namespace AsyncBlockingTcpListenerBug
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
            this.startListener = new System.Windows.Forms.Button();
            this.sendMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startListener
            // 
            this.startListener.Location = new System.Drawing.Point(12, 17);
            this.startListener.Name = "startListener";
            this.startListener.Size = new System.Drawing.Size(95, 23);
            this.startListener.TabIndex = 0;
            this.startListener.Text = "Start Listener";
            this.startListener.UseVisualStyleBackColor = true;
            this.startListener.Click += new System.EventHandler(this.startListener_Click);
            // 
            // sendMessage
            // 
            this.sendMessage.Enabled = false;
            this.sendMessage.Location = new System.Drawing.Point(113, 17);
            this.sendMessage.Name = "sendMessage";
            this.sendMessage.Size = new System.Drawing.Size(105, 23);
            this.sendMessage.TabIndex = 1;
            this.sendMessage.Text = "Send Message";
            this.sendMessage.UseVisualStyleBackColor = true;
            this.sendMessage.Click += new System.EventHandler(this.sendMessage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 57);
            this.Controls.Add(this.sendMessage);
            this.Controls.Add(this.startListener);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startListener;
        private System.Windows.Forms.Button sendMessage;
    }
}

