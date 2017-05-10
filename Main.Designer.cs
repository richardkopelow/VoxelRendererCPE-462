namespace VoxelRendererCPE_462
{
    partial class Main
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
            this.RenderFrame = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OrthographicSizeBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.BitmapHeightBox = new System.Windows.Forms.NumericUpDown();
            this.BitmapWidthBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.RenderButton = new System.Windows.Forms.Button();
            this.MIPCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.RenderFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrthographicSizeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BitmapHeightBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BitmapWidthBox)).BeginInit();
            this.SuspendLayout();
            // 
            // RenderFrame
            // 
            this.RenderFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RenderFrame.Location = new System.Drawing.Point(165, 40);
            this.RenderFrame.Name = "RenderFrame";
            this.RenderFrame.Size = new System.Drawing.Size(357, 382);
            this.RenderFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RenderFrame.TabIndex = 0;
            this.RenderFrame.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Orthographic Size";
            // 
            // OrthographicSizeBox
            // 
            this.OrthographicSizeBox.DecimalPlaces = 2;
            this.OrthographicSizeBox.Location = new System.Drawing.Point(13, 57);
            this.OrthographicSizeBox.Name = "OrthographicSizeBox";
            this.OrthographicSizeBox.Size = new System.Drawing.Size(146, 20);
            this.OrthographicSizeBox.TabIndex = 3;
            this.OrthographicSizeBox.ValueChanged += new System.EventHandler(this.OrthographicSizeBox_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Height";
            // 
            // BitmapHeightBox
            // 
            this.BitmapHeightBox.Location = new System.Drawing.Point(13, 101);
            this.BitmapHeightBox.Maximum = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            this.BitmapHeightBox.Name = "BitmapHeightBox";
            this.BitmapHeightBox.Size = new System.Drawing.Size(146, 20);
            this.BitmapHeightBox.TabIndex = 5;
            this.BitmapHeightBox.Value = new decimal(new int[] {
            256,
            0,
            0,
            0});
            // 
            // BitmapWidthBox
            // 
            this.BitmapWidthBox.Location = new System.Drawing.Point(13, 144);
            this.BitmapWidthBox.Maximum = new decimal(new int[] {
            1080,
            0,
            0,
            0});
            this.BitmapWidthBox.Name = "BitmapWidthBox";
            this.BitmapWidthBox.Size = new System.Drawing.Size(146, 20);
            this.BitmapWidthBox.TabIndex = 6;
            this.BitmapWidthBox.Value = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.BitmapWidthBox.ValueChanged += new System.EventHandler(this.BitmapResolutionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Width";
            // 
            // RenderButton
            // 
            this.RenderButton.Location = new System.Drawing.Point(13, 398);
            this.RenderButton.Name = "RenderButton";
            this.RenderButton.Size = new System.Drawing.Size(146, 23);
            this.RenderButton.TabIndex = 8;
            this.RenderButton.Text = "Render";
            this.RenderButton.UseVisualStyleBackColor = true;
            this.RenderButton.Click += new System.EventHandler(this.RenderButton_Click);
            // 
            // MIPCheckBox
            // 
            this.MIPCheckBox.AutoSize = true;
            this.MIPCheckBox.Location = new System.Drawing.Point(13, 171);
            this.MIPCheckBox.Name = "MIPCheckBox";
            this.MIPCheckBox.Size = new System.Drawing.Size(83, 17);
            this.MIPCheckBox.TabIndex = 9;
            this.MIPCheckBox.Text = "MIP Render";
            this.MIPCheckBox.UseVisualStyleBackColor = true;
            this.MIPCheckBox.CheckedChanged += new System.EventHandler(this.MIPCheckBox_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 461);
            this.Controls.Add(this.MIPCheckBox);
            this.Controls.Add(this.RenderButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BitmapWidthBox);
            this.Controls.Add(this.BitmapHeightBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OrthographicSizeBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RenderFrame);
            this.Name = "Main";
            this.Text = "Voxel Renderer";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RenderFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrthographicSizeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BitmapHeightBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BitmapWidthBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox RenderFrame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown OrthographicSizeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown BitmapHeightBox;
        private System.Windows.Forms.NumericUpDown BitmapWidthBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RenderButton;
        private System.Windows.Forms.CheckBox MIPCheckBox;
    }
}

