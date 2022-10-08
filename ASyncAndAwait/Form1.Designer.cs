namespace AsyncAndAwait
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
            this.btnNormalExecute = new System.Windows.Forms.Button();
            this.btnAsyncExecute = new System.Windows.Forms.Button();
            this.btnParallelAsyncExecute = new System.Windows.Forms.Button();
            this.txtProgress = new System.Windows.Forms.TextBox();
            this.btnAsyncAndReport = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.prgbr = new System.Windows.Forms.ProgressBar();
            this.totalTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnNormalExecute
            // 
            this.btnNormalExecute.Location = new System.Drawing.Point(12, 12);
            this.btnNormalExecute.Name = "btnNormalExecute";
            this.btnNormalExecute.Size = new System.Drawing.Size(148, 64);
            this.btnNormalExecute.TabIndex = 0;
            this.btnNormalExecute.Text = "Normal Execute";
            this.btnNormalExecute.UseVisualStyleBackColor = true;
            // 
            // btnAsyncExecute
            // 
            this.btnAsyncExecute.Location = new System.Drawing.Point(166, 12);
            this.btnAsyncExecute.Name = "btnAsyncExecute";
            this.btnAsyncExecute.Size = new System.Drawing.Size(148, 64);
            this.btnAsyncExecute.TabIndex = 1;
            this.btnAsyncExecute.Text = "Async Execute";
            this.btnAsyncExecute.UseVisualStyleBackColor = true;
            // 
            // btnParallelAsyncExecute
            // 
            this.btnParallelAsyncExecute.Location = new System.Drawing.Point(320, 12);
            this.btnParallelAsyncExecute.Name = "btnParallelAsyncExecute";
            this.btnParallelAsyncExecute.Size = new System.Drawing.Size(148, 64);
            this.btnParallelAsyncExecute.TabIndex = 2;
            this.btnParallelAsyncExecute.Text = "Parallel Async Execute";
            this.btnParallelAsyncExecute.UseVisualStyleBackColor = true;
            // 
            // txtProgress
            // 
            this.txtProgress.Location = new System.Drawing.Point(12, 149);
            this.txtProgress.Multiline = true;
            this.txtProgress.Name = "txtProgress";
            this.txtProgress.Size = new System.Drawing.Size(610, 368);
            this.txtProgress.TabIndex = 3;
            // 
            // btnAsyncAndReport
            // 
            this.btnAsyncAndReport.Location = new System.Drawing.Point(474, 12);
            this.btnAsyncAndReport.Name = "btnAsyncAndReport";
            this.btnAsyncAndReport.Size = new System.Drawing.Size(148, 64);
            this.btnAsyncAndReport.TabIndex = 4;
            this.btnAsyncAndReport.Text = "Async Execute and Report";
            this.btnAsyncAndReport.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(628, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 64);
            this.button2.TabIndex = 5;
            this.button2.Text = "Parallel Async Execute";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // prgbr
            // 
            this.prgbr.Location = new System.Drawing.Point(12, 107);
            this.prgbr.Name = "prgbr";
            this.prgbr.Size = new System.Drawing.Size(776, 36);
            this.prgbr.TabIndex = 6;
            // 
            // totalTime
            // 
            this.totalTime.Location = new System.Drawing.Point(696, 241);
            this.totalTime.Multiline = true;
            this.totalTime.Name = "totalTime";
            this.totalTime.Size = new System.Drawing.Size(92, 110);
            this.totalTime.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 529);
            this.Controls.Add(this.totalTime);
            this.Controls.Add(this.prgbr);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAsyncAndReport);
            this.Controls.Add(this.txtProgress);
            this.Controls.Add(this.btnParallelAsyncExecute);
            this.Controls.Add(this.btnAsyncExecute);
            this.Controls.Add(this.btnNormalExecute);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNormalExecute;
        private System.Windows.Forms.Button btnAsyncExecute;
        private System.Windows.Forms.Button btnParallelAsyncExecute;
        private System.Windows.Forms.TextBox txtProgress;
        private System.Windows.Forms.Button btnAsyncAndReport;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar prgbr;
        private System.Windows.Forms.TextBox totalTime;
    }
}

