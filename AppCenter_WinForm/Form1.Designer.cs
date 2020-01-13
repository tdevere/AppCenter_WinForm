namespace AppCenter_WinForm
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
            this.btnSendEvent = new System.Windows.Forms.Button();
            this.txtSendEvent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSendEvent
            // 
            this.btnSendEvent.Location = new System.Drawing.Point(12, 53);
            this.btnSendEvent.Name = "btnSendEvent";
            this.btnSendEvent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSendEvent.Size = new System.Drawing.Size(192, 23);
            this.btnSendEvent.TabIndex = 0;
            this.btnSendEvent.Text = "Send Event";
            this.btnSendEvent.UseVisualStyleBackColor = true;
            this.btnSendEvent.Click += new System.EventHandler(this.btnSendEvent_Click);
            // 
            // txtSendEvent
            // 
            this.txtSendEvent.Location = new System.Drawing.Point(210, 54);
            this.txtSendEvent.Name = "txtSendEvent";
            this.txtSendEvent.Size = new System.Drawing.Size(626, 22);
            this.txtSendEvent.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 133);
            this.Controls.Add(this.txtSendEvent);
            this.Controls.Add(this.btnSendEvent);
            this.Name = "Form1";
            this.Text = "VS App Center Windows Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendEvent;
        private System.Windows.Forms.TextBox txtSendEvent;
    }
}

