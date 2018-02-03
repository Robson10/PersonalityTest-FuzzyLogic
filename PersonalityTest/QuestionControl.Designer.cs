namespace PersonalityTest
{
    partial class QuestionControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.btNext = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioAgree = new System.Windows.Forms.RadioButton();
            this.radioPropablyYes = new System.Windows.Forms.RadioButton();
            this.radioNotKnown = new System.Windows.Forms.RadioButton();
            this.radioPropablyNot = new System.Windows.Forms.RadioButton();
            this.radioNotAgree = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbQuestion
            // 
            this.tbQuestion.BackColor = System.Drawing.Color.White;
            this.tbQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbQuestion.Location = new System.Drawing.Point(0, 0);
            this.tbQuestion.Multiline = true;
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.ReadOnly = true;
            this.tbQuestion.Size = new System.Drawing.Size(592, 93);
            this.tbQuestion.TabIndex = 0;
            this.tbQuestion.Text = "Jeżeli Twój przyjaciel lub przyjaciółka jest smutny(a), zaoferujesz mu/jej raczej" +
    " wsparcie emocjonalne niż sugestie sposobów rozwiązania problemu";
            // 
            // btNext
            // 
            this.btNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btNext.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btNext.FlatAppearance.BorderSize = 0;
            this.btNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btNext.Location = new System.Drawing.Point(411, 3);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(172, 37);
            this.btNext.TabIndex = 6;
            this.btNext.Text = "Dalej";
            this.btNext.UseVisualStyleBackColor = false;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btBack.FlatAppearance.BorderSize = 0;
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btBack.Location = new System.Drawing.Point(3, 3);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(172, 37);
            this.btBack.TabIndex = 7;
            this.btBack.Text = "Cofnij";
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btBack);
            this.panel1.Controls.Add(this.btNext);
            this.panel1.Location = new System.Drawing.Point(3, 298);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 56);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioAgree);
            this.panel2.Controls.Add(this.radioPropablyYes);
            this.panel2.Controls.Add(this.radioNotKnown);
            this.panel2.Controls.Add(this.radioPropablyNot);
            this.panel2.Controls.Add(this.radioNotAgree);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(592, 199);
            this.panel2.TabIndex = 9;
            // 
            // radioAgree
            // 
            this.radioAgree.AutoSize = true;
            this.radioAgree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioAgree.Location = new System.Drawing.Point(3, 139);
            this.radioAgree.Name = "radioAgree";
            this.radioAgree.Size = new System.Drawing.Size(136, 28);
            this.radioAgree.TabIndex = 10;
            this.radioAgree.TabStop = true;
            this.radioAgree.Text = "Zgadzam się";
            this.radioAgree.UseVisualStyleBackColor = true;
            this.radioAgree.CheckedChanged += new System.EventHandler(this.radioAgree_CheckedChanged_1);
            // 
            // radioPropablyYes
            // 
            this.radioPropablyYes.AutoSize = true;
            this.radioPropablyYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioPropablyYes.Location = new System.Drawing.Point(3, 105);
            this.radioPropablyYes.Name = "radioPropablyYes";
            this.radioPropablyYes.Size = new System.Drawing.Size(113, 28);
            this.radioPropablyYes.TabIndex = 9;
            this.radioPropablyYes.TabStop = true;
            this.radioPropablyYes.Text = "Raczej tak";
            this.radioPropablyYes.UseVisualStyleBackColor = true;
            this.radioPropablyYes.CheckedChanged += new System.EventHandler(this.radioPropablyYes_CheckedChanged_1);
            // 
            // radioNotKnown
            // 
            this.radioNotKnown.AutoSize = true;
            this.radioNotKnown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioNotKnown.Location = new System.Drawing.Point(4, 71);
            this.radioNotKnown.Name = "radioNotKnown";
            this.radioNotKnown.Size = new System.Drawing.Size(107, 28);
            this.radioNotKnown.TabIndex = 8;
            this.radioNotKnown.TabStop = true;
            this.radioNotKnown.Text = "Nie wiem";
            this.radioNotKnown.UseVisualStyleBackColor = true;
            this.radioNotKnown.CheckedChanged += new System.EventHandler(this.radioNotKnown_CheckedChanged_1);
            // 
            // radioPropablyNot
            // 
            this.radioPropablyNot.AutoSize = true;
            this.radioPropablyNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioPropablyNot.Location = new System.Drawing.Point(3, 37);
            this.radioPropablyNot.Name = "radioPropablyNot";
            this.radioPropablyNot.Size = new System.Drawing.Size(116, 28);
            this.radioPropablyNot.TabIndex = 7;
            this.radioPropablyNot.TabStop = true;
            this.radioPropablyNot.Text = "Raczej nie";
            this.radioPropablyNot.UseVisualStyleBackColor = true;
            this.radioPropablyNot.CheckedChanged += new System.EventHandler(this.radioPropablyNot_CheckedChanged_1);
            // 
            // radioNotAgree
            // 
            this.radioNotAgree.AutoSize = true;
            this.radioNotAgree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioNotAgree.Location = new System.Drawing.Point(3, 3);
            this.radioNotAgree.Name = "radioNotAgree";
            this.radioNotAgree.Size = new System.Drawing.Size(167, 28);
            this.radioNotAgree.TabIndex = 6;
            this.radioNotAgree.TabStop = true;
            this.radioNotAgree.Text = "Nie zgadzam się";
            this.radioNotAgree.UseVisualStyleBackColor = true;
            this.radioNotAgree.CheckedChanged += new System.EventHandler(this.radioNotAgree_CheckedChanged_1);
            // 
            // QuestionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbQuestion);
            this.Name = "QuestionControl";
            this.Size = new System.Drawing.Size(592, 363);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbQuestion;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioAgree;
        private System.Windows.Forms.RadioButton radioPropablyYes;
        private System.Windows.Forms.RadioButton radioNotKnown;
        private System.Windows.Forms.RadioButton radioPropablyNot;
        private System.Windows.Forms.RadioButton radioNotAgree;
    }
}
