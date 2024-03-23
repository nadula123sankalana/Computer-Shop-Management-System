
namespace Project
{
    partial class HomeControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExploreNow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExploreNow
            // 
            this.btnExploreNow.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExploreNow.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExploreNow.FlatAppearance.BorderSize = 5;
            this.btnExploreNow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnExploreNow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnExploreNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExploreNow.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExploreNow.ForeColor = System.Drawing.Color.White;
            this.btnExploreNow.Location = new System.Drawing.Point(77, 228);
            this.btnExploreNow.Margin = new System.Windows.Forms.Padding(4);
            this.btnExploreNow.Name = "btnExploreNow";
            this.btnExploreNow.Size = new System.Drawing.Size(265, 66);
            this.btnExploreNow.TabIndex = 7;
            this.btnExploreNow.Text = "Explore Now ->";
            this.btnExploreNow.UseVisualStyleBackColor = false;
            this.btnExploreNow.Click += new System.EventHandler(this.btnExploreNow_Click);
            // 
            // HomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.A_V_A_COMPUTERS__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnExploreNow);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomeControl";
            this.Size = new System.Drawing.Size(883, 491);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExploreNow;
    }
}
