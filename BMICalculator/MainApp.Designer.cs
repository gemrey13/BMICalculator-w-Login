namespace BMICalculator
{
    partial class MainApp
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.nameLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 214);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(543, 150);
            this.dataGridView.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(22, 61);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(86, 25);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name : ";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.heightLabel.Location = new System.Drawing.Point(22, 145);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(86, 25);
            this.heightLabel.TabIndex = 2;
            this.heightLabel.Text = "Height :";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.weightLabel.Location = new System.Drawing.Point(307, 61);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(91, 25);
            this.weightLabel.TabIndex = 3;
            this.weightLabel.Text = "Weight :";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(27, 89);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(231, 24);
            this.nameTextBox.TabIndex = 4;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.heightTextBox.Location = new System.Drawing.Point(27, 173);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(231, 24);
            this.heightTextBox.TabIndex = 5;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.weightTextBox.Location = new System.Drawing.Point(312, 89);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(231, 24);
            this.weightTextBox.TabIndex = 6;
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.submitButton.Location = new System.Drawing.Point(312, 162);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(231, 35);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(468, 21);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 8;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.75F);
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "BMI Calculator";
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 392);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.dataGridView);
            this.Name = "MainApp";
            this.Text = "BMI Application";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label label1;
    }
}