
namespace social_RMS
{
    partial class form_print
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_print));
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonnonverser = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonverser = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(22, 46);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(192, 35);
            this.simpleButton1.TabIndex = 19;
            this.simpleButton1.Text = "imprimer etat global";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButtonnonverser
            // 
            this.simpleButtonnonverser.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButtonnonverser.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButtonnonverser.Location = new System.Drawing.Point(482, 46);
            this.simpleButtonnonverser.Name = "simpleButtonnonverser";
            this.simpleButtonnonverser.Size = new System.Drawing.Size(198, 35);
            this.simpleButtonnonverser.TabIndex = 20;
            this.simpleButtonnonverser.Text = " Non Versement";
            this.simpleButtonnonverser.Click += new System.EventHandler(this.simpleButtonnonverser_Click);
            // 
            // simpleButtonverser
            // 
            this.simpleButtonverser.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButtonverser.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton3.ImageOptions.SvgImage")));
            this.simpleButtonverser.Location = new System.Drawing.Point(248, 46);
            this.simpleButtonverser.Name = "simpleButtonverser";
            this.simpleButtonverser.Size = new System.Drawing.Size(198, 35);
            this.simpleButtonverser.TabIndex = 21;
            this.simpleButtonverser.Text = "Versement";
            this.simpleButtonverser.Click += new System.EventHandler(this.simpleButtonverser_Click);
            // 
            // form_print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 144);
            this.Controls.Add(this.simpleButtonverser);
            this.Controls.Add(this.simpleButtonnonverser);
            this.Controls.Add(this.simpleButton1);
            this.Name = "form_print";
            this.Text = "form_print";
            this.Load += new System.EventHandler(this.form_print_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonnonverser;
        private DevExpress.XtraEditors.SimpleButton simpleButtonverser;
    }
}