namespace MegaDesk_Lantukh
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.AddQuoteButton = new System.Windows.Forms.Button();
            this.ViewQuotesButton = new System.Windows.Forms.Button();
            this.SearchQuotesButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddQuoteButton
            // 
            this.AddQuoteButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AddQuoteButton.Font = new System.Drawing.Font("Roboto Mono for Powerline", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddQuoteButton.ForeColor = System.Drawing.Color.Maroon;
            this.AddQuoteButton.Location = new System.Drawing.Point(23, 23);
            this.AddQuoteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddQuoteButton.Name = "AddQuoteButton";
            this.AddQuoteButton.Size = new System.Drawing.Size(165, 30);
            this.AddQuoteButton.TabIndex = 0;
            this.AddQuoteButton.Text = "&Add Quote";
            this.AddQuoteButton.UseVisualStyleBackColor = false;
            this.AddQuoteButton.Click += new System.EventHandler(this.AddQuoteButton_Click);
            // 
            // ViewQuotesButton
            // 
            this.ViewQuotesButton.Font = new System.Drawing.Font("Roboto Mono for Powerline", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewQuotesButton.ForeColor = System.Drawing.Color.Maroon;
            this.ViewQuotesButton.Location = new System.Drawing.Point(23, 68);
            this.ViewQuotesButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ViewQuotesButton.Name = "ViewQuotesButton";
            this.ViewQuotesButton.Size = new System.Drawing.Size(165, 30);
            this.ViewQuotesButton.TabIndex = 1;
            this.ViewQuotesButton.Text = "&View Quote";
            this.ViewQuotesButton.UseVisualStyleBackColor = true;
            this.ViewQuotesButton.Click += new System.EventHandler(this.ViewQuotesButton_Click);
            // 
            // SearchQuotesButton
            // 
            this.SearchQuotesButton.Font = new System.Drawing.Font("Roboto Mono for Powerline", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchQuotesButton.ForeColor = System.Drawing.Color.Maroon;
            this.SearchQuotesButton.Location = new System.Drawing.Point(23, 114);
            this.SearchQuotesButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchQuotesButton.Name = "SearchQuotesButton";
            this.SearchQuotesButton.Size = new System.Drawing.Size(165, 30);
            this.SearchQuotesButton.TabIndex = 2;
            this.SearchQuotesButton.Text = "&Search Quotes";
            this.SearchQuotesButton.UseVisualStyleBackColor = true;
            this.SearchQuotesButton.Click += new System.EventHandler(this.SearchQuotesButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Roboto Mono for Powerline", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.Maroon;
            this.ExitButton.Location = new System.Drawing.Point(23, 160);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(165, 30);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SearchQuotesButton);
            this.Controls.Add(this.ViewQuotesButton);
            this.Controls.Add(this.AddQuoteButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddQuoteButton;
        private System.Windows.Forms.Button ViewQuotesButton;
        private System.Windows.Forms.Button SearchQuotesButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

