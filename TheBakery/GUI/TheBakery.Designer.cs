using System.Drawing;

namespace TheBakery
{
    partial class TheBakery
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayPanel = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordersToolStripMenuItem,
            this.profileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1502, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newOrderToolStripMenuItem,
            this.myOrdersToolStripMenuItem,
            this.orderHistoryToolStripMenuItem});
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.ordersToolStripMenuItem.Text = "Orders";
            // 
            // newOrderToolStripMenuItem
            // 
            this.newOrderToolStripMenuItem.Name = "newOrderToolStripMenuItem";
            this.newOrderToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.newOrderToolStripMenuItem.Text = "New Order";
            // 
            // myOrdersToolStripMenuItem
            // 
            this.myOrdersToolStripMenuItem.Name = "myOrdersToolStripMenuItem";
            this.myOrdersToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.myOrdersToolStripMenuItem.Text = "My Orders";
            // 
            // orderHistoryToolStripMenuItem
            // 
            this.orderHistoryToolStripMenuItem.Name = "orderHistoryToolStripMenuItem";
            this.orderHistoryToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.orderHistoryToolStripMenuItem.Text = "Order history";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // displayPanel
            // 
            this.displayPanel.Location = new System.Drawing.Point(282, 28);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Size = new System.Drawing.Size(1220, 756);
            this.displayPanel.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Cake",
            "Mushrooms",
            "Fish"});
            this.listBox1.Location = new System.Drawing.Point(0, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(276, 756);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // TheBakery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1502, 796);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.displayPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TheBakery";
            this.Text = "TheBakery";
            this.FormClosed += TheBakery_FormClosed;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderHistoryToolStripMenuItem;
        private System.Windows.Forms.Panel displayPanel;
        private System.Windows.Forms.ListBox listBox1;
    }
}

