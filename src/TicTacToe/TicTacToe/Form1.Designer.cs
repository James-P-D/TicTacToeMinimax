namespace TicTacToe
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
            this.startButton = new System.Windows.Forms.Button();
            this.topInformationTextBox = new System.Windows.Forms.TextBox();
            this.topLeftButton = new System.Windows.Forms.Button();
            this.topCenterButton = new System.Windows.Forms.Button();
            this.topRightButton = new System.Windows.Forms.Button();
            this.middleRightButton = new System.Windows.Forms.Button();
            this.middleCenterButton = new System.Windows.Forms.Button();
            this.middleLeftButton = new System.Windows.Forms.Button();
            this.bottomRightButton = new System.Windows.Forms.Button();
            this.bottomCenterButton = new System.Windows.Forms.Button();
            this.bottomLeftButton = new System.Windows.Forms.Button();
            this.bottomInformationTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(255, 128);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(251, 63);
            this.startButton.TabIndex = 1;
            this.startButton.TabStop = false;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // topInformationTextBox
            // 
            this.topInformationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topInformationTextBox.Enabled = false;
            this.topInformationTextBox.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topInformationTextBox.Location = new System.Drawing.Point(12, 28);
            this.topInformationTextBox.Name = "topInformationTextBox";
            this.topInformationTextBox.Size = new System.Drawing.Size(760, 62);
            this.topInformationTextBox.TabIndex = 2;
            this.topInformationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // topLeftButton
            // 
            this.topLeftButton.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLeftButton.Location = new System.Drawing.Point(218, 238);
            this.topLeftButton.Name = "topLeftButton";
            this.topLeftButton.Size = new System.Drawing.Size(100, 100);
            this.topLeftButton.TabIndex = 3;
            this.topLeftButton.TabStop = false;
            this.topLeftButton.UseVisualStyleBackColor = true;
            this.topLeftButton.Click += new System.EventHandler(this.TopLeftButton_Click);
            // 
            // topCenterButton
            // 
            this.topCenterButton.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topCenterButton.Location = new System.Drawing.Point(324, 238);
            this.topCenterButton.Name = "topCenterButton";
            this.topCenterButton.Size = new System.Drawing.Size(100, 100);
            this.topCenterButton.TabIndex = 4;
            this.topCenterButton.TabStop = false;
            this.topCenterButton.UseVisualStyleBackColor = true;
            this.topCenterButton.Click += new System.EventHandler(this.TopCenterButton_Click);
            // 
            // topRightButton
            // 
            this.topRightButton.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topRightButton.Location = new System.Drawing.Point(430, 238);
            this.topRightButton.Name = "topRightButton";
            this.topRightButton.Size = new System.Drawing.Size(100, 100);
            this.topRightButton.TabIndex = 5;
            this.topRightButton.TabStop = false;
            this.topRightButton.UseVisualStyleBackColor = true;
            this.topRightButton.Click += new System.EventHandler(this.TopRightButton_Click);
            // 
            // middleRightButton
            // 
            this.middleRightButton.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleRightButton.Location = new System.Drawing.Point(430, 344);
            this.middleRightButton.Name = "middleRightButton";
            this.middleRightButton.Size = new System.Drawing.Size(100, 100);
            this.middleRightButton.TabIndex = 8;
            this.middleRightButton.TabStop = false;
            this.middleRightButton.UseVisualStyleBackColor = true;
            this.middleRightButton.Click += new System.EventHandler(this.MiddleRightButton_Click);
            // 
            // middleCenterButton
            // 
            this.middleCenterButton.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleCenterButton.Location = new System.Drawing.Point(324, 344);
            this.middleCenterButton.Name = "middleCenterButton";
            this.middleCenterButton.Size = new System.Drawing.Size(100, 100);
            this.middleCenterButton.TabIndex = 7;
            this.middleCenterButton.TabStop = false;
            this.middleCenterButton.UseVisualStyleBackColor = true;
            this.middleCenterButton.Click += new System.EventHandler(this.MiddleCenterButton_Click);
            // 
            // middleLeftButton
            // 
            this.middleLeftButton.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleLeftButton.Location = new System.Drawing.Point(218, 344);
            this.middleLeftButton.Name = "middleLeftButton";
            this.middleLeftButton.Size = new System.Drawing.Size(100, 100);
            this.middleLeftButton.TabIndex = 6;
            this.middleLeftButton.TabStop = false;
            this.middleLeftButton.UseVisualStyleBackColor = true;
            this.middleLeftButton.Click += new System.EventHandler(this.MiddleLeftButton_Click);
            // 
            // bottomRightButton
            // 
            this.bottomRightButton.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomRightButton.Location = new System.Drawing.Point(430, 450);
            this.bottomRightButton.Name = "bottomRightButton";
            this.bottomRightButton.Size = new System.Drawing.Size(100, 100);
            this.bottomRightButton.TabIndex = 11;
            this.bottomRightButton.TabStop = false;
            this.bottomRightButton.UseVisualStyleBackColor = true;
            this.bottomRightButton.Click += new System.EventHandler(this.BottomRightButton_Click);
            // 
            // bottomCenterButton
            // 
            this.bottomCenterButton.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomCenterButton.Location = new System.Drawing.Point(324, 450);
            this.bottomCenterButton.Name = "bottomCenterButton";
            this.bottomCenterButton.Size = new System.Drawing.Size(100, 100);
            this.bottomCenterButton.TabIndex = 10;
            this.bottomCenterButton.TabStop = false;
            this.bottomCenterButton.UseVisualStyleBackColor = true;
            this.bottomCenterButton.Click += new System.EventHandler(this.BottomCenterButton_Click);
            // 
            // bottomLeftButton
            // 
            this.bottomLeftButton.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomLeftButton.Location = new System.Drawing.Point(218, 450);
            this.bottomLeftButton.Name = "bottomLeftButton";
            this.bottomLeftButton.Size = new System.Drawing.Size(100, 100);
            this.bottomLeftButton.TabIndex = 9;
            this.bottomLeftButton.TabStop = false;
            this.bottomLeftButton.UseVisualStyleBackColor = true;
            this.bottomLeftButton.Click += new System.EventHandler(this.BottomLeftButton_Click);
            // 
            // bottomInformationTextBox
            // 
            this.bottomInformationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bottomInformationTextBox.Enabled = false;
            this.bottomInformationTextBox.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomInformationTextBox.Location = new System.Drawing.Point(12, 587);
            this.bottomInformationTextBox.Name = "bottomInformationTextBox";
            this.bottomInformationTextBox.Size = new System.Drawing.Size(760, 62);
            this.bottomInformationTextBox.TabIndex = 12;
            this.bottomInformationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.bottomInformationTextBox);
            this.Controls.Add(this.bottomRightButton);
            this.Controls.Add(this.bottomCenterButton);
            this.Controls.Add(this.bottomLeftButton);
            this.Controls.Add(this.middleRightButton);
            this.Controls.Add(this.middleCenterButton);
            this.Controls.Add(this.middleLeftButton);
            this.Controls.Add(this.topRightButton);
            this.Controls.Add(this.topCenterButton);
            this.Controls.Add(this.topLeftButton);
            this.Controls.Add(this.topInformationTextBox);
            this.Controls.Add(this.startButton);
            this.MinimumSize = new System.Drawing.Size(800, 700);
            this.Name = "Form1";
            this.Text = "Tic-Tac-Toe MiniMax";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox topInformationTextBox;
        private System.Windows.Forms.Button topLeftButton;
        private System.Windows.Forms.Button topCenterButton;
        private System.Windows.Forms.Button topRightButton;
        private System.Windows.Forms.Button middleRightButton;
        private System.Windows.Forms.Button middleCenterButton;
        private System.Windows.Forms.Button middleLeftButton;
        private System.Windows.Forms.Button bottomRightButton;
        private System.Windows.Forms.Button bottomCenterButton;
        private System.Windows.Forms.Button bottomLeftButton;
        private System.Windows.Forms.TextBox bottomInformationTextBox;
    }
}

