namespace _1076_Radu_Bogdan_PROJ
{
    partial class WaiterForm
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
            this.waiterIdInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.waiterNameInput = new System.Windows.Forms.TextBox();
            this.submitWaiterBtn = new System.Windows.Forms.Button();
            this.ep_waiter = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ep_waiter)).BeginInit();
            this.SuspendLayout();
            // 
            // waiterIdInput
            // 
            this.waiterIdInput.Location = new System.Drawing.Point(98, 33);
            this.waiterIdInput.Name = "waiterIdInput";
            this.waiterIdInput.Size = new System.Drawing.Size(190, 20);
            this.waiterIdInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Waiter Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Waiter Name";
            // 
            // waiterNameInput
            // 
            this.waiterNameInput.Location = new System.Drawing.Point(98, 79);
            this.waiterNameInput.Name = "waiterNameInput";
            this.waiterNameInput.Size = new System.Drawing.Size(190, 20);
            this.waiterNameInput.TabIndex = 3;
            // 
            // submitWaiterBtn
            // 
            this.submitWaiterBtn.Location = new System.Drawing.Point(98, 144);
            this.submitWaiterBtn.Name = "submitWaiterBtn";
            this.submitWaiterBtn.Size = new System.Drawing.Size(75, 23);
            this.submitWaiterBtn.TabIndex = 4;
            this.submitWaiterBtn.Text = "Submit";
            this.submitWaiterBtn.UseVisualStyleBackColor = true;
            this.submitWaiterBtn.Click += new System.EventHandler(this.submitWaiterBtn_Click);
            // 
            // ep_waiter
            // 
            this.ep_waiter.ContainerControl = this;
            // 
            // WaiterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submitWaiterBtn);
            this.Controls.Add(this.waiterNameInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.waiterIdInput);
            this.Name = "WaiterForm";
            this.Text = "WaiterForm";
            this.Load += new System.EventHandler(this.WaiterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ep_waiter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox waiterIdInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox waiterNameInput;
        private System.Windows.Forms.Button submitWaiterBtn;
        private System.Windows.Forms.ErrorProvider ep_waiter;
    }
}