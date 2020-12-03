namespace WindowsFormsApp1
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
            this.MethodSelection = new System.Windows.Forms.ComboBox();
            this.MethodLb = new System.Windows.Forms.Label();
            this.BoneLbl = new System.Windows.Forms.Label();
            this.BoneSelectionCB = new System.Windows.Forms.ComboBox();
            this.AmountLbl = new System.Windows.Forms.Label();
            this.AmountTxt = new System.Windows.Forms.TextBox();
            this.ResultsLabel = new System.Windows.Forms.Label();
            this.ResultsTxtBox = new System.Windows.Forms.TextBox();
            this.ResultsRTxtBox = new System.Windows.Forms.RichTextBox();
            this.TrailBlazerCb = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // MethodSelection
            // 
            this.MethodSelection.FormattingEnabled = true;
            this.MethodSelection.Items.AddRange(new object[] {
            "Ecto",
            "House Alter"});
            this.MethodSelection.Location = new System.Drawing.Point(84, 20);
            this.MethodSelection.Name = "MethodSelection";
            this.MethodSelection.Size = new System.Drawing.Size(121, 21);
            this.MethodSelection.TabIndex = 0;
            this.MethodSelection.SelectedIndexChanged += new System.EventHandler(this.MethodSelection_SelectedIndexChanged);
            // 
            // MethodLb
            // 
            this.MethodLb.AutoSize = true;
            this.MethodLb.Location = new System.Drawing.Point(32, 20);
            this.MethodLb.Name = "MethodLb";
            this.MethodLb.Size = new System.Drawing.Size(46, 13);
            this.MethodLb.TabIndex = 1;
            this.MethodLb.Text = "Method:";
            // 
            // BoneLbl
            // 
            this.BoneLbl.AutoSize = true;
            this.BoneLbl.Location = new System.Drawing.Point(32, 47);
            this.BoneLbl.Name = "BoneLbl";
            this.BoneLbl.Size = new System.Drawing.Size(35, 13);
            this.BoneLbl.TabIndex = 6;
            this.BoneLbl.Text = "Bone:";
            // 
            // BoneSelectionCB
            // 
            this.BoneSelectionCB.FormattingEnabled = true;
            this.BoneSelectionCB.Items.AddRange(new object[] {
            "Dragon",
            "Wyvern"});
            this.BoneSelectionCB.Location = new System.Drawing.Point(84, 47);
            this.BoneSelectionCB.Name = "BoneSelectionCB";
            this.BoneSelectionCB.Size = new System.Drawing.Size(121, 21);
            this.BoneSelectionCB.TabIndex = 5;
            // 
            // AmountLbl
            // 
            this.AmountLbl.AutoSize = true;
            this.AmountLbl.Location = new System.Drawing.Point(32, 74);
            this.AmountLbl.Name = "AmountLbl";
            this.AmountLbl.Size = new System.Drawing.Size(46, 13);
            this.AmountLbl.TabIndex = 7;
            this.AmountLbl.Text = "Amount:";
            // 
            // AmountTxt
            // 
            this.AmountTxt.Location = new System.Drawing.Point(84, 74);
            this.AmountTxt.Name = "AmountTxt";
            this.AmountTxt.Size = new System.Drawing.Size(121, 20);
            this.AmountTxt.TabIndex = 8;
            this.AmountTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AmountTxt_KeyDown);
            // 
            // ResultsLabel
            // 
            this.ResultsLabel.AutoSize = true;
            this.ResultsLabel.Location = new System.Drawing.Point(243, 288);
            this.ResultsLabel.Name = "ResultsLabel";
            this.ResultsLabel.Size = new System.Drawing.Size(42, 13);
            this.ResultsLabel.TabIndex = 9;
            this.ResultsLabel.Text = "Results";
            // 
            // ResultsTxtBox
            // 
            this.ResultsTxtBox.Location = new System.Drawing.Point(132, 304);
            this.ResultsTxtBox.Multiline = true;
            this.ResultsTxtBox.Name = "ResultsTxtBox";
            this.ResultsTxtBox.ReadOnly = true;
            this.ResultsTxtBox.Size = new System.Drawing.Size(128, 97);
            this.ResultsTxtBox.TabIndex = 10;
            // 
            // ResultsRTxtBox
            // 
            this.ResultsRTxtBox.Location = new System.Drawing.Point(266, 305);
            this.ResultsRTxtBox.Name = "ResultsRTxtBox";
            this.ResultsRTxtBox.ReadOnly = true;
            this.ResultsRTxtBox.Size = new System.Drawing.Size(151, 96);
            this.ResultsRTxtBox.TabIndex = 11;
            this.ResultsRTxtBox.Text = "";
            // 
            // TrailBlazerCb
            // 
            this.TrailBlazerCb.AutoSize = true;
            this.TrailBlazerCb.Location = new System.Drawing.Point(246, 20);
            this.TrailBlazerCb.Name = "TrailBlazerCb";
            this.TrailBlazerCb.Size = new System.Drawing.Size(95, 17);
            this.TrailBlazerCb.TabIndex = 12;
            this.TrailBlazerCb.Text = "TrailBlazer x16";
            this.TrailBlazerCb.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TrailBlazerCb);
            this.Controls.Add(this.ResultsRTxtBox);
            this.Controls.Add(this.ResultsTxtBox);
            this.Controls.Add(this.ResultsLabel);
            this.Controls.Add(this.AmountTxt);
            this.Controls.Add(this.AmountLbl);
            this.Controls.Add(this.BoneLbl);
            this.Controls.Add(this.BoneSelectionCB);
            this.Controls.Add(this.MethodLb);
            this.Controls.Add(this.MethodSelection);
            this.Name = "Form1";
            this.Text = "Prayer Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MethodSelection;
        private System.Windows.Forms.Label MethodLb;
        private System.Windows.Forms.Label BoneLbl;
        private System.Windows.Forms.ComboBox BoneSelectionCB;
        private System.Windows.Forms.Label AmountLbl;
        private System.Windows.Forms.TextBox AmountTxt;
        private System.Windows.Forms.Label ResultsLabel;
        private System.Windows.Forms.TextBox ResultsTxtBox;
        private System.Windows.Forms.RichTextBox ResultsRTxtBox;
        private System.Windows.Forms.CheckBox TrailBlazerCb;
    }
}

