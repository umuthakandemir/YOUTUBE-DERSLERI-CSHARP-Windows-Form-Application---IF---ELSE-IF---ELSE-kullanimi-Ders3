namespace Ders3_İf_else
{
    partial class Form1
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
            btnclick = new Button();
            lblsonuc = new Label();
            txtgirdi = new TextBox();
            SuspendLayout();
            // 
            // btnclick
            // 
            btnclick.Location = new Point(103, 218);
            btnclick.Name = "btnclick";
            btnclick.Size = new Size(140, 23);
            btnclick.TabIndex = 0;
            btnclick.Text = "button1";
            btnclick.UseVisualStyleBackColor = true;
            btnclick.Click += btnclick_Click;
            // 
            // lblsonuc
            // 
            lblsonuc.AutoSize = true;
            lblsonuc.Location = new Point(154, 128);
            lblsonuc.Name = "lblsonuc";
            lblsonuc.Size = new Size(38, 15);
            lblsonuc.TabIndex = 1;
            lblsonuc.Text = "label1";
            // 
            // txtgirdi
            // 
            txtgirdi.Location = new Point(103, 169);
            txtgirdi.Name = "txtgirdi";
            txtgirdi.Size = new Size(140, 23);
            txtgirdi.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 377);
            Controls.Add(txtgirdi);
            Controls.Add(lblsonuc);
            Controls.Add(btnclick);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnclick;
        private Label lblsonuc;
        private TextBox txtgirdi;
    }
}