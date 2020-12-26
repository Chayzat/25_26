
namespace FileInformaation
{
    partial class mainForm
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
            this.tbInput = new System.Windows.Forms.TextBox();
            this.lblFilename = new System.Windows.Forms.Label();
            this.tbInfo = new System.Windows.Forms.RichTextBox();
            this.lblEdit = new System.Windows.Forms.Label();
            this.tbEdit = new System.Windows.Forms.RichTextBox();
            this.btnGetInfo = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.tbInput.Location = new System.Drawing.Point(41, 33);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(340, 29);
            this.tbInput.TabIndex = 0;
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Location = new System.Drawing.Point(36, 79);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(223, 25);
            this.lblFilename.TabIndex = 1;
            this.lblFilename.Text = "Информация о файле";
            // 
            // tbInfo
            // 
            this.tbInfo.Location = new System.Drawing.Point(41, 121);
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ReadOnly = true;
            this.tbInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tbInfo.Size = new System.Drawing.Size(719, 115);
            this.tbInfo.TabIndex = 2;
            this.tbInfo.Text = "";
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Location = new System.Drawing.Point(46, 243);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(204, 25);
            this.lblEdit.TabIndex = 3;
            this.lblEdit.Text = "Содержимое файла";
            // 
            // tbEdit
            // 
            this.tbEdit.Location = new System.Drawing.Point(41, 300);
            this.tbEdit.Name = "tbEdit";
            this.tbEdit.ReadOnly = true;
            this.tbEdit.Size = new System.Drawing.Size(719, 130);
            this.tbEdit.TabIndex = 4;
            this.tbEdit.Text = "";
            this.tbEdit.WordWrap = false;
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.Location = new System.Drawing.Point(456, 33);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(304, 43);
            this.btnGetInfo.TabIndex = 5;
            this.btnGetInfo.Text = "Загрузить информацию";
            this.btnGetInfo.UseVisualStyleBackColor = true;
            this.btnGetInfo.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(378, 446);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(382, 51);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Сохранить изменения";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 528);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnGetInfo);
            this.Controls.Add(this.tbEdit);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.lblFilename);
            this.Controls.Add(this.tbInput);
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.RichTextBox tbInfo;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.RichTextBox tbEdit;
        private System.Windows.Forms.Button btnGetInfo;
        private System.Windows.Forms.Button btnSave;
    }
}

