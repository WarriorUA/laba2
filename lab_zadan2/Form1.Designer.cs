namespace lab_zadan2
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
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.richTextBoxArray = new System.Windows.Forms.RichTextBox();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.labelN = new System.Windows.Forms.Label();
            this.labelArray = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonGetResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(17, 29);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(169, 20);
            this.textBoxN.TabIndex = 0;
            // 
            // richTextBoxArray
            // 
            this.richTextBoxArray.Location = new System.Drawing.Point(16, 68);
            this.richTextBoxArray.Name = "richTextBoxArray";
            this.richTextBoxArray.Size = new System.Drawing.Size(170, 214);
            this.richTextBoxArray.TabIndex = 1;
            this.richTextBoxArray.Text = "";
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.Location = new System.Drawing.Point(192, 29);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.Size = new System.Drawing.Size(180, 283);
            this.richTextBoxResult.TabIndex = 2;
            this.richTextBoxResult.Text = "";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(13, 13);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(18, 13);
            this.labelN.TabIndex = 3;
            this.labelN.Text = "N:";
            // 
            // labelArray
            // 
            this.labelArray.AutoSize = true;
            this.labelArray.Location = new System.Drawing.Point(13, 52);
            this.labelArray.Name = "labelArray";
            this.labelArray.Size = new System.Drawing.Size(34, 13);
            this.labelArray.TabIndex = 4;
            this.labelArray.Text = "Array:";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(189, 9);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(40, 13);
            this.labelResult.TabIndex = 5;
            this.labelResult.Text = "Result:";
            // 
            // buttonGetResult
            // 
            this.buttonGetResult.Location = new System.Drawing.Point(13, 288);
            this.buttonGetResult.Name = "buttonGetResult";
            this.buttonGetResult.Size = new System.Drawing.Size(75, 23);
            this.buttonGetResult.TabIndex = 6;
            this.buttonGetResult.Text = "Get result";
            this.buttonGetResult.UseVisualStyleBackColor = true;
            this.buttonGetResult.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 325);
            this.Controls.Add(this.buttonGetResult);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelArray);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.richTextBoxResult);
            this.Controls.Add(this.richTextBoxArray);
            this.Controls.Add(this.textBoxN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.RichTextBox richTextBoxArray;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelArray;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonGetResult;
    }
}

