namespace GroceryList
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox listBoxItems;
        private System.Windows.Forms.Button btnBack;

        private void InitializeComponent()
        {
            txtName = new TextBox();
            txtPrice = new TextBox();
            btnAddItem = new Button();
            btnSave = new Button();
            listBoxItems = new ListBox();
            label1 = new Label();
            btnBack = new Button();
            SuspendLayout();
 
            txtName.BackColor = SystemColors.ButtonFace;
            txtName.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            txtName.Location = new Point(41, 145);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Product Name";
            txtName.Size = new Size(217, 27);
            txtName.TabIndex = 0;

            txtPrice.BackColor = SystemColors.ButtonFace;
            txtPrice.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            txtPrice.Location = new Point(41, 178);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "Price";
            txtPrice.Size = new Size(80, 27);
            txtPrice.TabIndex = 1;
 
            btnAddItem.BackColor = SystemColors.ButtonFace;
            btnAddItem.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            btnAddItem.Location = new Point(360, 306);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(94, 40);
            btnAddItem.TabIndex = 2;
            btnAddItem.Text = "Add";
            btnAddItem.UseVisualStyleBackColor = false;
            btnAddItem.Click += btnAddItem_Click;
 
            btnSave.BackColor = SystemColors.ButtonFace;
            btnSave.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            btnSave.Location = new Point(494, 306);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 40);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;

            listBoxItems.BackColor = SystemColors.Info;
            listBoxItems.Location = new Point(292, 145);
            listBoxItems.Name = "listBoxItems";
            listBoxItems.Size = new Size(352, 144);
            listBoxItems.TabIndex = 3;

            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(173, 42);
            label1.Name = "label1";
            label1.Size = new Size(327, 62);
            label1.TabIndex = 5;
            label1.Text = "Add Groceries";

            btnBack.BackColor = SystemColors.ButtonFace;
            btnBack.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            btnBack.Location = new Point(588, 111);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(56, 28);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
   
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(680, 380);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(txtPrice);
            Controls.Add(btnAddItem);
            Controls.Add(listBoxItems);
            Controls.Add(btnSave);
            Controls.Add(btnBack);
            Name = "Form2";
            Text = "Add Groceries";
            ResumeLayout(false);
            PerformLayout();
        }
        private Label label1;
    }
}


