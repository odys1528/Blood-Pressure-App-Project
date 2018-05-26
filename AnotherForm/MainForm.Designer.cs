namespace AnotherForm
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.patientsGridView = new System.Windows.Forms.DataGridView();
            this.measuresGridView = new System.Windows.Forms.DataGridView();
            this.tipLabel = new System.Windows.Forms.Label();
            this.deletePatientButton = new System.Windows.Forms.Button();
            this.newPatientButton = new System.Windows.Forms.Button();
            this.deleteMeasureButton = new System.Windows.Forms.Button();
            this.newMeasureButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.plot1Button = new System.Windows.Forms.Button();
            this.plot2Button = new System.Windows.Forms.Button();
            this.plot3Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.measuresGridView)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.188976F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.81102F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 213F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 275F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.titleLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.patientsGridView, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.measuresGridView, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tipLabel, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.deletePatientButton, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.newPatientButton, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.deleteMeasureButton, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.newMeasureButton, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.printButton, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.15423F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.84577F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 192F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1227, 753);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 6);
            this.label2.Location = new System.Drawing.Point(3, 558);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1221, 2);
            this.label2.TabIndex = 15;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.titleLabel, 5);
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.Location = new System.Drawing.Point(223, 55);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(711, 29);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "System rejestracji i wizualizacji pomiarów ciśnienia tętniczego";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // patientsGridView
            // 
            this.patientsGridView.AllowUserToAddRows = false;
            this.patientsGridView.AllowUserToDeleteRows = false;
            this.patientsGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.patientsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.patientsGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.patientsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientsGridView.Location = new System.Drawing.Point(63, 153);
            this.patientsGridView.Name = "patientsGridView";
            this.tableLayoutPanel1.SetRowSpan(this.patientsGridView, 2);
            this.patientsGridView.RowTemplate.Height = 24;
            this.patientsGridView.Size = new System.Drawing.Size(556, 170);
            this.patientsGridView.TabIndex = 1;
            this.patientsGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientsGridView_CellValueChanged);
            this.patientsGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.patientsGridView_DataBindingComplete);
            this.patientsGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientsGridView_RowEnter);
            // 
            // measuresGridView
            // 
            this.measuresGridView.AllowUserToAddRows = false;
            this.measuresGridView.AllowUserToDeleteRows = false;
            this.measuresGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.measuresGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.measuresGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.measuresGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.measuresGridView.Location = new System.Drawing.Point(63, 372);
            this.measuresGridView.Name = "measuresGridView";
            this.measuresGridView.RowTemplate.Height = 24;
            this.measuresGridView.Size = new System.Drawing.Size(556, 154);
            this.measuresGridView.TabIndex = 2;
            this.measuresGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.measuresGridView_CellValueChanged);
            this.measuresGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.measuresGridView_DataBindingComplete);
            // 
            // tipLabel
            // 
            this.tipLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tipLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.tipLabel, 2);
            this.tipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tipLabel.Location = new System.Drawing.Point(706, 160);
            this.tipLabel.Name = "tipLabel";
            this.tipLabel.Size = new System.Drawing.Size(413, 20);
            this.tipLabel.TabIndex = 8;
            this.tipLabel.Text = "Wybierz pajenta, a jego pomiary wyświetlą się poniżej.";
            this.tipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // deletePatientButton
            // 
            this.deletePatientButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deletePatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deletePatientButton.Location = new System.Drawing.Point(944, 245);
            this.deletePatientButton.Name = "deletePatientButton";
            this.deletePatientButton.Size = new System.Drawing.Size(151, 49);
            this.deletePatientButton.TabIndex = 10;
            this.deletePatientButton.Text = "Usuń dane wybranego pacjenta";
            this.deletePatientButton.UseVisualStyleBackColor = true;
            this.deletePatientButton.Click += new System.EventHandler(this.deletePatientButton_Click);
            // 
            // newPatientButton
            // 
            this.newPatientButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newPatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newPatientButton.Location = new System.Drawing.Point(706, 242);
            this.newPatientButton.Name = "newPatientButton";
            this.newPatientButton.Size = new System.Drawing.Size(138, 54);
            this.newPatientButton.TabIndex = 9;
            this.newPatientButton.Text = "Dodaj dane nowego pacjenta";
            this.newPatientButton.UseVisualStyleBackColor = true;
            this.newPatientButton.Click += new System.EventHandler(this.newPatientButton_Click);
            // 
            // deleteMeasureButton
            // 
            this.deleteMeasureButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteMeasureButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteMeasureButton.Location = new System.Drawing.Point(944, 419);
            this.deleteMeasureButton.Name = "deleteMeasureButton";
            this.deleteMeasureButton.Size = new System.Drawing.Size(150, 60);
            this.deleteMeasureButton.TabIndex = 12;
            this.deleteMeasureButton.Text = "Usuń dane wybranego pomiaru";
            this.deleteMeasureButton.UseVisualStyleBackColor = true;
            this.deleteMeasureButton.Click += new System.EventHandler(this.deleteMeasureButton_Click);
            // 
            // newMeasureButton
            // 
            this.newMeasureButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newMeasureButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newMeasureButton.Location = new System.Drawing.Point(705, 418);
            this.newMeasureButton.Name = "newMeasureButton";
            this.newMeasureButton.Size = new System.Drawing.Size(141, 61);
            this.newMeasureButton.TabIndex = 11;
            this.newMeasureButton.Text = "Dodaj dane nowego pomiaru";
            this.newMeasureButton.UseVisualStyleBackColor = true;
            this.newMeasureButton.Click += new System.EventHandler(this.newMeasureButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 6);
            this.label1.Location = new System.Drawing.Point(3, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1221, 2);
            this.label1.TabIndex = 14;
            // 
            // printButton
            // 
            this.printButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.printButton, 2);
            this.printButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.printButton.Location = new System.Drawing.Point(805, 623);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(216, 67);
            this.printButton.TabIndex = 13;
            this.printButton.Text = "Wydrukuj  pomiary";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.plot1Button, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.plot2Button, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.plot3Button, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(63, 598);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(556, 116);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // plot1Button
            // 
            this.plot1Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plot1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.plot1Button.Location = new System.Drawing.Point(32, 17);
            this.plot1Button.Name = "plot1Button";
            this.plot1Button.Size = new System.Drawing.Size(121, 82);
            this.plot1Button.TabIndex = 5;
            this.plot1Button.Text = "Wykres pasmowy";
            this.plot1Button.UseVisualStyleBackColor = true;
            this.plot1Button.Click += new System.EventHandler(this.plot1Button_Click);
            // 
            // plot2Button
            // 
            this.plot2Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plot2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.plot2Button.Location = new System.Drawing.Point(219, 17);
            this.plot2Button.Name = "plot2Button";
            this.plot2Button.Size = new System.Drawing.Size(117, 82);
            this.plot2Button.TabIndex = 6;
            this.plot2Button.Text = "Wykres słupkowy";
            this.plot2Button.UseVisualStyleBackColor = true;
            this.plot2Button.Click += new System.EventHandler(this.plot2Button_Click);
            // 
            // plot3Button
            // 
            this.plot3Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plot3Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.plot3Button.Location = new System.Drawing.Point(400, 17);
            this.plot3Button.Name = "plot3Button";
            this.plot3Button.Size = new System.Drawing.Size(126, 81);
            this.plot3Button.TabIndex = 7;
            this.plot3Button.Text = "Wykres korelacyjny";
            this.plot3Button.UseVisualStyleBackColor = true;
            this.plot3Button.Click += new System.EventHandler(this.plot3Button_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(649, 560);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2, 193);
            this.label3.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 753);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Blood Pressure: registration & visualization";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.measuresGridView)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.DataGridView patientsGridView;
        private System.Windows.Forms.DataGridView measuresGridView;
        private System.Windows.Forms.Button plot1Button;
        private System.Windows.Forms.Button plot2Button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button plot3Button;
        private System.Windows.Forms.Label tipLabel;
        private System.Windows.Forms.Button newPatientButton;
        private System.Windows.Forms.Button deletePatientButton;
        private System.Windows.Forms.Button newMeasureButton;
        private System.Windows.Forms.Button deleteMeasureButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

