﻿namespace KT_PO_lab
{
    partial class MainForm
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
            this.butGenerate = new System.Windows.Forms.Button();
            this.butFromFile = new System.Windows.Forms.Button();
            this.textBoxOriginal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butPerform = new System.Windows.Forms.Button();
            this.textBoxPerform = new System.Windows.Forms.TextBox();
            this.onTheScreen = new System.Windows.Forms.RadioButton();
            this.inFile = new System.Windows.Forms.RadioButton();
            this.ValueK = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butGenerate
            // 
            this.butGenerate.BackColor = System.Drawing.Color.Gold;
            this.butGenerate.Location = new System.Drawing.Point(308, 12);
            this.butGenerate.Name = "butGenerate";
            this.butGenerate.Size = new System.Drawing.Size(128, 49);
            this.butGenerate.TabIndex = 0;
            this.butGenerate.Text = "Генерация";
            this.butGenerate.UseVisualStyleBackColor = false;
            // 
            // butFromFile
            // 
            this.butFromFile.BackColor = System.Drawing.Color.SlateGray;
            this.butFromFile.Location = new System.Drawing.Point(12, 12);
            this.butFromFile.Name = "butFromFile";
            this.butFromFile.Size = new System.Drawing.Size(128, 49);
            this.butFromFile.TabIndex = 1;
            this.butFromFile.Text = "Загрузка из файла";
            this.butFromFile.UseVisualStyleBackColor = false;
            // 
            // textBoxOriginal
            // 
            this.textBoxOriginal.Location = new System.Drawing.Point(12, 103);
            this.textBoxOriginal.Multiline = true;
            this.textBoxOriginal.Name = "textBoxOriginal";
            this.textBoxOriginal.Size = new System.Drawing.Size(423, 116);
            this.textBoxOriginal.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Исходный массив";
            // 
            // butPerform
            // 
            this.butPerform.BackColor = System.Drawing.Color.Gold;
            this.butPerform.Location = new System.Drawing.Point(308, 264);
            this.butPerform.Name = "butPerform";
            this.butPerform.Size = new System.Drawing.Size(128, 49);
            this.butPerform.TabIndex = 4;
            this.butPerform.Text = "Преобразовать";
            this.butPerform.UseVisualStyleBackColor = false;
            // 
            // textBoxPerform
            // 
            this.textBoxPerform.Location = new System.Drawing.Point(12, 319);
            this.textBoxPerform.Multiline = true;
            this.textBoxPerform.Name = "textBoxPerform";
            this.textBoxPerform.ReadOnly = true;
            this.textBoxPerform.Size = new System.Drawing.Size(423, 155);
            this.textBoxPerform.TabIndex = 5;
            // 
            // onTheScreen
            // 
            this.onTheScreen.AutoSize = true;
            this.onTheScreen.Checked = true;
            this.onTheScreen.Location = new System.Drawing.Point(15, 264);
            this.onTheScreen.Name = "onTheScreen";
            this.onTheScreen.Size = new System.Drawing.Size(75, 17);
            this.onTheScreen.TabIndex = 6;
            this.onTheScreen.TabStop = true;
            this.onTheScreen.Text = "На экран ";
            this.onTheScreen.UseVisualStyleBackColor = true;
            // 
            // inFile
            // 
            this.inFile.AutoSize = true;
            this.inFile.Location = new System.Drawing.Point(15, 287);
            this.inFile.Name = "inFile";
            this.inFile.Size = new System.Drawing.Size(61, 17);
            this.inFile.TabIndex = 7;
            this.inFile.Text = "В файл";
            this.inFile.UseVisualStyleBackColor = true;
            // 
            // ValueK
            // 
            this.ValueK.AutoSize = true;
            this.ValueK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ValueK.Location = new System.Drawing.Point(12, 232);
            this.ValueK.Name = "ValueK";
            this.ValueK.Size = new System.Drawing.Size(88, 18);
            this.ValueK.TabIndex = 8;
            this.ValueK.Text = "Значение К";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(448, 494);
            this.Controls.Add(this.ValueK);
            this.Controls.Add(this.inFile);
            this.Controls.Add(this.onTheScreen);
            this.Controls.Add(this.textBoxPerform);
            this.Controls.Add(this.butPerform);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOriginal);
            this.Controls.Add(this.butFromFile);
            this.Controls.Add(this.butGenerate);
            this.Name = "MainForm";
            this.Text = "2 no vsy odna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butGenerate;
        private System.Windows.Forms.Button butFromFile;
        private System.Windows.Forms.TextBox textBoxOriginal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butPerform;
        private System.Windows.Forms.TextBox textBoxPerform;
        private System.Windows.Forms.RadioButton onTheScreen;
        private System.Windows.Forms.RadioButton inFile;
        private System.Windows.Forms.Label ValueK;
    }
}

