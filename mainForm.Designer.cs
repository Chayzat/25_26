
namespace XMLGameResults
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
            this.lblList = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.listOfPlayers = new System.Windows.Forms.ListView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lnlScore = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(41, 35);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(127, 20);
            this.lblList.TabIndex = 0;
            this.lblList.Text = "Список игроков";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.lnlScore);
            this.groupBox.Controls.Add(this.lblName);
            this.groupBox.Controls.Add(this.btnSave);
            this.groupBox.Controls.Add(this.txtScore);
            this.groupBox.Controls.Add(this.txtName);
            this.groupBox.Location = new System.Drawing.Point(472, 72);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(299, 342);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Добавление";
            // 
            // listOfPlayers
            // 
            this.listOfPlayers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listOfPlayers.HideSelection = false;
            this.listOfPlayers.Location = new System.Drawing.Point(45, 72);
            this.listOfPlayers.Name = "listOfPlayers";
            this.listOfPlayers.Size = new System.Drawing.Size(400, 342);
            this.listOfPlayers.TabIndex = 2;
            this.listOfPlayers.UseCompatibleStateImageBehavior = false;
            this.listOfPlayers.View = System.Windows.Forms.View.Details;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(61, 76);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(185, 26);
            this.txtName.TabIndex = 0;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(61, 193);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(185, 26);
            this.txtScore.TabIndex = 1;
            this.txtScore.TextChanged += new System.EventHandler(this.txtScore_TextChanged);
            this.txtScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtScore_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(82, 280);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(139, 37);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(117, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(40, 20);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Имя";
            // 
            // lnlScore
            // 
            this.lnlScore.AutoSize = true;
            this.lnlScore.Location = new System.Drawing.Point(78, 138);
            this.lnlScore.Name = "lnlScore";
            this.lnlScore.Size = new System.Drawing.Size(148, 20);
            this.lnlScore.TabIndex = 5;
            this.lnlScore.Text = "Количество очков";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Номер";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Имя";
            this.columnHeader2.Width = 117;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Количество очков";
            this.columnHeader3.Width = 244;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listOfPlayers);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.lblList);
            this.Name = "mainForm";
            this.Text = "Результаты прохождения игры";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label lnlScore;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListView listOfPlayers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

