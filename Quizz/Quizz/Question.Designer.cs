namespace Quizz
{
    partial class frmQuestion
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.cmdReponseA = new System.Windows.Forms.Button();
            this.cmdReponseB = new System.Windows.Forms.Button();
            this.cmdReponseC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(75, 23);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(0, 13);
            this.lblQuestion.TabIndex = 0;
            // 
            // cmdReponseA
            // 
            this.cmdReponseA.Location = new System.Drawing.Point(43, 108);
            this.cmdReponseA.Name = "cmdReponseA";
            this.cmdReponseA.Size = new System.Drawing.Size(116, 59);
            this.cmdReponseA.TabIndex = 1;
            this.cmdReponseA.UseVisualStyleBackColor = true;
            // 
            // cmdReponseB
            // 
            this.cmdReponseB.Location = new System.Drawing.Point(198, 108);
            this.cmdReponseB.Name = "cmdReponseB";
            this.cmdReponseB.Size = new System.Drawing.Size(116, 59);
            this.cmdReponseB.TabIndex = 2;
            this.cmdReponseB.UseVisualStyleBackColor = true;
            // 
            // cmdReponseC
            // 
            this.cmdReponseC.Location = new System.Drawing.Point(348, 108);
            this.cmdReponseC.Name = "cmdReponseC";
            this.cmdReponseC.Size = new System.Drawing.Size(116, 59);
            this.cmdReponseC.TabIndex = 3;
            this.cmdReponseC.UseVisualStyleBackColor = true;
            // 
            // frmQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 247);
            this.Controls.Add(this.cmdReponseC);
            this.Controls.Add(this.cmdReponseB);
            this.Controls.Add(this.cmdReponseA);
            this.Controls.Add(this.lblQuestion);
            this.Name = "frmQuestion";
            this.Text = "Question";
            this.Load += new System.EventHandler(this.frmQuestion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button cmdReponseA;
        private System.Windows.Forms.Button cmdReponseB;
        private System.Windows.Forms.Button cmdReponseC;
    }
}