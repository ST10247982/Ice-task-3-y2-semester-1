using System.Windows.Forms;

namespace Ice_task_3_y2_semester_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstItems = new ListBox();
            UDQuantity = new NumericUpDown();
            btnAdd = new Button();
            btnConfirm = new Button();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)UDQuantity).BeginInit();
            SuspendLayout();
            // 
            // lstItems
            // 
            lstItems.FormattingEnabled = true;
            lstItems.Items.AddRange(new object[] { Items.Tea, Items.Samoosa, Items.Muffin, Items.Coffee, Items.Springroll });
            lstItems.Location = new Point(219, 47);
            lstItems.Name = "lstItems";
            lstItems.Size = new Size(150, 104);
            lstItems.TabIndex = 0;
            // 
            // UDQuantity
            // 
            UDQuantity.Location = new Point(219, 218);
            UDQuantity.Name = "UDQuantity";
            UDQuantity.Size = new Size(150, 27);
            UDQuantity.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(326, 300);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add To Cart";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(286, 386);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(94, 29);
            btnConfirm.TabIndex = 3;
            btnConfirm.Text = "Confirm Order";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(551, 47);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(214, 164);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "Tea - R15.00 (250ML)\nSamoosa - R6.00 each\nMuffin - R12.00\nCoffee - R22.00 (250ML)\nSpringroll - R7.00 each\nChips - R10 (100g)\n\n\n";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(btnConfirm);
            Controls.Add(btnAdd);
            Controls.Add(UDQuantity);
            Controls.Add(lstItems);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)UDQuantity).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstItems;
        private NumericUpDown UDQuantity;
        private Button btnAdd;
        private Button btnConfirm;
        private RichTextBox richTextBox1;
    }
}
