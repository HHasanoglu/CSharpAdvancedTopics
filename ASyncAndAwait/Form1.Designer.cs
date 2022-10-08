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
            this.SuspendLayout();
            // 
            // btnNormalExecute
            // 
            this.btnNormalExecute.Location = new System.Drawing.Point(173, 68);
            this.btnNormalExecute.Name = "btnNormalExecute";
            this.btnNormalExecute.Size = new System.Drawing.Size(148, 64);
            this.btnNormalExecute.TabIndex = 0;
            this.btnNormalExecute.Text = "Normal Execute";
            this.btnNormalExecute.UseVisualStyleBackColor = true;
            // 
            // btnAsyncExecute
            // 
            this.btnAsyncExecute.Location = new System.Drawing.Point(327, 68);
            this.btnAsyncExecute.Name = "btnAsyncExecute";
            this.btnAsyncExecute.Size = new System.Drawing.Size(148, 64);
            this.btnAsyncExecute.TabIndex = 1;
            this.btnAsyncExecute.Text = "Async Execute";
            this.btnAsyncExecute.UseVisualStyleBackColor = true;
            // 
            // btnParallelAsyncExecute
            // 
            this.btnParallelAsyncExecute.Location = new System.Drawing.Point(481, 68);
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
            this.txtProgress.Size = new System.Drawing.Size(776, 289);
            this.txtProgress.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

