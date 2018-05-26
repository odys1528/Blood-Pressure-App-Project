namespace AnotherForm
{
    partial class CorelationChartForm
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.ConstantLine constantLine1 = new DevExpress.XtraCharts.ConstantLine();
            DevExpress.XtraCharts.ConstantLine constantLine2 = new DevExpress.XtraCharts.ConstantLine();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesView pointSeriesView1 = new DevExpress.XtraCharts.PointSeriesView();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CorelationChartForm));
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.bloodPressureTableAdapter = new AnotherForm.BloodPressureDBDataSetTableAdapters.BloodPressureTableAdapter();
            this.bloodPressureBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bloodPressureDBDataSet1 = new AnotherForm.BloodPressureDBDataSet();
            this.bloodPressureDBDataSet = new AnotherForm.BloodPressureDBDataSet();
            this.bloodPressureDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bloodPressureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bloodPressureTableAdapter1 = new AnotherForm.BloodPressureDBDataSetTableAdapters.BloodPressureTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.hourListBox = new System.Windows.Forms.ListBox();
            this.printButton = new System.Windows.Forms.Button();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodPressureBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodPressureDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodPressureDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodPressureDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodPressureBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.DataAdapter = this.bloodPressureTableAdapter;
            this.chartControl1.DataSource = this.bloodPressureBindingSource1;
            constantLine1.AxisValueSerializable = "140";
            constantLine1.Name = "Constant Line 1";
            constantLine1.Title.Visible = false;
            xyDiagram1.AxisX.ConstantLines.AddRange(new DevExpress.XtraCharts.ConstantLine[] {
            constantLine1});
            xyDiagram1.AxisX.GridLines.Visible = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisX.VisualRange.Auto = false;
            xyDiagram1.AxisX.VisualRange.MaxValueSerializable = "9";
            xyDiagram1.AxisX.VisualRange.MinValueSerializable = "0";
            constantLine2.AxisValueSerializable = "90";
            constantLine2.Name = "Constant Line 2";
            constantLine2.Title.Visible = false;
            xyDiagram1.AxisY.ConstantLines.AddRange(new DevExpress.XtraCharts.ConstantLine[] {
            constantLine2});
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl1.Location = new System.Drawing.Point(396, 12);
            this.chartControl1.Name = "chartControl1";
            series1.ArgumentDataMember = "systolic";
            series1.LegendName = "Default Legend";
            series1.Name = "Series 1";
            series1.ValueDataMembersSerializable = "diastolic";
            series1.View = pointSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.SeriesTemplate.ArgumentDataMember = "systolic";
            this.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "diastolic";
            this.chartControl1.Size = new System.Drawing.Size(699, 468);
            this.chartControl1.TabIndex = 0;
            // 
            // bloodPressureTableAdapter
            // 
            this.bloodPressureTableAdapter.ClearBeforeFill = true;
            // 
            // bloodPressureBindingSource1
            // 
            this.bloodPressureBindingSource1.DataMember = "BloodPressure";
            this.bloodPressureBindingSource1.DataSource = this.bloodPressureDBDataSet1;
            this.bloodPressureBindingSource1.Sort = "";
            // 
            // bloodPressureDBDataSet1
            // 
            this.bloodPressureDBDataSet1.DataSetName = "BloodPressureDBDataSet";
            this.bloodPressureDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bloodPressureDBDataSet
            // 
            this.bloodPressureDBDataSet.DataSetName = "BloodPressureDBDataSet";
            this.bloodPressureDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bloodPressureDBDataSetBindingSource
            // 
            this.bloodPressureDBDataSetBindingSource.DataSource = this.bloodPressureDBDataSet;
            this.bloodPressureDBDataSetBindingSource.Position = 0;
            // 
            // bloodPressureBindingSource
            // 
            this.bloodPressureBindingSource.DataMember = "BloodPressure";
            this.bloodPressureBindingSource.DataSource = this.bloodPressureDBDataSetBindingSource;
            // 
            // bloodPressureTableAdapter1
            // 
            this.bloodPressureTableAdapter1.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.7347F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.2653F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 211F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.Controls.Add(this.titleLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.fromDateTimePicker, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.toLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.fromLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.toDateTimePicker, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.hourListBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.printButton, 1, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.40351F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.59649F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(378, 468);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.titleLabel, 3);
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.Location = new System.Drawing.Point(89, 18);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(176, 29);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Dane pacjenta";
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fromDateTimePicker.Location = new System.Drawing.Point(112, 129);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.fromDateTimePicker.TabIndex = 3;
            this.fromDateTimePicker.ValueChanged += new System.EventHandler(this.fromDateTimePicker_ValueChanged);
            this.fromDateTimePicker.Validated += new System.EventHandler(this.fromDateTimePicker_Validated);
            // 
            // toLabel
            // 
            this.toLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(65, 214);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(24, 17);
            this.toLabel.TabIndex = 2;
            this.toLabel.Text = "do";
            // 
            // fromLabel
            // 
            this.fromLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(65, 132);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(24, 17);
            this.fromLabel.TabIndex = 1;
            this.fromLabel.Text = "od";
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.toDateTimePicker.Location = new System.Drawing.Point(112, 211);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.toDateTimePicker.TabIndex = 4;
            this.toDateTimePicker.ValueChanged += new System.EventHandler(this.toDateTimePicker_ValueChanged);
            this.toDateTimePicker.Validated += new System.EventHandler(this.toDateTimePicker_Validated);
            // 
            // hourListBox
            // 
            this.hourListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.hourListBox, 3);
            this.hourListBox.FormattingEnabled = true;
            this.hourListBox.ItemHeight = 16;
            this.hourListBox.Location = new System.Drawing.Point(85, 295);
            this.hourListBox.Name = "hourListBox";
            this.hourListBox.Size = new System.Drawing.Size(183, 52);
            this.hourListBox.TabIndex = 5;
            this.hourListBox.SelectedIndexChanged += new System.EventHandler(this.hourListBox_SelectedIndexChanged);
            // 
            // printButton
            // 
            this.printButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.printButton, 3);
            this.printButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.printButton.Location = new System.Drawing.Point(90, 393);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(173, 39);
            this.printButton.TabIndex = 6;
            this.printButton.Text = "Wydrukuj wykres";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.MaxItemId = 26;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1107, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 492);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1107, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 492);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1107, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 492);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // CorelationChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 492);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CorelationChartForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "CorelationPointChartForm";
            this.Load += new System.EventHandler(this.CorelationChartForm_Load);
            this.Shown += new System.EventHandler(this.CorelationChartForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodPressureBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodPressureDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodPressureDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodPressureDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodPressureBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private BloodPressureDBDataSetTableAdapters.BloodPressureTableAdapter bloodPressureTableAdapter;
        private System.Windows.Forms.BindingSource bloodPressureDBDataSetBindingSource;
        private BloodPressureDBDataSet bloodPressureDBDataSet;
        private System.Windows.Forms.BindingSource bloodPressureBindingSource;
        private System.Windows.Forms.BindingSource bloodPressureBindingSource1;
        private BloodPressureDBDataSet bloodPressureDBDataSet1;
        private BloodPressureDBDataSetTableAdapters.BloodPressureTableAdapter bloodPressureTableAdapter1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.ListBox hourListBox;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button printButton;
    }
}