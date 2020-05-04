namespace File_Counter
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
            this.label1 = new System.Windows.Forms.Label();
            this.DirectoryPath = new System.Windows.Forms.TextBox();
            this.buttonPath = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FilesCount = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonCount = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchPattern = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Путь к директории:";
            // 
            // DirectoryPath
            // 
            this.DirectoryPath.Location = new System.Drawing.Point(120, 28);
            this.DirectoryPath.Name = "DirectoryPath";
            this.DirectoryPath.Size = new System.Drawing.Size(482, 20);
            this.DirectoryPath.TabIndex = 1;
            // 
            // buttonPath
            // 
            this.buttonPath.Location = new System.Drawing.Point(608, 28);
            this.buttonPath.Name = "buttonPath";
            this.buttonPath.Size = new System.Drawing.Size(19, 19);
            this.buttonPath.TabIndex = 2;
            this.buttonPath.UseVisualStyleBackColor = true;
            this.buttonPath.Click += new System.EventHandler(this.buttonPath_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество нужных файлов:";
            // 
            // FilesCount
            // 
            this.FilesCount.Location = new System.Drawing.Point(169, 83);
            this.FilesCount.Name = "FilesCount";
            this.FilesCount.Size = new System.Drawing.Size(93, 20);
            this.FilesCount.TabIndex = 4;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(552, 110);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCount
            // 
            this.buttonCount.Location = new System.Drawing.Point(451, 110);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(75, 23);
            this.buttonCount.TabIndex = 6;
            this.buttonCount.Text = "Считать!";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Паттерн поиска:";
            // 
            // SearchPattern
            // 
            this.SearchPattern.Location = new System.Drawing.Point(120, 55);
            this.SearchPattern.Name = "SearchPattern";
            this.SearchPattern.Size = new System.Drawing.Size(196, 20);
            this.SearchPattern.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 145);
            this.Controls.Add(this.SearchPattern);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCount);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.FilesCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonPath);
            this.Controls.Add(this.DirectoryPath);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "FileCounter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DirectoryPath;
        private System.Windows.Forms.Button buttonPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FilesCount;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SearchPattern;
    }
}

