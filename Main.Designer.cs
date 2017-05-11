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
            this.SaveRenderButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openVoxelmapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CamXBox = new System.Windows.Forms.NumericUpDown();
            this.CamYBox = new System.Windows.Forms.NumericUpDown();
            this.CamZBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PitchBox = new System.Windows.Forms.NumericUpDown();
            this.YawBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.RenderFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrthographicSizeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BitmapHeightBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BitmapWidthBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CamXBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CamYBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CamZBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PitchBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YawBox)).BeginInit();
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
            // SaveRenderButton
            // 
            this.SaveRenderButton.Location = new System.Drawing.Point(13, 427);
            this.SaveRenderButton.Name = "SaveRenderButton";
            this.SaveRenderButton.Size = new System.Drawing.Size(146, 23);
            this.SaveRenderButton.TabIndex = 10;
            this.SaveRenderButton.Text = "Save Render";
            this.SaveRenderButton.UseVisualStyleBackColor = true;
            this.SaveRenderButton.Click += new System.EventHandler(this.SaveRenderButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(557, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openVoxelmapToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openVoxelmapToolStripMenuItem
            // 
            this.openVoxelmapToolStripMenuItem.Name = "openVoxelmapToolStripMenuItem";
            this.openVoxelmapToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.openVoxelmapToolStripMenuItem.Text = "Open Voxelmap";
            this.openVoxelmapToolStripMenuItem.Click += new System.EventHandler(this.openVoxelmapToolStripMenuItem_Click);
            // 
            // CamXBox
            // 
            this.CamXBox.DecimalPlaces = 3;
            this.CamXBox.Location = new System.Drawing.Point(13, 229);
            this.CamXBox.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.CamXBox.Name = "CamXBox";
            this.CamXBox.Size = new System.Drawing.Size(38, 20);
            this.CamXBox.TabIndex = 12;
            // 
            // CamYBox
            // 
            this.CamYBox.DecimalPlaces = 3;
            this.CamYBox.Location = new System.Drawing.Point(58, 229);
            this.CamYBox.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.CamYBox.Name = "CamYBox";
            this.CamYBox.Size = new System.Drawing.Size(38, 20);
            this.CamYBox.TabIndex = 13;
            // 
            // CamZBox
            // 
            this.CamZBox.DecimalPlaces = 3;
            this.CamZBox.Location = new System.Drawing.Point(110, 229);
            this.CamZBox.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.CamZBox.Name = "CamZBox";
            this.CamZBox.Size = new System.Drawing.Size(38, 20);
            this.CamZBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Camera Position";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Pitch";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Yaw";
            // 
            // PitchBox
            // 
            this.PitchBox.DecimalPlaces = 2;
            this.PitchBox.Location = new System.Drawing.Point(12, 281);
            this.PitchBox.Maximum = new decimal(new int[] {
            720,
            0,
            0,
            0});
            this.PitchBox.Minimum = new decimal(new int[] {
            720,
            0,
            0,
            -2147483648});
            this.PitchBox.Name = "PitchBox";
            this.PitchBox.Size = new System.Drawing.Size(146, 20);
            this.PitchBox.TabIndex = 18;
            // 
            // YawBox
            // 
            this.YawBox.DecimalPlaces = 2;
            this.YawBox.Location = new System.Drawing.Point(12, 320);
            this.YawBox.Maximum = new decimal(new int[] {
            720,
            0,
            0,
            0});
            this.YawBox.Minimum = new decimal(new int[] {
            720,
            0,
            0,
            -2147483648});
            this.YawBox.Name = "YawBox";
            this.YawBox.Size = new System.Drawing.Size(146, 20);
            this.YawBox.TabIndex = 19;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 461);
            this.Controls.Add(this.YawBox);
            this.Controls.Add(this.PitchBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CamZBox);
            this.Controls.Add(this.CamYBox);
            this.Controls.Add(this.CamXBox);
            this.Controls.Add(this.SaveRenderButton);
            this.Controls.Add(this.MIPCheckBox);
            this.Controls.Add(this.RenderButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BitmapWidthBox);
            this.Controls.Add(this.BitmapHeightBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OrthographicSizeBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RenderFrame);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Voxel Renderer";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RenderFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrthographicSizeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BitmapHeightBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BitmapWidthBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CamXBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CamYBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CamZBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PitchBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YawBox)).EndInit();
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
        private System.Windows.Forms.Button SaveRenderButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openVoxelmapToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown CamXBox;
        private System.Windows.Forms.NumericUpDown CamYBox;
        private System.Windows.Forms.NumericUpDown CamZBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown PitchBox;
        private System.Windows.Forms.NumericUpDown YawBox;
    }
}

