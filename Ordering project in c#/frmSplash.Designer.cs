namespace Ordering_System
{
    partial class frmSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.tmrProgress = new System.Windows.Forms.Timer(this.components);
            this.pnlProgressFore = new System.Windows.Forms.Panel();
            this.pnlProgressBack = new System.Windows.Forms.Panel();
            this.lblSplash2 = new System.Windows.Forms.Label();
            this.picSplash = new System.Windows.Forms.PictureBox();
            this.lblSplash = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlProgressBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSplash)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrProgress
            // 
            this.tmrProgress.Enabled = true;
            this.tmrProgress.Interval = 15;
            this.tmrProgress.Tick += new System.EventHandler(this.tmrProgress_Tick);
            // 
            // pnlProgressFore
            // 
            this.pnlProgressFore.BackColor = System.Drawing.Color.Lime;
            this.pnlProgressFore.Location = new System.Drawing.Point(0, 0);
            this.pnlProgressFore.Name = "pnlProgressFore";
            this.pnlProgressFore.Size = new System.Drawing.Size(33, 21);
            this.pnlProgressFore.TabIndex = 11;
            // 
            // pnlProgressBack
            // 
            this.pnlProgressBack.BackColor = System.Drawing.Color.ForestGreen;
            this.pnlProgressBack.Controls.Add(this.pnlProgressFore);
            this.pnlProgressBack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlProgressBack.Location = new System.Drawing.Point(0, 281);
            this.pnlProgressBack.Name = "pnlProgressBack";
            this.pnlProgressBack.Size = new System.Drawing.Size(529, 21);
            this.pnlProgressBack.TabIndex = 10;
            // 
            // lblSplash2
            // 
            this.lblSplash2.Font = new System.Drawing.Font("Raleway", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSplash2.Location = new System.Drawing.Point(332, 146);
            this.lblSplash2.Name = "lblSplash2";
            this.lblSplash2.Size = new System.Drawing.Size(143, 36);
            this.lblSplash2.TabIndex = 9;
            this.lblSplash2.Text = "STORE";
            // 
            // picSplash
            // 
            this.picSplash.Image = ((System.Drawing.Image)(resources.GetObject("picSplash.Image")));
            this.picSplash.Location = new System.Drawing.Point(12, 12);
            this.picSplash.Name = "picSplash";
            this.picSplash.Size = new System.Drawing.Size(260, 260);
            this.picSplash.TabIndex = 6;
            this.picSplash.TabStop = false;
            // 
            // lblSplash
            // 
            this.lblSplash.Font = new System.Drawing.Font("Raleway", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSplash.Location = new System.Drawing.Point(294, 101);
            this.lblSplash.Name = "lblSplash";
            this.lblSplash.Size = new System.Drawing.Size(212, 36);
            this.lblSplash.TabIndex = 8;
            this.lblSplash.Text = "ORDERING";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 7;
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(529, 302);
            this.Controls.Add(this.pnlProgressBack);
            this.Controls.Add(this.lblSplash2);
            this.Controls.Add(this.picSplash);
            this.Controls.Add(this.lblSplash);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.pnlProgressBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSplash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrProgress;
        private System.Windows.Forms.Panel pnlProgressFore;
        private System.Windows.Forms.Panel pnlProgressBack;
        private System.Windows.Forms.Label lblSplash2;
        private System.Windows.Forms.PictureBox picSplash;
        private System.Windows.Forms.Label lblSplash;
        private System.Windows.Forms.Label label1;
    }
}

