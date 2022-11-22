namespace FinalProject
{
    partial class DonorEligibility
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonorEligibility));
            this.lblEligibility = new System.Windows.Forms.Label();
            this.gbOutputEligibility = new System.Windows.Forms.GroupBox();
            this.gbOutputEligibility.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEligibility
            // 
            this.lblEligibility.AutoSize = true;
            this.lblEligibility.BackColor = System.Drawing.Color.Transparent;
            this.lblEligibility.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEligibility.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEligibility.Location = new System.Drawing.Point(78, 54);
            this.lblEligibility.Name = "lblEligibility";
            this.lblEligibility.Size = new System.Drawing.Size(100, 17);
            this.lblEligibility.TabIndex = 0;
            this.lblEligibility.Text = "Eligibility Output";
            this.lblEligibility.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbOutputEligibility
            // 
            this.gbOutputEligibility.BackColor = System.Drawing.Color.Transparent;
            this.gbOutputEligibility.Controls.Add(this.lblEligibility);
            this.gbOutputEligibility.Location = new System.Drawing.Point(12, 12);
            this.gbOutputEligibility.Name = "gbOutputEligibility";
            this.gbOutputEligibility.Size = new System.Drawing.Size(472, 117);
            this.gbOutputEligibility.TabIndex = 1;
            this.gbOutputEligibility.TabStop = false;
            // 
            // DonorEligibility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(496, 141);
            this.Controls.Add(this.gbOutputEligibility);
            this.Name = "DonorEligibility";
            this.Text = "Donation";
            this.gbOutputEligibility.ResumeLayout(false);
            this.gbOutputEligibility.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEligibility;
        private System.Windows.Forms.GroupBox gbOutputEligibility;
    }
}