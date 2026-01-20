namespace Task1_Primes_Async
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
            btnStart = new Button();
            btnStop = new Button();
            txtLower = new TextBox();
            txtUpper = new TextBox();
            listBoxPrimes = new ListBox();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(234, 326);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(150, 46);
            btnStart.TabIndex = 0;
            btnStart.Text = "Старт";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(407, 326);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(150, 46);
            btnStop.TabIndex = 1;
            btnStop.Text = "Стоп";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // txtLower
            // 
            txtLower.Location = new Point(497, 43);
            txtLower.Name = "txtLower";
            txtLower.PlaceholderText = "Нижня межа";
            txtLower.Size = new Size(266, 39);
            txtLower.TabIndex = 2;
            // 
            // txtUpper
            // 
            txtUpper.Location = new Point(31, 43);
            txtUpper.Name = "txtUpper";
            txtUpper.PlaceholderText = "Верхня межа";
            txtUpper.Size = new Size(256, 39);
            txtUpper.TabIndex = 3;
            // 
            // listBoxPrimes
            // 
            listBoxPrimes.FormattingEnabled = true;
            listBoxPrimes.Location = new Point(271, 128);
            listBoxPrimes.Name = "listBoxPrimes";
            listBoxPrimes.Size = new Size(240, 164);
            listBoxPrimes.TabIndex = 4;
            listBoxPrimes.SelectedIndexChanged += listBoxPrimes_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxPrimes);
            Controls.Add(txtUpper);
            Controls.Add(txtLower);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Button btnStop;
        private TextBox txtLower;
        private TextBox txtUpper;
        private ListBox listBoxPrimes;
    }
}
