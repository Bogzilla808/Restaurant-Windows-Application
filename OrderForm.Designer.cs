namespace _1076_Radu_Bogdan_PROJ
{
    partial class OrderForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.orderIdInput = new System.Windows.Forms.TextBox();
            this.orderTotalInput = new System.Windows.Forms.TextBox();
            this.orderSubmitBtn = new System.Windows.Forms.Button();
            this.ep_order = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ep_order)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Order Total";
            // 
            // orderIdInput
            // 
            this.orderIdInput.Location = new System.Drawing.Point(118, 31);
            this.orderIdInput.Name = "orderIdInput";
            this.orderIdInput.Size = new System.Drawing.Size(126, 20);
            this.orderIdInput.TabIndex = 2;
            // 
            // orderTotalInput
            // 
            this.orderTotalInput.Location = new System.Drawing.Point(118, 86);
            this.orderTotalInput.Name = "orderTotalInput";
            this.orderTotalInput.Size = new System.Drawing.Size(126, 20);
            this.orderTotalInput.TabIndex = 3;
            // 
            // orderSubmitBtn
            // 
            this.orderSubmitBtn.Location = new System.Drawing.Point(30, 148);
            this.orderSubmitBtn.Name = "orderSubmitBtn";
            this.orderSubmitBtn.Size = new System.Drawing.Size(75, 23);
            this.orderSubmitBtn.TabIndex = 4;
            this.orderSubmitBtn.Text = "Submit";
            this.orderSubmitBtn.UseVisualStyleBackColor = true;
            this.orderSubmitBtn.Click += new System.EventHandler(this.orderSubmitBtn_Click);
            // 
            // ep_order
            // 
            this.ep_order.ContainerControl = this;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.orderSubmitBtn);
            this.Controls.Add(this.orderTotalInput);
            this.Controls.Add(this.orderIdInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ep_order)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox orderIdInput;
        private System.Windows.Forms.TextBox orderTotalInput;
        private System.Windows.Forms.Button orderSubmitBtn;
        private System.Windows.Forms.ErrorProvider ep_order;
    }
}