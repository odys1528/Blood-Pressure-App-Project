namespace AnotherForm
{
    partial class BarChartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarChartForm));
            DevExpress.XtraCharts.XYDiagram xyDiagram5 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.XYDiagramPane xyDiagramPane3 = new DevExpress.XtraCharts.XYDiagramPane();
            DevExpress.XtraCharts.Series series7 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Series series8 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView3 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle5 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.XYDiagram xyDiagram6 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series9 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.ChartTitle chartTitle6 = new DevExpress.XtraCharts.ChartTitle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.hourListBox = new System.Windows.Forms.ListBox();
            this.printButton = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pressureChartControl = new DevExpress.XtraCharts.ChartControl();
            this.pulseChartControl = new DevExpress.XtraCharts.ChartControl();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pressureChartControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagramPane3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pulseChartControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series9)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.7347F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.2653F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 211F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61F));
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
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.titleLabel, 3);
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.Location = new System.Drawing.Point(86, 18);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(176, 29);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Dane pacjenta";
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fromDateTimePicker.Location = new System.Drawing.Point(108, 129);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.fromDateTimePicker.TabIndex = 3;
            this.fromDateTimePicker.Validated += new System.EventHandler(this.fromDateTimePicker_Validated);
            // 
            // toLabel
            // 
            this.toLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(61, 214);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(24, 17);
            this.toLabel.TabIndex = 2;
            this.toLabel.Text = "do";
            // 
            // fromLabel
            // 
            this.fromLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(61, 132);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(24, 17);
            this.fromLabel.TabIndex = 1;
            this.fromLabel.Text = "od";
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.toDateTimePicker.Location = new System.Drawing.Point(108, 211);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.toDateTimePicker.TabIndex = 4;
            this.toDateTimePicker.Validated += new System.EventHandler(this.toDateTimePicker_Validated);
            // 
            // hourListBox
            // 
            this.hourListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.hourListBox, 3);
            this.hourListBox.FormattingEnabled = true;
            this.hourListBox.ItemHeight = 16;
            this.hourListBox.Location = new System.Drawing.Point(82, 295);
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
            this.printButton.Location = new System.Drawing.Point(87, 393);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(173, 39);
            this.printButton.TabIndex = 6;
            this.printButton.Text = "Wydrukuj wykres";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
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
            // pressureChartControl
            // 
            xyDiagram5.AxisX.GridLines.Visible = true;
            xyDiagram5.AxisX.Title.Alignment = System.Drawing.StringAlignment.Far;
            xyDiagram5.AxisX.Title.Font = new System.Drawing.Font("Tahoma", 6F);
            xyDiagram5.AxisX.Title.Text = "mmHg";
            xyDiagram5.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram5.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram5.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram5.AxisY.Title.Alignment = System.Drawing.StringAlignment.Far;
            xyDiagram5.AxisY.Title.Font = new System.Drawing.Font("Tahoma", 6F);
            xyDiagram5.AxisY.Title.Text = "%";
            xyDiagram5.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram5.AxisY.VisibleInPanesSerializable = "-1;0";
            xyDiagram5.PaneLayoutDirection = DevExpress.XtraCharts.PaneLayoutDirection.Horizontal;
            xyDiagramPane3.Name = "Pane 1";
            xyDiagramPane3.PaneID = 0;
            xyDiagram5.Panes.AddRange(new DevExpress.XtraCharts.XYDiagramPane[] {
            xyDiagramPane3});
            xyDiagram5.Rotated = true;
            this.pressureChartControl.Diagram = xyDiagram5;
            this.pressureChartControl.Legend.Name = "Default Legend";
            this.pressureChartControl.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.pressureChartControl.Location = new System.Drawing.Point(396, 12);
            this.pressureChartControl.Name = "pressureChartControl";
            series7.Name = "systolic";
            series8.Name = "diastolic";
            sideBySideBarSeriesView3.PaneName = "Pane 1";
            series8.View = sideBySideBarSeriesView3;
            this.pressureChartControl.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series7,
        series8};
            this.pressureChartControl.Size = new System.Drawing.Size(608, 468);
            this.pressureChartControl.TabIndex = 3;
            chartTitle5.Alignment = System.Drawing.StringAlignment.Near;
            chartTitle5.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            chartTitle5.Indent = 0;
            chartTitle5.Text = "                 sys                                                             " +
    "    dia";
            chartTitle5.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.pressureChartControl.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle5});
            // 
            // pulseChartControl
            // 
            xyDiagram6.AxisX.GridLines.Visible = true;
            xyDiagram6.AxisX.Title.Alignment = System.Drawing.StringAlignment.Far;
            xyDiagram6.AxisX.Title.Font = new System.Drawing.Font("Tahoma", 6F);
            xyDiagram6.AxisX.Title.Text = "P/min";
            xyDiagram6.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram6.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram6.AxisY.Title.Alignment = System.Drawing.StringAlignment.Far;
            xyDiagram6.AxisY.Title.Font = new System.Drawing.Font("Tahoma", 6F);
            xyDiagram6.AxisY.Title.Text = "%";
            xyDiagram6.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram6.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram6.Rotated = true;
            this.pulseChartControl.Diagram = xyDiagram6;
            this.pulseChartControl.Legend.Name = "Default Legend";
            this.pulseChartControl.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.pulseChartControl.Location = new System.Drawing.Point(1010, 12);
            this.pulseChartControl.Name = "pulseChartControl";
            series9.Name = "pulse";
            this.pulseChartControl.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series9};
            this.pulseChartControl.Size = new System.Drawing.Size(313, 468);
            this.pulseChartControl.TabIndex = 4;
            chartTitle6.Alignment = System.Drawing.StringAlignment.Near;
            chartTitle6.Font = new System.Drawing.Font("Tahoma", 6F);
            chartTitle6.Indent = 0;
            chartTitle6.Text = "                pulse";
            this.pulseChartControl.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle6});
            // 
            // BarChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 492);
            this.Controls.Add(this.pulseChartControl);
            this.Controls.Add(this.pressureChartControl);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BarChartForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "BarChartForm";
            this.Load += new System.EventHandler(this.BarChartForm_Load);
            this.Shown += new System.EventHandler(this.BarChartForm_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(xyDiagramPane3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressureChartControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pulseChartControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.ListBox hourListBox;
        private System.Windows.Forms.Button printButton;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private DevExpress.XtraCharts.ChartControl pressureChartControl;
        private DevExpress.XtraCharts.ChartControl pulseChartControl;
    }
}