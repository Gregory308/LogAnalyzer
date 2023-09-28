
namespace LogAnalyzer
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
            this.components = new System.ComponentModel.Container();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dataGridView1 = new DevExpress.XtraGrid.GridControl();
            this.logsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new LogAnalyzer.DataSet1();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coltypeLog = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpackageLog = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colinfoLog = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcountLog = new DevExpress.XtraGrid.Columns.GridColumn();
            this.saveToJsonButton = new System.Windows.Forms.Button();
            this.numberTextbox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.pathLabel = new System.Windows.Forms.Label();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.chooseDirectoryButton = new System.Windows.Forms.Button();
            this.loadProgressBar = new System.Windows.Forms.ProgressBar();
            this.file1TextBox = new System.Windows.Forms.TextBox();
            this.file2TextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.file2TextBox);
            this.panelControl1.Controls.Add(this.file1TextBox);
            this.panelControl1.Controls.Add(this.loadProgressBar);
            this.panelControl1.Controls.Add(this.dataGridView1);
            this.panelControl1.Controls.Add(this.saveToJsonButton);
            this.panelControl1.Controls.Add(this.numberTextbox);
            this.panelControl1.Controls.Add(this.resultLabel);
            this.panelControl1.Controls.Add(this.clearButton);
            this.panelControl1.Controls.Add(this.searchButton);
            this.panelControl1.Controls.Add(this.pathLabel);
            this.panelControl1.Controls.Add(this.pathTextBox);
            this.panelControl1.Controls.Add(this.chooseDirectoryButton);
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1156, 448);
            this.panelControl1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.DataSource = this.logsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 110);
            this.dataGridView1.MainView = this.gridView1;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1156, 338);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // logsBindingSource
            // 
            this.logsBindingSource.DataMember = "Logs";
            this.logsBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coltypeLog,
            this.colpackageLog,
            this.colinfoLog,
            this.colcountLog});
            this.gridView1.GridControl = this.dataGridView1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // coltypeLog
            // 
            this.coltypeLog.FieldName = "typeLog";
            this.coltypeLog.Name = "coltypeLog";
            this.coltypeLog.Visible = true;
            this.coltypeLog.VisibleIndex = 0;
            // 
            // colpackageLog
            // 
            this.colpackageLog.FieldName = "packageLog";
            this.colpackageLog.Name = "colpackageLog";
            this.colpackageLog.Visible = true;
            this.colpackageLog.VisibleIndex = 1;
            // 
            // colinfoLog
            // 
            this.colinfoLog.FieldName = "infoLog";
            this.colinfoLog.Name = "colinfoLog";
            this.colinfoLog.Visible = true;
            this.colinfoLog.VisibleIndex = 2;
            // 
            // colcountLog
            // 
            this.colcountLog.FieldName = "countLog";
            this.colcountLog.Name = "colcountLog";
            this.colcountLog.Visible = true;
            this.colcountLog.VisibleIndex = 3;
            // 
            // saveToJsonButton
            // 
            this.saveToJsonButton.Location = new System.Drawing.Point(805, 78);
            this.saveToJsonButton.Name = "saveToJsonButton";
            this.saveToJsonButton.Size = new System.Drawing.Size(110, 29);
            this.saveToJsonButton.TabIndex = 14;
            this.saveToJsonButton.Text = "Save to JSON";
            this.saveToJsonButton.UseVisualStyleBackColor = true;
            this.saveToJsonButton.Click += new System.EventHandler(this.saveToJsonButton_Click);
            // 
            // numberTextbox
            // 
            this.numberTextbox.Location = new System.Drawing.Point(866, 37);
            this.numberTextbox.Name = "numberTextbox";
            this.numberTextbox.ReadOnly = true;
            this.numberTextbox.Size = new System.Drawing.Size(100, 21);
            this.numberTextbox.TabIndex = 13;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(767, 43);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(93, 13);
            this.resultLabel.TabIndex = 12;
            this.resultLabel.Text = "Number of errors:";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(549, 77);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 30);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(549, 24);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 33);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(245, 64);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(29, 13);
            this.pathLabel.TabIndex = 2;
            this.pathLabel.Text = "Path";
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(245, 83);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.ReadOnly = true;
            this.pathTextBox.Size = new System.Drawing.Size(267, 21);
            this.pathTextBox.TabIndex = 1;
            // 
            // chooseDirectoryButton
            // 
            this.chooseDirectoryButton.Location = new System.Drawing.Point(245, 24);
            this.chooseDirectoryButton.Name = "chooseDirectoryButton";
            this.chooseDirectoryButton.Size = new System.Drawing.Size(267, 34);
            this.chooseDirectoryButton.TabIndex = 1;
            this.chooseDirectoryButton.Text = "Choose directory";
            this.chooseDirectoryButton.UseVisualStyleBackColor = true;
            this.chooseDirectoryButton.Click += new System.EventHandler(this.chooseDirectoryButton_Click);
            // 
            // loadProgressBar
            // 
            this.loadProgressBar.Location = new System.Drawing.Point(930, 78);
            this.loadProgressBar.Name = "loadProgressBar";
            this.loadProgressBar.Size = new System.Drawing.Size(214, 29);
            this.loadProgressBar.TabIndex = 16;
            // 
            // file1TextBox
            // 
            this.file1TextBox.Location = new System.Drawing.Point(1008, 5);
            this.file1TextBox.Name = "file1TextBox";
            this.file1TextBox.Size = new System.Drawing.Size(100, 21);
            this.file1TextBox.TabIndex = 17;
            // 
            // file2TextBox
            // 
            this.file2TextBox.Location = new System.Drawing.Point(1008, 43);
            this.file2TextBox.Name = "file2TextBox";
            this.file2TextBox.Size = new System.Drawing.Size(100, 21);
            this.file2TextBox.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1156, 448);
            this.Controls.Add(this.panelControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Button chooseDirectoryButton;
        private DataSet1 dataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn classLogDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageLogDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button saveToJsonButton;
        private System.Windows.Forms.TextBox numberTextbox;
        private DevExpress.XtraGrid.GridControl dataGridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn coltypeLog;
        private DevExpress.XtraGrid.Columns.GridColumn colpackageLog;
        private DevExpress.XtraGrid.Columns.GridColumn colinfoLog;
        private DevExpress.XtraGrid.Columns.GridColumn colcountLog;
        private System.Windows.Forms.BindingSource logsBindingSource;
        private System.Windows.Forms.ProgressBar loadProgressBar;
        private System.Windows.Forms.TextBox file2TextBox;
        private System.Windows.Forms.TextBox file1TextBox;
    }
}

