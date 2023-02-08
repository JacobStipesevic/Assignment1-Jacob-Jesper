namespace Assignment1.Jacob.WindowsForm.V2
{
    partial class FormMenu
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
            System.Windows.Forms.TabControl tabControl;
            this.tabPageCustomer = new System.Windows.Forms.TabPage();
            this.buttonDeleteCustomer = new System.Windows.Forms.Button();
            this.buttonAddCustomer = new System.Windows.Forms.Button();
            this.textBoxLastNameCustomer = new System.Windows.Forms.TextBox();
            this.textBoxFirstNameCustomer = new System.Windows.Forms.TextBox();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelResponseCustomer = new System.Windows.Forms.Label();
            tabControl = new System.Windows.Forms.TabControl();
            tabControl.SuspendLayout();
            this.tabPageCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(this.tabPageCustomer);
            tabControl.Controls.Add(this.tabPage2);
            tabControl.Controls.Add(this.tabPage3);
            tabControl.Location = new System.Drawing.Point(7, 6);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new System.Drawing.Size(1066, 562);
            tabControl.TabIndex = 0;
            // 
            // tabPageCustomer
            // 
            this.tabPageCustomer.Controls.Add(this.labelResponseCustomer);
            this.tabPageCustomer.Controls.Add(this.buttonDeleteCustomer);
            this.tabPageCustomer.Controls.Add(this.buttonAddCustomer);
            this.tabPageCustomer.Controls.Add(this.textBoxLastNameCustomer);
            this.tabPageCustomer.Controls.Add(this.textBoxFirstNameCustomer);
            this.tabPageCustomer.Controls.Add(this.dataGridViewCustomer);
            this.tabPageCustomer.Location = new System.Drawing.Point(4, 24);
            this.tabPageCustomer.Name = "tabPageCustomer";
            this.tabPageCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCustomer.Size = new System.Drawing.Size(1058, 534);
            this.tabPageCustomer.TabIndex = 0;
            this.tabPageCustomer.Text = "Customer";
            this.tabPageCustomer.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteCustomer
            // 
            this.buttonDeleteCustomer.Location = new System.Drawing.Point(132, 175);
            this.buttonDeleteCustomer.Name = "buttonDeleteCustomer";
            this.buttonDeleteCustomer.Size = new System.Drawing.Size(104, 23);
            this.buttonDeleteCustomer.TabIndex = 4;
            this.buttonDeleteCustomer.Text = "Delete";
            this.buttonDeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.Location = new System.Drawing.Point(15, 175);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Size = new System.Drawing.Size(111, 23);
            this.buttonAddCustomer.TabIndex = 3;
            this.buttonAddCustomer.Text = "Add";
            this.buttonAddCustomer.UseVisualStyleBackColor = true;
            this.buttonAddCustomer.Click += new System.EventHandler(this.buttonAddCustomer_Click);
            // 
            // textBoxLastNameCustomer
            // 
            this.textBoxLastNameCustomer.Location = new System.Drawing.Point(15, 146);
            this.textBoxLastNameCustomer.Name = "textBoxLastNameCustomer";
            this.textBoxLastNameCustomer.PlaceholderText = "Last Name";
            this.textBoxLastNameCustomer.Size = new System.Drawing.Size(221, 23);
            this.textBoxLastNameCustomer.TabIndex = 2;
            // 
            // textBoxFirstNameCustomer
            // 
            this.textBoxFirstNameCustomer.Location = new System.Drawing.Point(15, 117);
            this.textBoxFirstNameCustomer.Name = "textBoxFirstNameCustomer";
            this.textBoxFirstNameCustomer.PlaceholderText = "First Name";
            this.textBoxFirstNameCustomer.Size = new System.Drawing.Size(221, 23);
            this.textBoxFirstNameCustomer.TabIndex = 1;
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(6, 258);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.RowTemplate.Height = 25;
            this.dataGridViewCustomer.Size = new System.Drawing.Size(1046, 270);
            this.dataGridViewCustomer.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1058, 534);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1058, 534);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // labelResponseCustomer
            // 
            this.labelResponseCustomer.AutoSize = true;
            this.labelResponseCustomer.Location = new System.Drawing.Point(15, 214);
            this.labelResponseCustomer.Name = "labelResponseCustomer";
            this.labelResponseCustomer.Size = new System.Drawing.Size(57, 15);
            this.labelResponseCustomer.TabIndex = 5;
            this.labelResponseCustomer.Text = "Response";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 571);
            this.Controls.Add(tabControl);
            this.Name = "FormMenu";
            this.Text = "Form1";
            tabControl.ResumeLayout(false);
            this.tabPageCustomer.ResumeLayout(false);
            this.tabPageCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage tabPageCustomer;
        private Button buttonDeleteCustomer;
        private Button buttonAddCustomer;
        private TextBox textBoxLastNameCustomer;
        private TextBox textBoxFirstNameCustomer;
        private DataGridView dataGridViewCustomer;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label labelResponseCustomer;
    }
}