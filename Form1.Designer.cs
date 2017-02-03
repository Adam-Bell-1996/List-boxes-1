namespace List_boxes_1
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
            this.listBoxshopping = new System.Windows.Forms.ListBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.txt_New_Item = new System.Windows.Forms.TextBox();
            this.count_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxshopping
            // 
            this.listBoxshopping.FormattingEnabled = true;
            this.listBoxshopping.Location = new System.Drawing.Point(243, 38);
            this.listBoxshopping.Name = "listBoxshopping";
            this.listBoxshopping.Size = new System.Drawing.Size(89, 212);
            this.listBoxshopping.TabIndex = 0;
            this.listBoxshopping.SelectedIndexChanged += new System.EventHandler(this.listBoxshopping_SelectedIndexChanged);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(61, 152);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 1;
            this.add_btn.Text = "Add Item ";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // txt_New_Item
            // 
            this.txt_New_Item.Location = new System.Drawing.Point(46, 126);
            this.txt_New_Item.Name = "txt_New_Item";
            this.txt_New_Item.Size = new System.Drawing.Size(100, 20);
            this.txt_New_Item.TabIndex = 2;
            // 
            // count_btn
            // 
            this.count_btn.Location = new System.Drawing.Point(61, 181);
            this.count_btn.Name = "count_btn";
            this.count_btn.Size = new System.Drawing.Size(75, 23);
            this.count_btn.TabIndex = 3;
            this.count_btn.Text = "count";
            this.count_btn.UseVisualStyleBackColor = true;
            this.count_btn.Click += new System.EventHandler(this.count_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 262);
            this.Controls.Add(this.count_btn);
            this.Controls.Add(this.txt_New_Item);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.listBoxshopping);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxshopping;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.TextBox txt_New_Item;
        private System.Windows.Forms.Button count_btn;
    }
}

