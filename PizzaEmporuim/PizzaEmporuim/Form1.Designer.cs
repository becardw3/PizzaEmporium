namespace PizzaEmporuim
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
            this.btnPizza = new System.Windows.Forms.Button();
            this.btnDrinks = new System.Windows.Forms.Button();
            this.btnSalads = new System.Windows.Forms.Button();
            this.btnSpecials = new System.Windows.Forms.Button();
            this.btnCoolStuff = new System.Windows.Forms.Button();
            this.lstOrderItems = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBreadsticks = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnSubmitOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPizza
            // 
            this.btnPizza.Location = new System.Drawing.Point(165, 37);
            this.btnPizza.Name = "btnPizza";
            this.btnPizza.Size = new System.Drawing.Size(258, 146);
            this.btnPizza.TabIndex = 0;
            this.btnPizza.Text = "Pizza";
            this.btnPizza.UseVisualStyleBackColor = true;
            this.btnPizza.Click += new System.EventHandler(this.btnPizza_Click);
            // 
            // btnDrinks
            // 
            this.btnDrinks.Location = new System.Drawing.Point(429, 37);
            this.btnDrinks.Name = "btnDrinks";
            this.btnDrinks.Size = new System.Drawing.Size(258, 146);
            this.btnDrinks.TabIndex = 1;
            this.btnDrinks.Text = "Drinks";
            this.btnDrinks.UseVisualStyleBackColor = true;
            this.btnDrinks.Click += new System.EventHandler(this.btnDrinks_Click);
            // 
            // btnSalads
            // 
            this.btnSalads.Location = new System.Drawing.Point(692, 37);
            this.btnSalads.Name = "btnSalads";
            this.btnSalads.Size = new System.Drawing.Size(258, 146);
            this.btnSalads.TabIndex = 2;
            this.btnSalads.Text = "Salads";
            this.btnSalads.UseVisualStyleBackColor = true;
            this.btnSalads.Click += new System.EventHandler(this.btnSalads_Click);
            // 
            // btnSpecials
            // 
            this.btnSpecials.Location = new System.Drawing.Point(1219, 37);
            this.btnSpecials.Name = "btnSpecials";
            this.btnSpecials.Size = new System.Drawing.Size(258, 146);
            this.btnSpecials.TabIndex = 3;
            this.btnSpecials.Text = "Specials";
            this.btnSpecials.UseVisualStyleBackColor = true;
            this.btnSpecials.Click += new System.EventHandler(this.btnSpecials_Click);
            // 
            // btnCoolStuff
            // 
            this.btnCoolStuff.Location = new System.Drawing.Point(1483, 37);
            this.btnCoolStuff.Name = "btnCoolStuff";
            this.btnCoolStuff.Size = new System.Drawing.Size(258, 146);
            this.btnCoolStuff.TabIndex = 4;
            this.btnCoolStuff.Text = "Cool Stuff";
            this.btnCoolStuff.UseVisualStyleBackColor = true;
            this.btnCoolStuff.Click += new System.EventHandler(this.btnCoolStuff_Click);
            // 
            // lstOrderItems
            // 
            this.lstOrderItems.FormattingEnabled = true;
            this.lstOrderItems.ItemHeight = 31;
            this.lstOrderItems.Location = new System.Drawing.Point(956, 228);
            this.lstOrderItems.Name = "lstOrderItems";
            this.lstOrderItems.Size = new System.Drawing.Size(874, 810);
            this.lstOrderItems.TabIndex = 6;
            this.lstOrderItems.SelectedIndexChanged += new System.EventHandler(this.lstOrderItems_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(44, 250);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(899, 815);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // btnBreadsticks
            // 
            this.btnBreadsticks.Location = new System.Drawing.Point(956, 37);
            this.btnBreadsticks.Name = "btnBreadsticks";
            this.btnBreadsticks.Size = new System.Drawing.Size(258, 146);
            this.btnBreadsticks.TabIndex = 8;
            this.btnBreadsticks.Text = "Breadsticks";
            this.btnBreadsticks.UseVisualStyleBackColor = true;
            this.btnBreadsticks.Click += new System.EventHandler(this.btnBreadsticks_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRemoveItem.Location = new System.Drawing.Point(1285, 1120);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(263, 49);
            this.btnRemoveItem.TabIndex = 10;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.Location = new System.Drawing.Point(1591, 1120);
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(263, 49);
            this.btnSubmitOrder.TabIndex = 11;
            this.btnSubmitOrder.Text = "Submit Order";
            this.btnSubmitOrder.UseVisualStyleBackColor = true;
            this.btnSubmitOrder.Click += new System.EventHandler(this.btnSubmitOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1894, 1193);
            this.Controls.Add(this.btnSubmitOrder);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnBreadsticks);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lstOrderItems);
            this.Controls.Add(this.btnCoolStuff);
            this.Controls.Add(this.btnSpecials);
            this.Controls.Add(this.btnSalads);
            this.Controls.Add(this.btnDrinks);
            this.Controls.Add(this.btnPizza);
            this.Name = "Form1";
            this.Text = "Pizza Emporium";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPizza;
        private System.Windows.Forms.Button btnDrinks;
        private System.Windows.Forms.Button btnSalads;
        private System.Windows.Forms.Button btnSpecials;
        private System.Windows.Forms.Button btnCoolStuff;
        private System.Windows.Forms.ListBox lstOrderItems;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnBreadsticks;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnSubmitOrder;
    }
}

