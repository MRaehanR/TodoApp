
namespace TodoApp
{
    partial class item_list
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
            this.check = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // check
            // 
            this.check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.check.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.check.Checked = true;
            this.check.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check.ForeColor = System.Drawing.Color.White;
            this.check.Location = new System.Drawing.Point(16, 18);
            this.check.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(20, 20);
            this.check.TabIndex = 0;
            this.check.OnChange += new System.EventHandler(this.check_OnChange);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(57, 14);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(95, 24);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Todo Item";
            this.lbl.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // item_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.check);
            this.Name = "item_list";
            this.Size = new System.Drawing.Size(476, 55);
            this.Load += new System.EventHandler(this.item_list_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCheckbox check;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl;
    }
}
