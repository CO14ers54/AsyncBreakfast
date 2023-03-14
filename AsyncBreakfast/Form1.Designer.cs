namespace AsyncBreakfast
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox_BreakfastProgress = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Sync = new System.Windows.Forms.Button();
            this.btn_Async = new System.Windows.Forms.Button();
            this.btn_Parallel = new System.Windows.Forms.Button();
            this.richTextBox_BreakfastProgressSync = new System.Windows.Forms.RichTextBox();
            this.richTextBox_BreakfastProgressAsync = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_runAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox_BreakfastProgress
            // 
            this.richTextBox_BreakfastProgress.Location = new System.Drawing.Point(1160, 38);
            this.richTextBox_BreakfastProgress.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.richTextBox_BreakfastProgress.Name = "richTextBox_BreakfastProgress";
            this.richTextBox_BreakfastProgress.Size = new System.Drawing.Size(405, 747);
            this.richTextBox_BreakfastProgress.TabIndex = 0;
            this.richTextBox_BreakfastProgress.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1160, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Breakfast Parallel Preparation Progress";
            // 
            // btn_Sync
            // 
            this.btn_Sync.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Sync.Location = new System.Drawing.Point(14, 38);
            this.btn_Sync.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Sync.Name = "btn_Sync";
            this.btn_Sync.Size = new System.Drawing.Size(268, 31);
            this.btn_Sync.TabIndex = 2;
            this.btn_Sync.Text = "Prepare Breakfast Synchronously";
            this.btn_Sync.UseVisualStyleBackColor = true;
            this.btn_Sync.Click += new System.EventHandler(this.btn_Sync_Click);
            // 
            // btn_Async
            // 
            this.btn_Async.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Async.Location = new System.Drawing.Point(12, 75);
            this.btn_Async.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Async.Name = "btn_Async";
            this.btn_Async.Size = new System.Drawing.Size(271, 31);
            this.btn_Async.TabIndex = 3;
            this.btn_Async.Text = "Prepare Breakfast Asynchronously";
            this.btn_Async.UseVisualStyleBackColor = true;
            // 
            // btn_Parallel
            // 
            this.btn_Parallel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Parallel.Location = new System.Drawing.Point(12, 112);
            this.btn_Parallel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Parallel.Name = "btn_Parallel";
            this.btn_Parallel.Size = new System.Drawing.Size(271, 31);
            this.btn_Parallel.TabIndex = 4;
            this.btn_Parallel.Text = "Prepare Breakfast Parallel";
            this.btn_Parallel.UseVisualStyleBackColor = true;
            this.btn_Parallel.Click += new System.EventHandler(this.btn_Parallel_Click);
            // 
            // richTextBox_BreakfastProgressSync
            // 
            this.richTextBox_BreakfastProgressSync.Location = new System.Drawing.Point(300, 38);
            this.richTextBox_BreakfastProgressSync.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.richTextBox_BreakfastProgressSync.Name = "richTextBox_BreakfastProgressSync";
            this.richTextBox_BreakfastProgressSync.Size = new System.Drawing.Size(405, 747);
            this.richTextBox_BreakfastProgressSync.TabIndex = 5;
            this.richTextBox_BreakfastProgressSync.Text = "";
            // 
            // richTextBox_BreakfastProgressAsync
            // 
            this.richTextBox_BreakfastProgressAsync.Location = new System.Drawing.Point(730, 38);
            this.richTextBox_BreakfastProgressAsync.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.richTextBox_BreakfastProgressAsync.Name = "richTextBox_BreakfastProgressAsync";
            this.richTextBox_BreakfastProgressAsync.Size = new System.Drawing.Size(405, 747);
            this.richTextBox_BreakfastProgressAsync.TabIndex = 6;
            this.richTextBox_BreakfastProgressAsync.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(300, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Breakfast Sync Preparation Progress";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(730, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Breakfast Async Preparation Progress";
            // 
            // btn_runAll
            // 
            this.btn_runAll.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_runAll.Location = new System.Drawing.Point(14, 149);
            this.btn_runAll.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_runAll.Name = "btn_runAll";
            this.btn_runAll.Size = new System.Drawing.Size(271, 31);
            this.btn_runAll.TabIndex = 9;
            this.btn_runAll.Text = "Prepare Breakfast All Ways";
            this.btn_runAll.UseVisualStyleBackColor = true;
            this.btn_runAll.Click += new System.EventHandler(this.btn_RunAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1580, 797);
            this.Controls.Add(this.btn_runAll);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox_BreakfastProgressAsync);
            this.Controls.Add(this.richTextBox_BreakfastProgressSync);
            this.Controls.Add(this.btn_Parallel);
            this.Controls.Add(this.btn_Async);
            this.Controls.Add(this.btn_Sync);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox_BreakfastProgress);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Let\'s Make Some Breakfast";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBox_BreakfastProgress;
        private Label label1;
        private Button btn_Sync;
        private Button btn_Async;
        private Button btn_Parallel;
        private RichTextBox richTextBox_BreakfastProgressSync;
        private RichTextBox richTextBox_BreakfastProgressAsync;
        private Label label2;
        private Label label3;
        private Button btn_runAll;

        public RichTextBox BreakfastProgress { get { return richTextBox_BreakfastProgress; } }
        public RichTextBox BreakfastProgressSync { get { return richTextBox_BreakfastProgressSync; } }
        public RichTextBox BreakfastProgressAsync { get { return richTextBox_BreakfastProgressAsync; } }
    }
}