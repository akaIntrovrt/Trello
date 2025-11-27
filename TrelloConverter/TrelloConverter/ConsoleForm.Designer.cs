namespace TrelloConverter
{
    partial class ConsoleForm
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
            this.RichBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // RichBox
            // 
            this.RichBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.RichBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RichBox.ForeColor = System.Drawing.SystemColors.Info;
            this.RichBox.Location = new System.Drawing.Point(-2, -1);
            this.RichBox.Name = "RichBox";
            this.RichBox.Size = new System.Drawing.Size(383, 282);
            this.RichBox.TabIndex = 0;
            this.RichBox.Text = "";
            this.RichBox.TextChanged += new System.EventHandler(this.RichBox_TextChanged);
            // 
            // ConsoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 280);
            this.Controls.Add(this.RichBox);
            this.Name = "ConsoleForm";
            this.Text = "ConsoleForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RichBox;
    }
}