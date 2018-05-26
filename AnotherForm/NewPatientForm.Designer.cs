namespace AnotherForm
{
    partial class NewPatientForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.peselLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.peselTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.confirmAlertLabel = new System.Windows.Forms.Label();
            this.peselAlertLabel = new System.Windows.Forms.Label();
            this.firstNameAlertLabel = new System.Windows.Forms.Label();
            this.lastNameAlertLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.89883F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.10117F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.Controls.Add(this.peselLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.firstNameLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lastNameLabel, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.peselTextBox, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.firstNameTextBox, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lastNameTextBox, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.addButton, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.confirmAlertLabel, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.peselAlertLabel, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.firstNameAlertLabel, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.lastNameAlertLabel, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.titleLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.14894F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.85107F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(600, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // peselLabel
            // 
            this.peselLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.peselLabel.AutoSize = true;
            this.peselLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.peselLabel.Location = new System.Drawing.Point(191, 142);
            this.peselLabel.Name = "peselLabel";
            this.peselLabel.Size = new System.Drawing.Size(63, 20);
            this.peselLabel.TabIndex = 0;
            this.peselLabel.Text = "PESEL";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstNameLabel.Location = new System.Drawing.Point(214, 210);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(40, 20);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "Imię";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lastNameLabel.Location = new System.Drawing.Point(173, 276);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(81, 20);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Nazwisko";
            // 
            // peselTextBox
            // 
            this.peselTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.peselTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.peselTextBox.Location = new System.Drawing.Point(276, 139);
            this.peselTextBox.Name = "peselTextBox";
            this.peselTextBox.Size = new System.Drawing.Size(142, 26);
            this.peselTextBox.TabIndex = 3;
            this.peselTextBox.Validated += new System.EventHandler(this.peselTextBox_Validated);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstNameTextBox.Location = new System.Drawing.Point(276, 207);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(142, 26);
            this.firstNameTextBox.TabIndex = 4;
            this.firstNameTextBox.Validated += new System.EventHandler(this.firstNameTextBox_Validated);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lastNameTextBox.Location = new System.Drawing.Point(276, 273);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(142, 26);
            this.lastNameTextBox.TabIndex = 5;
            this.lastNameTextBox.Validated += new System.EventHandler(this.lastNameTextBox_Validated);
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.titleLabel, 6);
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.Location = new System.Drawing.Point(137, 35);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(325, 29);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "Formularz nowego pacjenta";
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.addButton, 4);
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addButton.Location = new System.Drawing.Point(145, 337);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(314, 45);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Zatwierdź dane nowego pacjenta";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // confirmAlertLabel
            // 
            this.confirmAlertLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmAlertLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.confirmAlertLabel, 4);
            this.confirmAlertLabel.ForeColor = System.Drawing.Color.Red;
            this.confirmAlertLabel.Location = new System.Drawing.Point(279, 406);
            this.confirmAlertLabel.Name = "confirmAlertLabel";
            this.confirmAlertLabel.Size = new System.Drawing.Size(46, 17);
            this.confirmAlertLabel.TabIndex = 8;
            this.confirmAlertLabel.Text = "label1";
            // 
            // peselAlertLabel
            // 
            this.peselAlertLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.peselAlertLabel.AutoSize = true;
            this.peselAlertLabel.ForeColor = System.Drawing.Color.Red;
            this.peselAlertLabel.Location = new System.Drawing.Point(436, 143);
            this.peselAlertLabel.Name = "peselAlertLabel";
            this.peselAlertLabel.Size = new System.Drawing.Size(46, 17);
            this.peselAlertLabel.TabIndex = 9;
            this.peselAlertLabel.Text = "label1";
            // 
            // firstNameAlertLabel
            // 
            this.firstNameAlertLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.firstNameAlertLabel.AutoSize = true;
            this.firstNameAlertLabel.ForeColor = System.Drawing.Color.Red;
            this.firstNameAlertLabel.Location = new System.Drawing.Point(436, 212);
            this.firstNameAlertLabel.Name = "firstNameAlertLabel";
            this.firstNameAlertLabel.Size = new System.Drawing.Size(46, 17);
            this.firstNameAlertLabel.TabIndex = 10;
            this.firstNameAlertLabel.Text = "label1";
            // 
            // lastNameAlertLabel
            // 
            this.lastNameAlertLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lastNameAlertLabel.AutoSize = true;
            this.lastNameAlertLabel.ForeColor = System.Drawing.Color.Red;
            this.lastNameAlertLabel.Location = new System.Drawing.Point(436, 278);
            this.lastNameAlertLabel.Name = "lastNameAlertLabel";
            this.lastNameAlertLabel.Size = new System.Drawing.Size(46, 17);
            this.lastNameAlertLabel.TabIndex = 11;
            this.lastNameAlertLabel.Text = "label2";
            // 
            // NewPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 474);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NewPatientForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "NewPatient";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label peselLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox peselTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label confirmAlertLabel;
        private System.Windows.Forms.Label peselAlertLabel;
        private System.Windows.Forms.Label firstNameAlertLabel;
        private System.Windows.Forms.Label lastNameAlertLabel;
    }
}