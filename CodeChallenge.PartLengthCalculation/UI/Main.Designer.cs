namespace CodeChallenge.PartLengthCalculation.UI
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.buttonCheck = new System.Windows.Forms.Button();
            this.listData = new System.Windows.Forms.ListView();
            this.imagellistIcons = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // buttonCheck
            // 
            this.buttonCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCheck.Location = new System.Drawing.Point(350, 286);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(75, 23);
            this.buttonCheck.TabIndex = 1;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // listData
            // 
            this.listData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listData.Location = new System.Drawing.Point(12, 12);
            this.listData.Name = "listData";
            this.listData.Size = new System.Drawing.Size(413, 268);
            this.listData.SmallImageList = this.imagellistIcons;
            this.listData.TabIndex = 2;
            this.listData.UseCompatibleStateImageBehavior = false;
            this.listData.View = System.Windows.Forms.View.Details;
            // 
            // imagellistIcons
            // 
            this.imagellistIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagellistIcons.ImageStream")));
            this.imagellistIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imagellistIcons.Images.SetKeyName(0, "Match");
            this.imagellistIcons.Images.SetKeyName(1, "Mismatch");
            this.imagellistIcons.Images.SetKeyName(2, "TBD");
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 316);
            this.Controls.Add(this.listData);
            this.Controls.Add(this.buttonCheck);
            this.Name = "Main";
            this.Text = "Code Challenge - Part Length";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.ListView listData;
        private System.Windows.Forms.ImageList imagellistIcons;
    }
}