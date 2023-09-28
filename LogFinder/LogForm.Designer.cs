
namespace LogAnalyzer
{
    partial class LogForm
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

            //this.gridView1.RowClick += new System.EventHandler(this.gridView1_RowClick);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.allLogsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new LogAnalyzer.DataSet2();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldateLog = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltimeLog = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltypeLog = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpackageLog = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colinfoLog = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstackLog = new DevExpress.XtraGrid.Columns.GridColumn();
            this.numberLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.numberTextbox = new System.Windows.Forms.TextBox();
            this.errorTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allLogsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.AutoSize = true;
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Controls.Add(this.numberLabel);
            this.panelControl1.Controls.Add(this.errorLabel);
            this.panelControl1.Controls.Add(this.numberTextbox);
            this.panelControl1.Controls.Add(this.errorTextbox);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1248, 585);
            this.panelControl1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.allLogsBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 66);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1247, 521);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // allLogsBindingSource
            // 
            this.allLogsBindingSource.DataMember = "allLogs";
            this.allLogsBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldateLog,
            this.coltimeLog,
            this.coltypeLog,
            this.colpackageLog,
            this.colinfoLog,
            this.colstackLog});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // coldateLog
            // 
            this.coldateLog.FieldName = "dateLog";
            this.coldateLog.Name = "coldateLog";
            this.coldateLog.Visible = true;
            this.coldateLog.VisibleIndex = 0;
            // 
            // coltimeLog
            // 
            this.coltimeLog.FieldName = "timeLog";
            this.coltimeLog.Name = "coltimeLog";
            this.coltimeLog.Visible = true;
            this.coltimeLog.VisibleIndex = 1;
            // 
            // coltypeLog
            // 
            this.coltypeLog.FieldName = "typeLog";
            this.coltypeLog.Name = "coltypeLog";
            this.coltypeLog.Visible = true;
            this.coltypeLog.VisibleIndex = 2;
            // 
            // colpackageLog
            // 
            this.colpackageLog.FieldName = "packageLog";
            this.colpackageLog.Name = "colpackageLog";
            this.colpackageLog.Visible = true;
            this.colpackageLog.VisibleIndex = 3;
            // 
            // colinfoLog
            // 
            this.colinfoLog.FieldName = "infoLog";
            this.colinfoLog.Name = "colinfoLog";
            this.colinfoLog.Visible = true;
            this.colinfoLog.VisibleIndex = 4;
            // 
            // colstackLog
            // 
            this.colstackLog.FieldName = "stackLog";
            this.colstackLog.Name = "colstackLog";
            this.colstackLog.Visible = true;
            this.colstackLog.VisibleIndex = 5;
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(769, 12);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(84, 13);
            this.numberLabel.TabIndex = 3;
            this.numberLabel.Text = "Number of error";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(100, 13);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(31, 13);
            this.errorLabel.TabIndex = 2;
            this.errorLabel.Text = "Error";
            // 
            // numberTextbox
            // 
            this.numberTextbox.Location = new System.Drawing.Point(769, 39);
            this.numberTextbox.Name = "numberTextbox";
            this.numberTextbox.ReadOnly = true;
            this.numberTextbox.Size = new System.Drawing.Size(100, 21);
            this.numberTextbox.TabIndex = 1;
            // 
            // errorTextbox
            // 
            this.errorTextbox.Location = new System.Drawing.Point(100, 39);
            this.errorTextbox.Name = "errorTextbox";
            this.errorTextbox.ReadOnly = true;
            this.errorTextbox.Size = new System.Drawing.Size(627, 21);
            this.errorTextbox.TabIndex = 0;
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 585);
            this.Controls.Add(this.panelControl1);
            this.Name = "LogForm";
            this.Text = "LogForm";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allLogsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.TextBox numberTextbox;
        private System.Windows.Forms.TextBox errorTextbox;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource allLogsBindingSource;
        private DataSet2 dataSet2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn coldateLog;
        private DevExpress.XtraGrid.Columns.GridColumn coltimeLog;
        private DevExpress.XtraGrid.Columns.GridColumn coltypeLog;
        private DevExpress.XtraGrid.Columns.GridColumn colpackageLog;
        private DevExpress.XtraGrid.Columns.GridColumn colinfoLog;
        private DevExpress.XtraGrid.Columns.GridColumn colstackLog;
    }
}