
namespace StudentMonitoringAndTaskDesignationSystem
{
    partial class Main
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
            this.todoList = new System.Windows.Forms.ListBox();
            this.progressList = new System.Windows.Forms.ListBox();
            this.reviseList = new System.Windows.Forms.ListBox();
            this.completedList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // todoList
            // 
            this.todoList.AllowDrop = true;
            this.todoList.FormattingEnabled = true;
            this.todoList.ItemHeight = 16;
            this.todoList.Location = new System.Drawing.Point(13, 13);
            this.todoList.Name = "todoList";
            this.todoList.Size = new System.Drawing.Size(344, 516);
            this.todoList.TabIndex = 0;
            this.todoList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.todoList_DrawItem);
            this.todoList.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.todoList_MeasureItem);
            this.todoList.DragDrop += new System.Windows.Forms.DragEventHandler(this.todoList_DragDrop);
            this.todoList.DragEnter += new System.Windows.Forms.DragEventHandler(this.todoList_DragEnter);
            this.todoList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.todoList_MouseDown);
            // 
            // progressList
            // 
            this.progressList.AllowDrop = true;
            this.progressList.FormattingEnabled = true;
            this.progressList.ItemHeight = 16;
            this.progressList.Location = new System.Drawing.Point(363, 12);
            this.progressList.Name = "progressList";
            this.progressList.Size = new System.Drawing.Size(331, 516);
            this.progressList.TabIndex = 1;
            this.progressList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.progressList_DrawItem);
            this.progressList.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.progressList_MeasureItem);
            this.progressList.DragDrop += new System.Windows.Forms.DragEventHandler(this.progressList_DragDrop);
            this.progressList.DragEnter += new System.Windows.Forms.DragEventHandler(this.progressList_DragEnter);
            this.progressList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.progressList_MouseDown);
            // 
            // reviseList
            // 
            this.reviseList.AllowDrop = true;
            this.reviseList.FormattingEnabled = true;
            this.reviseList.ItemHeight = 16;
            this.reviseList.Location = new System.Drawing.Point(701, 13);
            this.reviseList.Name = "reviseList";
            this.reviseList.Size = new System.Drawing.Size(310, 516);
            this.reviseList.TabIndex = 2;
            this.reviseList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.reviseList_DrawItem);
            this.reviseList.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.reviseList_MeasureItem);
            this.reviseList.DragDrop += new System.Windows.Forms.DragEventHandler(this.reviseList_DragDrop);
            this.reviseList.DragEnter += new System.Windows.Forms.DragEventHandler(this.reviseList_DragEnter);
            this.reviseList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.reviseList_MouseDown);
            // 
            // completedList
            // 
            this.completedList.AllowDrop = true;
            this.completedList.FormattingEnabled = true;
            this.completedList.ItemHeight = 16;
            this.completedList.Location = new System.Drawing.Point(1018, 12);
            this.completedList.Name = "completedList";
            this.completedList.Size = new System.Drawing.Size(327, 516);
            this.completedList.TabIndex = 3;
            this.completedList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.completedList_DrawItem);
            this.completedList.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.completedList_MeasureItem);
            this.completedList.DragDrop += new System.Windows.Forms.DragEventHandler(this.completedList_DragDrop);
            this.completedList.DragEnter += new System.Windows.Forms.DragEventHandler(this.completedList_DragEnter);
            this.completedList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.completedList_MouseDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 547);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(344, 79);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Task";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(385, 559);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 48);
            this.textBox1.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 665);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.completedList);
            this.Controls.Add(this.reviseList);
            this.Controls.Add(this.progressList);
            this.Controls.Add(this.todoList);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox todoList;
        private System.Windows.Forms.ListBox progressList;
        private System.Windows.Forms.ListBox reviseList;
        private System.Windows.Forms.ListBox completedList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

