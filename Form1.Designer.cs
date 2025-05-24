using System.Runtime.CompilerServices;

namespace _1076_Radu_Bogdan_PROJ
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
            this.addWaiterBtn = new System.Windows.Forms.Button();
            this.lstWaiters = new System.Windows.Forms.ListView();
            this.WaiterID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Waiter_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addOrderBtn = new System.Windows.Forms.Button();
            this.addReservationBtn = new System.Windows.Forms.Button();
            this.deleteWaiterBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.serializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstOrders = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstReservations = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deleteOrderBtn = new System.Windows.Forms.Button();
            this.deleteReservationBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // addWaiterBtn
            // 
            this.addWaiterBtn.Location = new System.Drawing.Point(80, 56);
            this.addWaiterBtn.Name = "addWaiterBtn";
            this.addWaiterBtn.Size = new System.Drawing.Size(75, 23);
            this.addWaiterBtn.TabIndex = 0;
            this.addWaiterBtn.Text = "Add &Waiter";
            this.addWaiterBtn.UseVisualStyleBackColor = true;
            this.addWaiterBtn.Click += new System.EventHandler(this.addWaiterBtn_Click);
            // 
            // lstWaiters
            // 
            this.lstWaiters.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.WaiterID,
            this.Waiter_Name});
            this.lstWaiters.HideSelection = false;
            this.lstWaiters.Location = new System.Drawing.Point(45, 133);
            this.lstWaiters.Name = "lstWaiters";
            this.lstWaiters.Size = new System.Drawing.Size(150, 232);
            this.lstWaiters.TabIndex = 1;
            this.lstWaiters.TileSize = new System.Drawing.Size(100, 100);
            this.lstWaiters.UseCompatibleStateImageBehavior = false;
            this.lstWaiters.View = System.Windows.Forms.View.Details;
            this.lstWaiters.DoubleClick += new System.EventHandler(this.lstWaiters_DoubleClick);
            // 
            // WaiterID
            // 
            this.WaiterID.Text = "Waiter ID";
            // 
            // Waiter_Name
            // 
            this.Waiter_Name.Text = "Waiter Name";
            this.Waiter_Name.Width = 80;
            // 
            // addOrderBtn
            // 
            this.addOrderBtn.Location = new System.Drawing.Point(344, 56);
            this.addOrderBtn.Name = "addOrderBtn";
            this.addOrderBtn.Size = new System.Drawing.Size(75, 23);
            this.addOrderBtn.TabIndex = 2;
            this.addOrderBtn.Text = "Add &Order";
            this.addOrderBtn.UseVisualStyleBackColor = true;
            this.addOrderBtn.Click += new System.EventHandler(this.addOrderBtn_Click);
            // 
            // addReservationBtn
            // 
            this.addReservationBtn.Location = new System.Drawing.Point(598, 56);
            this.addReservationBtn.Name = "addReservationBtn";
            this.addReservationBtn.Size = new System.Drawing.Size(94, 23);
            this.addReservationBtn.TabIndex = 3;
            this.addReservationBtn.Text = "Add R&eservation";
            this.addReservationBtn.UseVisualStyleBackColor = true;
            this.addReservationBtn.Click += new System.EventHandler(this.addReservationBtn_Click);
            // 
            // deleteWaiterBtn
            // 
            this.deleteWaiterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteWaiterBtn.Location = new System.Drawing.Point(71, 392);
            this.deleteWaiterBtn.Name = "deleteWaiterBtn";
            this.deleteWaiterBtn.Size = new System.Drawing.Size(95, 23);
            this.deleteWaiterBtn.TabIndex = 4;
            this.deleteWaiterBtn.Text = "Delete Waiter";
            this.deleteWaiterBtn.UseVisualStyleBackColor = false;
            this.deleteWaiterBtn.Click += new System.EventHandler(this.deleteWaiterBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "alt+W";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "alt+O";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(631, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "alt+E";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.serializeToolStripMenuItem,
            this.deserializeToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // serializeToolStripMenuItem
            // 
            this.serializeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem});
            this.serializeToolStripMenuItem.Name = "serializeToolStripMenuItem";
            this.serializeToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.serializeToolStripMenuItem.Text = "&Serialize";
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.xMLToolStripMenuItem.Text = "XML";
            this.xMLToolStripMenuItem.Click += new System.EventHandler(this.xMLToolStripMenuItem_Click);
            // 
            // deserializeToolStripMenuItem
            // 
            this.deserializeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem1});
            this.deserializeToolStripMenuItem.Name = "deserializeToolStripMenuItem";
            this.deserializeToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.deserializeToolStripMenuItem.Text = "&Deserialize";
            // 
            // xMLToolStripMenuItem1
            // 
            this.xMLToolStripMenuItem1.Name = "xMLToolStripMenuItem1";
            this.xMLToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.xMLToolStripMenuItem1.Text = "XML";
            this.xMLToolStripMenuItem1.Click += new System.EventHandler(this.xMLToolStripMenuItem1_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtReportToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.exportToolStripMenuItem.Text = "E&xport";
            // 
            // txtReportToolStripMenuItem
            // 
            this.txtReportToolStripMenuItem.Name = "txtReportToolStripMenuItem";
            this.txtReportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.txtReportToolStripMenuItem.Text = "&Txt Report";
            this.txtReportToolStripMenuItem.Click += new System.EventHandler(this.txtReportToolStripMenuItem_Click);
            // 
            // lstOrders
            // 
            this.lstOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstOrders.HideSelection = false;
            this.lstOrders.Location = new System.Drawing.Point(308, 133);
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(150, 232);
            this.lstOrders.TabIndex = 9;
            this.lstOrders.TileSize = new System.Drawing.Size(100, 100);
            this.lstOrders.UseCompatibleStateImageBehavior = false;
            this.lstOrders.View = System.Windows.Forms.View.Details;
            this.lstOrders.DoubleClick += new System.EventHandler(this.lstOrders_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Order ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Order Total";
            this.columnHeader2.Width = 80;
            // 
            // lstReservations
            // 
            this.lstReservations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstReservations.HideSelection = false;
            this.lstReservations.Location = new System.Drawing.Point(559, 133);
            this.lstReservations.Name = "lstReservations";
            this.lstReservations.Size = new System.Drawing.Size(175, 232);
            this.lstReservations.TabIndex = 10;
            this.lstReservations.TileSize = new System.Drawing.Size(100, 100);
            this.lstReservations.UseCompatibleStateImageBehavior = false;
            this.lstReservations.View = System.Windows.Forms.View.Details;
            this.lstReservations.DoubleClick += new System.EventHandler(this.lstReservations_DoubleClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Reservation ID";
            this.columnHeader3.Width = 50;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "No. Persons";
            this.columnHeader4.Width = 50;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Order ID";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Waiter ID";
            // 
            // deleteOrderBtn
            // 
            this.deleteOrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteOrderBtn.Location = new System.Drawing.Point(336, 392);
            this.deleteOrderBtn.Name = "deleteOrderBtn";
            this.deleteOrderBtn.Size = new System.Drawing.Size(95, 23);
            this.deleteOrderBtn.TabIndex = 11;
            this.deleteOrderBtn.Text = "Delete Order";
            this.deleteOrderBtn.UseVisualStyleBackColor = false;
            this.deleteOrderBtn.Click += new System.EventHandler(this.deleteOrderBtn_Click);
            // 
            // deleteReservationBtn
            // 
            this.deleteReservationBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteReservationBtn.Location = new System.Drawing.Point(598, 392);
            this.deleteReservationBtn.Name = "deleteReservationBtn";
            this.deleteReservationBtn.Size = new System.Drawing.Size(113, 23);
            this.deleteReservationBtn.TabIndex = 12;
            this.deleteReservationBtn.Text = "Delete Reservation";
            this.deleteReservationBtn.UseVisualStyleBackColor = false;
            this.deleteReservationBtn.Click += new System.EventHandler(this.deleteReservationBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 659);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1264, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(33, 17);
            this.toolStripStatusLabel1.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuMain
            // 
            this.contextMenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.contextMenuMain.Name = "contextMenuMain";
            this.contextMenuMain.Size = new System.Drawing.Size(114, 26);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(834, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 232);
            this.panel1.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(831, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(389, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "A bar chart showing how many reservations each waiter has.";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printPreviewToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Preview";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.Location = new System.Drawing.Point(855, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(322, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "You can drag it around! (drag+drop functionality)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.ContextMenuStrip = this.contextMenuMain;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.deleteReservationBtn);
            this.Controls.Add(this.deleteOrderBtn);
            this.Controls.Add(this.lstReservations);
            this.Controls.Add(this.lstOrders);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteWaiterBtn);
            this.Controls.Add(this.addReservationBtn);
            this.Controls.Add(this.addOrderBtn);
            this.Controls.Add(this.lstWaiters);
            this.Controls.Add(this.addWaiterBtn);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name = "Form1";
            this.Text = "Restaurant Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addWaiterBtn;
        private System.Windows.Forms.ListView lstWaiters;
        private System.Windows.Forms.Button addOrderBtn;
        private System.Windows.Forms.Button addReservationBtn;
        private System.Windows.Forms.ColumnHeader WaiterID;
        private System.Windows.Forms.ColumnHeader Waiter_Name;
        private System.Windows.Forms.Button deleteWaiterBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem1;
        private System.Windows.Forms.ListView lstOrders;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lstReservations;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button deleteOrderBtn;
        private System.Windows.Forms.Button deleteReservationBtn;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem txtReportToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuMain;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.Label label5;
    }
}

