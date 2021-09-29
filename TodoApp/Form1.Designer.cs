
namespace TodoApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.text = new ns1.BunifuMaterialTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 74);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(185, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "To Do List App";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(455, 496);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(71, 44);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // text
            // 
            this.text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text.HintForeColor = System.Drawing.Color.Empty;
            this.text.HintText = "";
            this.text.isPassword = false;
            this.text.LineFocusedColor = System.Drawing.Color.Blue;
            this.text.LineIdleColor = System.Drawing.Color.Gray;
            this.text.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.text.LineThickness = 3;
            this.text.Location = new System.Drawing.Point(13, 496);
            this.text.Margin = new System.Windows.Forms.Padding(4);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(435, 44);
            this.text.TabIndex = 3;
            this.text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Location = new System.Drawing.Point(13, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(513, 399);
            this.panel2.TabIndex = 4;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel2;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 553);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.text);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private ns1.BunifuMaterialTextbox text;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}

