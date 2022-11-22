namespace FinalProject
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchDonors = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblOutputDonors = new System.Windows.Forms.Label();
            this.chtBloodTypes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblLowBlood = new System.Windows.Forms.Label();
            this.btnDonateToday = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chtBloodTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Donors:";
            // 
            // txtSearchDonors
            // 
            this.txtSearchDonors.Location = new System.Drawing.Point(154, 22);
            this.txtSearchDonors.Name = "txtSearchDonors";
            this.txtSearchDonors.Size = new System.Drawing.Size(119, 20);
            this.txtSearchDonors.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Red;
            this.btnSearch.Location = new System.Drawing.Point(97, 57);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 30);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblOutputDonors
            // 
            this.lblOutputDonors.AutoSize = true;
            this.lblOutputDonors.BackColor = System.Drawing.Color.Transparent;
            this.lblOutputDonors.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputDonors.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOutputDonors.Location = new System.Drawing.Point(27, 120);
            this.lblOutputDonors.Name = "lblOutputDonors";
            this.lblOutputDonors.Size = new System.Drawing.Size(0, 18);
            this.lblOutputDonors.TabIndex = 3;
            // 
            // chtBloodTypes
            // 
            this.chtBloodTypes.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chtBloodTypes.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtBloodTypes.Legends.Add(legend1);
            this.chtBloodTypes.Location = new System.Drawing.Point(406, 9);
            this.chtBloodTypes.Name = "chtBloodTypes";
            this.chtBloodTypes.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series1.BackSecondaryColor = System.Drawing.Color.Firebrick;
            series1.BorderColor = System.Drawing.Color.Red;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Blood";
            this.chtBloodTypes.Series.Add(series1);
            this.chtBloodTypes.Size = new System.Drawing.Size(438, 394);
            this.chtBloodTypes.TabIndex = 4;
            // 
            // lblLowBlood
            // 
            this.lblLowBlood.AutoSize = true;
            this.lblLowBlood.BackColor = System.Drawing.Color.Transparent;
            this.lblLowBlood.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowBlood.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLowBlood.Location = new System.Drawing.Point(445, 390);
            this.lblLowBlood.Name = "lblLowBlood";
            this.lblLowBlood.Size = new System.Drawing.Size(0, 13);
            this.lblLowBlood.TabIndex = 5;
            // 
            // btnDonateToday
            // 
            this.btnDonateToday.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonateToday.ForeColor = System.Drawing.Color.Red;
            this.btnDonateToday.Location = new System.Drawing.Point(543, 409);
            this.btnDonateToday.Name = "btnDonateToday";
            this.btnDonateToday.Size = new System.Drawing.Size(136, 30);
            this.btnDonateToday.TabIndex = 6;
            this.btnDonateToday.Text = "Donate Today?";
            this.btnDonateToday.UseVisualStyleBackColor = true;
            this.btnDonateToday.Click += new System.EventHandler(this.btnDonateToday_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(856, 530);
            this.Controls.Add(this.btnDonateToday);
            this.Controls.Add(this.lblLowBlood);
            this.Controls.Add(this.chtBloodTypes);
            this.Controls.Add(this.lblOutputDonors);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchDonors);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Donations";
            ((System.ComponentModel.ISupportInitialize)(this.chtBloodTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchDonors;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblOutputDonors;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtBloodTypes;
        private System.Windows.Forms.Label lblLowBlood;
        private System.Windows.Forms.Button btnDonateToday;
    }
}