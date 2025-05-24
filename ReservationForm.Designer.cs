namespace _1076_Radu_Bogdan_PROJ
{
    partial class ReservationForm
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
            this.resIdInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.resPersonInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resOrderInput = new System.Windows.Forms.TextBox();
            this.resWaiterInput = new System.Windows.Forms.TextBox();
            this.resAddBtn = new System.Windows.Forms.Button();
            this.ep_res = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ep_res)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservation ID";
            // 
            // resIdInput
            // 
            this.resIdInput.Location = new System.Drawing.Point(113, 32);
            this.resIdInput.Name = "resIdInput";
            this.resIdInput.Size = new System.Drawing.Size(100, 20);
            this.resIdInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "No. Persons";
            // 
            // resPersonInput
            // 
            this.resPersonInput.Location = new System.Drawing.Point(113, 89);
            this.resPersonInput.Name = "resPersonInput";
            this.resPersonInput.Size = new System.Drawing.Size(100, 20);
            this.resPersonInput.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Order ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Waiter ID";
            // 
            // resOrderInput
            // 
            this.resOrderInput.Location = new System.Drawing.Point(113, 144);
            this.resOrderInput.Name = "resOrderInput";
            this.resOrderInput.Size = new System.Drawing.Size(100, 20);
            this.resOrderInput.TabIndex = 6;
            // 
            // resWaiterInput
            // 
            this.resWaiterInput.Location = new System.Drawing.Point(113, 194);
            this.resWaiterInput.Name = "resWaiterInput";
            this.resWaiterInput.Size = new System.Drawing.Size(100, 20);
            this.resWaiterInput.TabIndex = 7;
            // 
            // resAddBtn
            // 
            this.resAddBtn.Location = new System.Drawing.Point(82, 263);
            this.resAddBtn.Name = "resAddBtn";
            this.resAddBtn.Size = new System.Drawing.Size(75, 23);
            this.resAddBtn.TabIndex = 8;
            this.resAddBtn.Text = "Add";
            this.resAddBtn.UseVisualStyleBackColor = true;
            this.resAddBtn.Click += new System.EventHandler(this.resAddBtn_Click);
            // 
            // ep_res
            // 
            this.ep_res.ContainerControl = this;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resAddBtn);
            this.Controls.Add(this.resWaiterInput);
            this.Controls.Add(this.resOrderInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resPersonInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resIdInput);
            this.Controls.Add(this.label1);
            this.Name = "ReservationForm";
            this.Text = "ReservationForm";
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ep_res)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox resIdInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resPersonInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox resOrderInput;
        private System.Windows.Forms.TextBox resWaiterInput;
        private System.Windows.Forms.Button resAddBtn;
        private System.Windows.Forms.ErrorProvider ep_res;
    }
}