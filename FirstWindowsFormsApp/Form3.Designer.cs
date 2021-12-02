
namespace FirstWindowsFormsApp
{
    partial class Form3
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.labelClassSelection = new System.Windows.Forms.Label();
            this.listBoxClassA = new System.Windows.Forms.ListBox();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.listBoxClassB = new System.Windows.Forms.ListBox();
            this.buttonAddRight = new System.Windows.Forms.Button();
            this.buttonAddAllRight = new System.Windows.Forms.Button();
            this.buttonAddLeft = new System.Windows.Forms.Button();
            this.buttonAddAllLeft = new System.Windows.Forms.Button();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboClassSelection = new System.Windows.Forms.ComboBox();
            this.groupboxStudentInfo = new System.Windows.Forms.GroupBox();
            this.checkBoxElectivePrompt = new System.Windows.Forms.CheckBox();
            this.groupboxElectiveLectures = new System.Windows.Forms.GroupBox();
            this.checkedListLectureSelection = new System.Windows.Forms.CheckedListBox();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.groupboxStudentInfo.SuspendLayout();
            this.groupboxElectiveLectures.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(19, 34);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(49, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(19, 74);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(67, 20);
            this.labelSurname.TabIndex = 1;
            this.labelSurname.Text = "Surname";
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Location = new System.Drawing.Point(19, 118);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(94, 20);
            this.labelDateOfBirth.TabIndex = 2;
            this.labelDateOfBirth.Text = "Date of Birth";
            // 
            // labelClassSelection
            // 
            this.labelClassSelection.AutoSize = true;
            this.labelClassSelection.Location = new System.Drawing.Point(19, 159);
            this.labelClassSelection.Name = "labelClassSelection";
            this.labelClassSelection.Size = new System.Drawing.Size(107, 20);
            this.labelClassSelection.TabIndex = 3;
            this.labelClassSelection.Text = "Class Selection";
            // 
            // listBoxClassA
            // 
            this.listBoxClassA.FormattingEnabled = true;
            this.listBoxClassA.ItemHeight = 20;
            this.listBoxClassA.Location = new System.Drawing.Point(12, 379);
            this.listBoxClassA.Name = "listBoxClassA";
            this.listBoxClassA.Size = new System.Drawing.Size(284, 224);
            this.listBoxClassA.TabIndex = 4;
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(146, 74);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(257, 27);
            this.textSurname.TabIndex = 7;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(146, 34);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(257, 27);
            this.textName.TabIndex = 8;
            // 
            // listBoxClassB
            // 
            this.listBoxClassB.FormattingEnabled = true;
            this.listBoxClassB.ItemHeight = 20;
            this.listBoxClassB.Location = new System.Drawing.Point(480, 379);
            this.listBoxClassB.Name = "listBoxClassB";
            this.listBoxClassB.Size = new System.Drawing.Size(315, 224);
            this.listBoxClassB.TabIndex = 9;
            // 
            // buttonAddRight
            // 
            this.buttonAddRight.Location = new System.Drawing.Point(348, 407);
            this.buttonAddRight.Name = "buttonAddRight";
            this.buttonAddRight.Size = new System.Drawing.Size(80, 39);
            this.buttonAddRight.TabIndex = 12;
            this.buttonAddRight.Text = ">";
            this.buttonAddRight.UseVisualStyleBackColor = true;
            this.buttonAddRight.Click += new System.EventHandler(this.buttonAddRight_Click);
            // 
            // buttonAddAllRight
            // 
            this.buttonAddAllRight.Location = new System.Drawing.Point(348, 452);
            this.buttonAddAllRight.Name = "buttonAddAllRight";
            this.buttonAddAllRight.Size = new System.Drawing.Size(80, 42);
            this.buttonAddAllRight.TabIndex = 13;
            this.buttonAddAllRight.Text = ">>";
            this.buttonAddAllRight.UseVisualStyleBackColor = true;
            this.buttonAddAllRight.Click += new System.EventHandler(this.buttonAddAllRight_Click);
            // 
            // buttonAddLeft
            // 
            this.buttonAddLeft.Location = new System.Drawing.Point(348, 500);
            this.buttonAddLeft.Name = "buttonAddLeft";
            this.buttonAddLeft.Size = new System.Drawing.Size(80, 39);
            this.buttonAddLeft.TabIndex = 14;
            this.buttonAddLeft.Text = "<";
            this.buttonAddLeft.UseVisualStyleBackColor = true;
            this.buttonAddLeft.Click += new System.EventHandler(this.buttonAddLeft_Click);
            // 
            // buttonAddAllLeft
            // 
            this.buttonAddAllLeft.Location = new System.Drawing.Point(348, 545);
            this.buttonAddAllLeft.Name = "buttonAddAllLeft";
            this.buttonAddAllLeft.Size = new System.Drawing.Size(80, 41);
            this.buttonAddAllLeft.TabIndex = 15;
            this.buttonAddAllLeft.Text = "<<";
            this.buttonAddAllLeft.UseVisualStyleBackColor = true;
            this.buttonAddAllLeft.Click += new System.EventHandler(this.buttonAddAllLeft_Click);
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Location = new System.Drawing.Point(431, 34);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(119, 150);
            this.buttonAddStudent.TabIndex = 16;
            this.buttonAddStudent.Text = "ADD STUDENT";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operationsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 28);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem});
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.operationsToolStripMenuItem.Text = "Operations";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(146, 118);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(257, 27);
            this.dateTimePicker.TabIndex = 18;
            // 
            // comboClassSelection
            // 
            this.comboClassSelection.FormattingEnabled = true;
            this.comboClassSelection.Location = new System.Drawing.Point(146, 156);
            this.comboClassSelection.Name = "comboClassSelection";
            this.comboClassSelection.Size = new System.Drawing.Size(257, 28);
            this.comboClassSelection.TabIndex = 19;
            this.comboClassSelection.Text = "Select your class section..";
            // 
            // groupboxStudentInfo
            // 
            this.groupboxStudentInfo.Controls.Add(this.checkBoxElectivePrompt);
            this.groupboxStudentInfo.Controls.Add(this.labelSurname);
            this.groupboxStudentInfo.Controls.Add(this.buttonAddStudent);
            this.groupboxStudentInfo.Controls.Add(this.comboClassSelection);
            this.groupboxStudentInfo.Controls.Add(this.labelName);
            this.groupboxStudentInfo.Controls.Add(this.dateTimePicker);
            this.groupboxStudentInfo.Controls.Add(this.labelDateOfBirth);
            this.groupboxStudentInfo.Controls.Add(this.labelClassSelection);
            this.groupboxStudentInfo.Controls.Add(this.textSurname);
            this.groupboxStudentInfo.Controls.Add(this.textName);
            this.groupboxStudentInfo.Location = new System.Drawing.Point(15, 31);
            this.groupboxStudentInfo.Name = "groupboxStudentInfo";
            this.groupboxStudentInfo.Size = new System.Drawing.Size(581, 285);
            this.groupboxStudentInfo.TabIndex = 20;
            this.groupboxStudentInfo.TabStop = false;
            this.groupboxStudentInfo.Text = "Student Information";
            // 
            // checkBoxElectivePrompt
            // 
            this.checkBoxElectivePrompt.AutoSize = true;
            this.checkBoxElectivePrompt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxElectivePrompt.Location = new System.Drawing.Point(102, 225);
            this.checkBoxElectivePrompt.Name = "checkBoxElectivePrompt";
            this.checkBoxElectivePrompt.Size = new System.Drawing.Size(360, 24);
            this.checkBoxElectivePrompt.TabIndex = 21;
            this.checkBoxElectivePrompt.Text = "Would you like to enroll for an elective lecture?";
            this.checkBoxElectivePrompt.UseVisualStyleBackColor = true;
            this.checkBoxElectivePrompt.CheckedChanged += new System.EventHandler(this.checkBoxElectivePrompt_CheckedChanged);
            // 
            // groupboxElectiveLectures
            // 
            this.groupboxElectiveLectures.Controls.Add(this.checkedListLectureSelection);
            this.groupboxElectiveLectures.Location = new System.Drawing.Point(672, 31);
            this.groupboxElectiveLectures.Name = "groupboxElectiveLectures";
            this.groupboxElectiveLectures.Size = new System.Drawing.Size(250, 285);
            this.groupboxElectiveLectures.TabIndex = 20;
            this.groupboxElectiveLectures.TabStop = false;
            this.groupboxElectiveLectures.Text = "Elevtive Lectures";
            // 
            // checkedListLectureSelection
            // 
            this.checkedListLectureSelection.FormattingEnabled = true;
            this.checkedListLectureSelection.Items.AddRange(new object[] {
            "Human Resources",
            "Public Services",
            "Italian",
            "Citizen Health",
            "Evolution"});
            this.checkedListLectureSelection.Location = new System.Drawing.Point(0, 31);
            this.checkedListLectureSelection.Name = "checkedListLectureSelection";
            this.checkedListLectureSelection.Size = new System.Drawing.Size(250, 246);
            this.checkedListLectureSelection.TabIndex = 21;
            this.checkedListLectureSelection.SelectedIndexChanged += new System.EventHandler(this.checkedListLectureSelection_SelectedIndexChanged);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportXMLToolStripMenuItem,
            this.importXMLToolStripMenuItem});
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.xMLToolStripMenuItem.Text = "XML";
            // 
            // exportXMLToolStripMenuItem
            // 
            this.exportXMLToolStripMenuItem.Name = "exportXMLToolStripMenuItem";
            this.exportXMLToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exportXMLToolStripMenuItem.Text = "Export XML";
            this.exportXMLToolStripMenuItem.Click += new System.EventHandler(this.exportXMLToolStripMenuItem_Click);
            // 
            // importXMLToolStripMenuItem
            // 
            this.importXMLToolStripMenuItem.Name = "importXMLToolStripMenuItem";
            this.importXMLToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.importXMLToolStripMenuItem.Text = "Import XML";
            this.importXMLToolStripMenuItem.Click += new System.EventHandler(this.importXMLToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 719);
            this.Controls.Add(this.groupboxElectiveLectures);
            this.Controls.Add(this.groupboxStudentInfo);
            this.Controls.Add(this.buttonAddAllLeft);
            this.Controls.Add(this.buttonAddLeft);
            this.Controls.Add(this.buttonAddAllRight);
            this.Controls.Add(this.buttonAddRight);
            this.Controls.Add(this.listBoxClassB);
            this.Controls.Add(this.listBoxClassA);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupboxStudentInfo.ResumeLayout(false);
            this.groupboxStudentInfo.PerformLayout();
            this.groupboxElectiveLectures.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.Label labelClassSelection;
        private System.Windows.Forms.ListBox listBoxClassA;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.ListBox listBoxClassB;
        private System.Windows.Forms.Button buttonAddRight;
        private System.Windows.Forms.Button buttonAddAllRight;
        private System.Windows.Forms.Button buttonAddLeft;
        private System.Windows.Forms.Button buttonAddAllLeft;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox comboClassSelection;
        private System.Windows.Forms.GroupBox groupboxStudentInfo;
        private System.Windows.Forms.CheckBox checkBoxElectivePrompt;
        private System.Windows.Forms.GroupBox groupboxElectiveLectures;
        private System.Windows.Forms.CheckedListBox checkedListLectureSelection;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importXMLToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}