namespace ProjectSerialize
{
    partial class FormSerialize
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
            this.ButtonSerialize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonSerialize
            // 
            this.ButtonSerialize.Location = new System.Drawing.Point(631, 35);
            this.ButtonSerialize.Name = "ButtonSerialize";
            this.ButtonSerialize.Size = new System.Drawing.Size(75, 23);
            this.ButtonSerialize.TabIndex = 0;
            this.ButtonSerialize.Text = "Serialize";
            this.ButtonSerialize.UseVisualStyleBackColor = true;
            // 
            // FormSerialize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonSerialize);
            this.Name = "FormSerialize";
            this.ShowIcon = false;
            this.Text = "Project Serialize";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonSerialize;
    }
}

