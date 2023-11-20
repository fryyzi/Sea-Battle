namespace menu
{
    partial class Game
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
            this.labelMyText = new System.Windows.Forms.Label();
            this.radioButtonHello = new System.Windows.Forms.RadioButton();
            this.labelTextNoMy = new System.Windows.Forms.Label();
            this.radioButtonMyWin = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // labelMyText
            // 
            this.labelMyText.AutoSize = true;
            this.labelMyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMyText.Location = new System.Drawing.Point(29, 406);
            this.labelMyText.Name = "labelMyText";
            this.labelMyText.Size = new System.Drawing.Size(0, 42);
            this.labelMyText.TabIndex = 0;
            // 
            // radioButtonHello
            // 
            this.radioButtonHello.AutoSize = true;
            this.radioButtonHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonHello.Location = new System.Drawing.Point(856, 12);
            this.radioButtonHello.Name = "radioButtonHello";
            this.radioButtonHello.Size = new System.Drawing.Size(122, 36);
            this.radioButtonHello.TabIndex = 3;
            this.radioButtonHello.TabStop = true;
            this.radioButtonHello.Text = "Привіт";
            this.radioButtonHello.UseVisualStyleBackColor = true;
            this.radioButtonHello.Visible = false;
            this.radioButtonHello.CheckedChanged += new System.EventHandler(this.radioButtonHello_CheckedChanged);
            // 
            // labelTextNoMy
            // 
            this.labelTextNoMy.AutoSize = true;
            this.labelTextNoMy.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextNoMy.Location = new System.Drawing.Point(555, 406);
            this.labelTextNoMy.Name = "labelTextNoMy";
            this.labelTextNoMy.Size = new System.Drawing.Size(0, 42);
            this.labelTextNoMy.TabIndex = 4;
            // 
            // radioButtonMyWin
            // 
            this.radioButtonMyWin.AutoSize = true;
            this.radioButtonMyWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonMyWin.Location = new System.Drawing.Point(856, 74);
            this.radioButtonMyWin.Name = "radioButtonMyWin";
            this.radioButtonMyWin.Size = new System.Drawing.Size(225, 36);
            this.radioButtonMyWin.TabIndex = 5;
            this.radioButtonMyWin.TabStop = true;
            this.radioButtonMyWin.Text = "Я тебе виграю";
            this.radioButtonMyWin.UseVisualStyleBackColor = true;
            this.radioButtonMyWin.Visible = false;
            this.radioButtonMyWin.CheckedChanged += new System.EventHandler(this.radioButtonMyWin_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton3.Location = new System.Drawing.Point(856, 136);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(187, 36);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Мінус один ";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Visible = false;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1093, 544);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButtonMyWin);
            this.Controls.Add(this.labelTextNoMy);
            this.Controls.Add(this.radioButtonHello);
            this.Controls.Add(this.labelMyText);
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMyText;
        private System.Windows.Forms.RadioButton radioButtonHello;
        private System.Windows.Forms.Label labelTextNoMy;
        private System.Windows.Forms.RadioButton radioButtonMyWin;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}