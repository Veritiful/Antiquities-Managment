namespace Alexii_Zaretski
{
    partial class CompareForm
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
            this.compareBtn = new System.Windows.Forms.Button();
            this.secondCombo = new System.Windows.Forms.ComboBox();
            this.firstCombo = new System.Windows.Forms.ComboBox();
            this.operatorCombo = new System.Windows.Forms.ComboBox();
            this.res = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // compareBtn
            // 
            this.compareBtn.Location = new System.Drawing.Point(366, 245);
            this.compareBtn.Name = "compareBtn";
            this.compareBtn.Size = new System.Drawing.Size(75, 23);
            this.compareBtn.TabIndex = 7;
            this.compareBtn.Text = "Compare";
            this.compareBtn.UseVisualStyleBackColor = true;
            this.compareBtn.Click += new System.EventHandler(this.compareBtn_Click);
            // 
            // secondCombo
            // 
            this.secondCombo.FormattingEnabled = true;
            this.secondCombo.Location = new System.Drawing.Point(467, 182);
            this.secondCombo.Name = "secondCombo";
            this.secondCombo.Size = new System.Drawing.Size(261, 21);
            this.secondCombo.TabIndex = 6;
            // 
            // firstCombo
            // 
            this.firstCombo.FormattingEnabled = true;
            this.firstCombo.Location = new System.Drawing.Point(73, 182);
            this.firstCombo.Name = "firstCombo";
            this.firstCombo.Size = new System.Drawing.Size(261, 21);
            this.firstCombo.TabIndex = 5;
            // 
            // operatorCombo
            // 
            this.operatorCombo.FormattingEnabled = true;
            this.operatorCombo.Items.AddRange(new object[] {
            "==",
            "!=",
            ">",
            "<"});
            this.operatorCombo.Location = new System.Drawing.Point(378, 182);
            this.operatorCombo.Name = "operatorCombo";
            this.operatorCombo.Size = new System.Drawing.Size(45, 21);
            this.operatorCombo.TabIndex = 4;
            // 
            // res
            // 
            this.res.AutoSize = true;
            this.res.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.res.Location = new System.Drawing.Point(361, 293);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(0, 26);
            this.res.TabIndex = 8;
            // 
            // CompareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.res);
            this.Controls.Add(this.compareBtn);
            this.Controls.Add(this.secondCombo);
            this.Controls.Add(this.firstCombo);
            this.Controls.Add(this.operatorCombo);
            this.Name = "CompareForm";
            this.Text = "CompareForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button compareBtn;
        private System.Windows.Forms.ComboBox secondCombo;
        private System.Windows.Forms.ComboBox firstCombo;
        private System.Windows.Forms.ComboBox operatorCombo;
        private System.Windows.Forms.Label res;
    }
}