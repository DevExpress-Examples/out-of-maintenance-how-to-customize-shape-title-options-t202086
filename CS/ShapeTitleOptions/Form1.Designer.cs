namespace ShapeTitleOptions {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.cbTitleVisibility = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // mapControl1
            // 
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.Location = new System.Drawing.Point(0, 0);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.NavigationPanelOptions.Visible = false;
            this.mapControl1.Size = new System.Drawing.Size(304, 201);
            this.mapControl1.TabIndex = 0;
            // 
            // cbTitleVisibility
            // 
            this.cbTitleVisibility.AutoSize = true;
            this.cbTitleVisibility.Checked = true;
            this.cbTitleVisibility.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTitleVisibility.Location = new System.Drawing.Point(13, 13);
            this.cbTitleVisibility.Name = "cbTitleVisibility";
            this.cbTitleVisibility.Size = new System.Drawing.Size(110, 17);
            this.cbTitleVisibility.TabIndex = 1;
            this.cbTitleVisibility.Text = "Show Shape Title";
            this.cbTitleVisibility.UseVisualStyleBackColor = true;
            this.cbTitleVisibility.CheckedChanged += new System.EventHandler(this.cbTitleVisibility_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 201);
            this.Controls.Add(this.cbTitleVisibility);
            this.Controls.Add(this.mapControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraMap.MapControl mapControl1;
        private System.Windows.Forms.CheckBox cbTitleVisibility;


    }
}

