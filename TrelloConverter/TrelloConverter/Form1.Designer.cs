namespace TrelloConverter
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.VolumeButton = new System.Windows.Forms.Button();
            this.MilliliButton = new System.Windows.Forms.Button();
            this.LitersButton = new System.Windows.Forms.Button();
            this.WidthInput = new System.Windows.Forms.TextBox();
            this.HeigthInput = new System.Windows.Forms.TextBox();
            this.LengthInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ConvertAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VolumeButton
            // 
            this.VolumeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VolumeButton.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VolumeButton.Location = new System.Drawing.Point(88, 295);
            this.VolumeButton.Name = "VolumeButton";
            this.VolumeButton.Size = new System.Drawing.Size(75, 37);
            this.VolumeButton.TabIndex = 0;
            this.VolumeButton.Text = "Volume";
            this.VolumeButton.UseVisualStyleBackColor = true;
            this.VolumeButton.Click += new System.EventHandler(this.VolumeButton_Click);
            // 
            // MilliliButton
            // 
            this.MilliliButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MilliliButton.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MilliliButton.Location = new System.Drawing.Point(250, 295);
            this.MilliliButton.Name = "MilliliButton";
            this.MilliliButton.Size = new System.Drawing.Size(107, 37);
            this.MilliliButton.TabIndex = 1;
            this.MilliliButton.Text = "Milliliters";
            this.MilliliButton.UseVisualStyleBackColor = true;
            this.MilliliButton.Click += new System.EventHandler(this.MilliliButton_Click);
            // 
            // LitersButton
            // 
            this.LitersButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LitersButton.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LitersButton.Location = new System.Drawing.Point(169, 295);
            this.LitersButton.Name = "LitersButton";
            this.LitersButton.Size = new System.Drawing.Size(75, 37);
            this.LitersButton.TabIndex = 2;
            this.LitersButton.Text = "Liters";
            this.LitersButton.UseVisualStyleBackColor = true;
            this.LitersButton.Click += new System.EventHandler(this.LitersButton_Click);
            // 
            // WidthInput
            // 
            this.WidthInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WidthInput.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WidthInput.Location = new System.Drawing.Point(204, 214);
            this.WidthInput.Name = "WidthInput";
            this.WidthInput.Size = new System.Drawing.Size(100, 25);
            this.WidthInput.TabIndex = 3;
            // 
            // HeigthInput
            // 
            this.HeigthInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeigthInput.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeigthInput.Location = new System.Drawing.Point(204, 245);
            this.HeigthInput.Name = "HeigthInput";
            this.HeigthInput.Size = new System.Drawing.Size(100, 25);
            this.HeigthInput.TabIndex = 4;
            // 
            // LengthInput
            // 
            this.LengthInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LengthInput.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LengthInput.Location = new System.Drawing.Point(204, 183);
            this.LengthInput.Name = "LengthInput";
            this.LengthInput.Size = new System.Drawing.Size(100, 25);
            this.LengthInput.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(310, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(310, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(310, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Heigth";
            // 
            // ConvertAllButton
            // 
            this.ConvertAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ConvertAllButton.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConvertAllButton.Location = new System.Drawing.Point(363, 295);
            this.ConvertAllButton.Name = "ConvertAllButton";
            this.ConvertAllButton.Size = new System.Drawing.Size(106, 37);
            this.ConvertAllButton.TabIndex = 9;
            this.ConvertAllButton.Text = "Convert All";
            this.ConvertAllButton.UseVisualStyleBackColor = true;
            this.ConvertAllButton.Click += new System.EventHandler(this.ConvertAllButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 485);
            this.Controls.Add(this.ConvertAllButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LengthInput);
            this.Controls.Add(this.HeigthInput);
            this.Controls.Add(this.WidthInput);
            this.Controls.Add(this.LitersButton);
            this.Controls.Add(this.MilliliButton);
            this.Controls.Add(this.VolumeButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VolumeButton;
        private System.Windows.Forms.Button MilliliButton;
        private System.Windows.Forms.Button LitersButton;
        private System.Windows.Forms.TextBox WidthInput;
        private System.Windows.Forms.TextBox HeigthInput;
        private System.Windows.Forms.TextBox LengthInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ConvertAllButton;
    }
}

