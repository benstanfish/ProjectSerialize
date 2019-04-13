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
            this.ButtonRead = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ButtonWrite = new System.Windows.Forms.Button();
            this.ButtonSerialize = new System.Windows.Forms.Button();
            this.ButtonDeserialize = new System.Windows.Forms.Button();
            this.ButtonOpenFolder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonRead
            // 
            this.ButtonRead.Location = new System.Drawing.Point(464, 42);
            this.ButtonRead.Name = "ButtonRead";
            this.ButtonRead.Size = new System.Drawing.Size(75, 23);
            this.ButtonRead.TabIndex = 1;
            this.ButtonRead.Text = "Read";
            this.ButtonRead.UseVisualStyleBackColor = true;
            this.ButtonRead.Click += new System.EventHandler(this.ButtonRead_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.FirstName,
            this.LastName,
            this.Age});
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 425);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DataGridView1_RowPostPaint);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(463, 414);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(75, 23);
            this.ButtonClose.TabIndex = 3;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // ButtonWrite
            // 
            this.ButtonWrite.Location = new System.Drawing.Point(463, 13);
            this.ButtonWrite.Name = "ButtonWrite";
            this.ButtonWrite.Size = new System.Drawing.Size(75, 23);
            this.ButtonWrite.TabIndex = 4;
            this.ButtonWrite.Text = "Write";
            this.ButtonWrite.UseVisualStyleBackColor = true;
            this.ButtonWrite.Click += new System.EventHandler(this.ButtonWrite_Click);
            // 
            // ButtonSerialize
            // 
            this.ButtonSerialize.Location = new System.Drawing.Point(464, 71);
            this.ButtonSerialize.Name = "ButtonSerialize";
            this.ButtonSerialize.Size = new System.Drawing.Size(75, 23);
            this.ButtonSerialize.TabIndex = 5;
            this.ButtonSerialize.Text = "Serialize";
            this.ButtonSerialize.UseVisualStyleBackColor = true;
            this.ButtonSerialize.Click += new System.EventHandler(this.ButtonMakePersons_Click);
            // 
            // ButtonDeserialize
            // 
            this.ButtonDeserialize.Location = new System.Drawing.Point(464, 100);
            this.ButtonDeserialize.Name = "ButtonDeserialize";
            this.ButtonDeserialize.Size = new System.Drawing.Size(75, 23);
            this.ButtonDeserialize.TabIndex = 6;
            this.ButtonDeserialize.Text = "Deserialize";
            this.ButtonDeserialize.UseVisualStyleBackColor = true;
            this.ButtonDeserialize.Click += new System.EventHandler(this.ButtonDeserialize_Click);
            // 
            // ButtonOpenFolder
            // 
            this.ButtonOpenFolder.Location = new System.Drawing.Point(464, 130);
            this.ButtonOpenFolder.Name = "ButtonOpenFolder";
            this.ButtonOpenFolder.Size = new System.Drawing.Size(75, 23);
            this.ButtonOpenFolder.TabIndex = 7;
            this.ButtonOpenFolder.Text = "Open Folder";
            this.ButtonOpenFolder.UseVisualStyleBackColor = true;
            this.ButtonOpenFolder.Click += new System.EventHandler(this.ButtonOpenFolder_Click);
            // 
            // FormSerialize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 450);
            this.Controls.Add(this.ButtonOpenFolder);
            this.Controls.Add(this.ButtonDeserialize);
            this.Controls.Add(this.ButtonSerialize);
            this.Controls.Add(this.ButtonWrite);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ButtonRead);
            this.Name = "FormSerialize";
            this.ShowIcon = false;
            this.Text = "Project Serialize";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ButtonRead;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button ButtonWrite;
        private System.Windows.Forms.Button ButtonSerialize;
        private System.Windows.Forms.Button ButtonDeserialize;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.Button ButtonOpenFolder;
    }
}

