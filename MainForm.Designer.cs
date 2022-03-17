
namespace HostModifier
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btLocal = new System.Windows.Forms.Button();
            this.btRemoto = new System.Windows.Forms.Button();
            this.pbLAN = new System.Windows.Forms.PictureBox();
            this.pbCloud = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLAN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloud)).BeginInit();
            this.SuspendLayout();
            // 
            // btLocal
            // 
            this.btLocal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLocal.Location = new System.Drawing.Point(12, 12);
            this.btLocal.Name = "btLocal";
            this.btLocal.Size = new System.Drawing.Size(194, 57);
            this.btLocal.TabIndex = 0;
            this.btLocal.Text = "ENTORNO LOCAL";
            this.btLocal.UseVisualStyleBackColor = false;
            this.btLocal.Click += new System.EventHandler(this.btLocal_Click);
            // 
            // btRemoto
            // 
            this.btRemoto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btRemoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRemoto.Location = new System.Drawing.Point(12, 80);
            this.btRemoto.Name = "btRemoto";
            this.btRemoto.Size = new System.Drawing.Size(194, 57);
            this.btRemoto.TabIndex = 1;
            this.btRemoto.Text = "ENTORNO REMOTO";
            this.btRemoto.UseVisualStyleBackColor = false;
            this.btRemoto.Click += new System.EventHandler(this.btRemoto_Click);
            // 
            // pbLAN
            // 
            this.pbLAN.Image = global::HostModifier.Properties.Resources.network_lan;
            this.pbLAN.Location = new System.Drawing.Point(212, 12);
            this.pbLAN.Name = "pbLAN";
            this.pbLAN.Size = new System.Drawing.Size(72, 57);
            this.pbLAN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLAN.TabIndex = 2;
            this.pbLAN.TabStop = false;
            // 
            // pbCloud
            // 
            this.pbCloud.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbCloud.Image = global::HostModifier.Properties.Resources.cloud;
            this.pbCloud.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbCloud.InitialImage")));
            this.pbCloud.Location = new System.Drawing.Point(212, 80);
            this.pbCloud.Name = "pbCloud";
            this.pbCloud.Size = new System.Drawing.Size(72, 57);
            this.pbCloud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCloud.TabIndex = 3;
            this.pbCloud.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(290, 143);
            this.Controls.Add(this.pbCloud);
            this.Controls.Add(this.pbLAN);
            this.Controls.Add(this.btRemoto);
            this.Controls.Add(this.btLocal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "HostSelector";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbLAN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btLocal;
        private System.Windows.Forms.Button btRemoto;
        private System.Windows.Forms.PictureBox pbLAN;
        private System.Windows.Forms.PictureBox pbCloud;
    }
}

