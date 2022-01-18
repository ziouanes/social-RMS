
namespace social_RMS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButtonPRINT = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_ajoute = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.versementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal_price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltype_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stepProgressBar1 = new DevExpress.XtraEditors.StepProgressBar();
            this.stepProgressBarItem1 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem2 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.stepProgressBarItem3 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.versementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.simpleButtonPRINT);
            this.layoutControl1.Controls.Add(this.simpleButton_ajoute);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.stepProgressBar1);
            this.layoutControl1.Controls.Add(this.lookUpEdit1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(771, 358);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // simpleButtonPRINT
            // 
            this.simpleButtonPRINT.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButtonPRINT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButtonPRINT.ImageOptions.SvgImage")));
            this.simpleButtonPRINT.Location = new System.Drawing.Point(652, 315);
            this.simpleButtonPRINT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.simpleButtonPRINT.Name = "simpleButtonPRINT";
            this.simpleButtonPRINT.Size = new System.Drawing.Size(111, 36);
            this.simpleButtonPRINT.StyleController = this.layoutControl1;
            this.simpleButtonPRINT.TabIndex = 15;
            this.simpleButtonPRINT.Text = "Imprimer Etat";
            this.simpleButtonPRINT.Visible = false;
            this.simpleButtonPRINT.Click += new System.EventHandler(this.simpleButtonPRINT_Click);
            // 
            // simpleButton_ajoute
            // 
            this.simpleButton_ajoute.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton_ajoute.ImageOptions.Image")));
            this.simpleButton_ajoute.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton_ajoute.Location = new System.Drawing.Point(8, 315);
            this.simpleButton_ajoute.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.simpleButton_ajoute.Name = "simpleButton_ajoute";
            this.simpleButton_ajoute.Size = new System.Drawing.Size(642, 36);
            this.simpleButton_ajoute.StyleController = this.layoutControl1;
            this.simpleButton_ajoute.TabIndex = 14;
            this.simpleButton_ajoute.Text = "nouveau versement";
            this.simpleButton_ajoute.Visible = false;
            this.simpleButton_ajoute.Click += new System.EventHandler(this.simpleButton_ajoute_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.versementBindingSource;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gridControl1.Location = new System.Drawing.Point(8, 133);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(755, 180);
            this.gridControl1.TabIndex = 13;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gridControl1_KeyUp);
            // 
            // versementBindingSource
            // 
            this.versementBindingSource.DataSource = typeof(social_RMS.versement);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colname_,
            this.colprice,
            this.coltotal_price,
            this.coltype_});
            this.gridView1.DetailHeight = 217;
            this.gridView1.FixedLineWidth = 1;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 2;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsPrint.ExpandAllDetails = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.coltype_, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.coltotal_price, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.MinWidth = 13;
            this.colid.Name = "colid";
            this.colid.Width = 50;
            // 
            // colname_
            // 
            this.colname_.FieldName = "name_";
            this.colname_.MinWidth = 13;
            this.colname_.Name = "colname_";
            this.colname_.Visible = true;
            this.colname_.VisibleIndex = 0;
            this.colname_.Width = 50;
            // 
            // colprice
            // 
            this.colprice.FieldName = "price";
            this.colprice.MinWidth = 13;
            this.colprice.Name = "colprice";
            this.colprice.Visible = true;
            this.colprice.VisibleIndex = 1;
            this.colprice.Width = 50;
            // 
            // coltotal_price
            // 
            this.coltotal_price.Caption = "Montant global";
            this.coltotal_price.FieldName = "total_price";
            this.coltotal_price.MinWidth = 13;
            this.coltotal_price.Name = "coltotal_price";
            this.coltotal_price.Visible = true;
            this.coltotal_price.VisibleIndex = 2;
            this.coltotal_price.Width = 50;
            // 
            // coltype_
            // 
            this.coltype_.Caption = "Type";
            this.coltype_.FieldName = "type_";
            this.coltype_.MinWidth = 13;
            this.coltype_.Name = "coltype_";
            this.coltype_.Visible = true;
            this.coltype_.VisibleIndex = 3;
            this.coltype_.Width = 50;
            // 
            // stepProgressBar1
            // 
            this.stepProgressBar1.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stepProgressBar1.Appearance.Options.UseBackColor = true;
            this.stepProgressBar1.ConnectorLineThickness = 1;
            this.stepProgressBar1.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.stepProgressBar1.DistanceBetweenContentBlockElements = 4;
            this.stepProgressBar1.IndentBetweenItems = 21;
            this.stepProgressBar1.IndicatorLineThickness = 1;
            this.stepProgressBar1.IndicatorToContentBlockDistance = 4;
            this.stepProgressBar1.Items.Add(this.stepProgressBarItem1);
            this.stepProgressBar1.Items.Add(this.stepProgressBarItem2);
            this.stepProgressBar1.Items.Add(this.stepProgressBarItem3);
            this.stepProgressBar1.LayoutMode = DevExpress.XtraEditors.StepProgressBarLayoutMode.FullSize;
            this.stepProgressBar1.Location = new System.Drawing.Point(8, 41);
            this.stepProgressBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stepProgressBar1.Name = "stepProgressBar1";
            this.stepProgressBar1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.stepProgressBar1.Size = new System.Drawing.Size(755, 90);
            this.stepProgressBar1.StyleController = this.layoutControl1;
            this.stepProgressBar1.TabIndex = 6;
            // 
            // stepProgressBarItem1
            // 
            this.stepProgressBarItem1.ContentBlock2.Caption = " achat de terrain ";
            this.stepProgressBarItem1.Name = "stepProgressBarItem1";
            // 
            // stepProgressBarItem2
            // 
            this.stepProgressBarItem2.ContentBlock2.Caption = "Enregistrement";
            this.stepProgressBarItem2.Name = "stepProgressBarItem2";
            // 
            // stepProgressBarItem3
            // 
            this.stepProgressBarItem3.ContentBlock2.Caption = "autorisation";
            this.stepProgressBarItem3.Name = "stepProgressBarItem3";
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(31, 7);
            this.lookUpEdit1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Undo)});
            this.lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id", 36, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name_fr", "NOM", 67, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name_ar", "name_ar", 70, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("cne", "cne", 34, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpEdit1.Properties.DataSource = this.personBindingSource;
            this.lookUpEdit1.Properties.DisplayMember = "name_fr";
            this.lookUpEdit1.Properties.NullText = "";
            this.lookUpEdit1.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            this.lookUpEdit1.Properties.ValueMember = "id";
            this.lookUpEdit1.Properties.Click += new System.EventHandler(this.lookUpEdit1_Properties_Click);
            this.lookUpEdit1.Size = new System.Drawing.Size(732, 20);
            this.lookUpEdit1.StyleController = this.layoutControl1;
            this.lookUpEdit1.TabIndex = 5;
            this.lookUpEdit1.EditValueChanged += new System.EventHandler(this.lookUpEdit1_EditValueChanged);
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(social_RMS.person);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem2,
            this.layoutControlItem2,
            this.layoutControlItem5,
            this.layoutControlItem4,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(771, 358);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lookUpEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(757, 22);
            this.layoutControlItem1.Text = "ID : ";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(21, 13);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 22);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(757, 12);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.stepProgressBar1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 34);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(757, 92);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.gridControl1;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 126);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(757, 182);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.simpleButton_ajoute;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 308);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(644, 38);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.simpleButtonPRINT;
            this.layoutControlItem3.Location = new System.Drawing.Point(644, 308);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(113, 38);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // Form1
            // 
            this.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 358);
            this.Controls.Add(this.layoutControl1);
            this.DoubleBuffered = true;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Form1.IconOptions.SvgImage")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.versementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.StepProgressBar stepProgressBar1;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem1;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem2;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem3;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.SimpleButton simpleButton_ajoute;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.BindingSource versementBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colname_;
        private DevExpress.XtraGrid.Columns.GridColumn colprice;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal_price;
        private DevExpress.XtraGrid.Columns.GridColumn coltype_;
        private DevExpress.XtraEditors.SimpleButton simpleButtonPRINT;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}

