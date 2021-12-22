namespace FORMUI
{
    partial class Dashboard
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
            this.addProductText = new System.Windows.Forms.TextBox();
            this.addProductLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.productsInShoppingListBox = new System.Windows.Forms.CheckedListBox();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.clearChecked = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addProductText
            // 
            this.addProductText.Location = new System.Drawing.Point(87, 17);
            this.addProductText.Name = "addProductText";
            this.addProductText.Size = new System.Drawing.Size(191, 20);
            this.addProductText.TabIndex = 1;
            // 
            // addProductLabel
            // 
            this.addProductLabel.AutoSize = true;
            this.addProductLabel.Location = new System.Drawing.Point(10, 20);
            this.addProductLabel.Name = "addProductLabel";
            this.addProductLabel.Size = new System.Drawing.Size(65, 13);
            this.addProductLabel.TabIndex = 2;
            this.addProductLabel.Text = "Add product";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(284, 15);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // productsInShoppingListBox
            // 
            this.productsInShoppingListBox.FormattingEnabled = true;
            this.productsInShoppingListBox.Location = new System.Drawing.Point(13, 44);
            this.productsInShoppingListBox.Name = "productsInShoppingListBox";
            this.productsInShoppingListBox.Size = new System.Drawing.Size(346, 484);
            this.productsInShoppingListBox.TabIndex = 5;
            // 
            // clearAllButton
            // 
            this.clearAllButton.BackColor = System.Drawing.SystemColors.Control;
            this.clearAllButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearAllButton.ForeColor = System.Drawing.Color.Red;
            this.clearAllButton.Location = new System.Drawing.Point(13, 540);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(85, 23);
            this.clearAllButton.TabIndex = 6;
            this.clearAllButton.Text = "CLEAR LIST";
            this.clearAllButton.UseVisualStyleBackColor = false;
            this.clearAllButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearChecked
            // 
            this.clearChecked.Location = new System.Drawing.Point(274, 540);
            this.clearChecked.Name = "clearChecked";
            this.clearChecked.Size = new System.Drawing.Size(85, 23);
            this.clearChecked.TabIndex = 7;
            this.clearChecked.Text = "Clear Checked";
            this.clearChecked.UseVisualStyleBackColor = true;
            this.clearChecked.Click += new System.EventHandler(this.clearChecked_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 575);
            this.Controls.Add(this.clearChecked);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.productsInShoppingListBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.addProductLabel);
            this.Controls.Add(this.addProductText);
            this.Name = "Dashboard";
            this.Text = "SQL Shopping List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox addProductText;
        private System.Windows.Forms.Label addProductLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.CheckedListBox productsInShoppingListBox;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.Button clearChecked;
    }
}

