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
            this.components = new System.ComponentModel.Container();
            this.RenderFrame = new System.Windows.Forms.PictureBox();
            this.RenderClock = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RenderFrame)).BeginInit();
            this.SuspendLayout();
            // 
            // RenderFrame
            // 
            this.RenderFrame.Location = new System.Drawing.Point(118, 40);
            this.RenderFrame.Name = "RenderFrame";
            this.RenderFrame.Size = new System.Drawing.Size(404, 382);
            this.RenderFrame.TabIndex = 0;
            this.RenderFrame.TabStop = false;
            // 
            // RenderClock
            // 
            this.RenderClock.Enabled = true;
            this.RenderClock.Interval = 16;
            this.RenderClock.Tick += new System.EventHandler(this.RenderClock_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 461);
            this.Controls.Add(this.RenderFrame);
            this.Name = "Main";
            this.Text = "Voxel Renderer";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RenderFrame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox RenderFrame;
        private System.Windows.Forms.Timer RenderClock;
    }
}

