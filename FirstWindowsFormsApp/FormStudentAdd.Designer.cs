
namespace FirstWindowsFormsApp
{
    partial class FormStudentAdd
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
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboClassSelection = new System.Windows.Forms.ComboBox();
            this.groupboxStudentInfo = new System.Windows.Forms.GroupBox();
            this.checkBoxElectivePrompt = new System.Windows.Forms.CheckBox();
            this.groupboxElectiveLectures = new System.Windows.Forms.GroupBox();
            this.checkedListLectureSelection = new System.Windows.Forms.CheckedListBox();
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
            this.labelName.Location = new System.Drawing.Point(17, 26);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(39, 15);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(17, 56);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(54, 15);
            this.labelSurname.TabIndex = 1;
            this.labelSurname.Text = "Surname";
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Location = new System.Drawing.Point(17, 88);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(73, 15);
            this.labelDateOfBirth.TabIndex = 2;
            this.labelDateOfBirth.Text = "Date of Birth";
            // 
            // labelClassSelection
            // 
            this.labelClassSelection.AutoSize = true;
            this.labelClassSelection.Location = new System.Drawing.Point(17, 119);
            this.labelClassSelection.Name = "labelClassSelection";
            this.labelClassSelection.Size = new System.Drawing.Size(85, 15);
            this.labelClassSelection.TabIndex = 3;
            this.labelClassSelection.Text = "Class Selection";
            // 
            // listBoxClassA
            // 
            this.listBoxClassA.FormattingEnabled = true;
            this.listBoxClassA.ItemHeight = 15;
            this.listBoxClassA.Location = new System.Drawing.Point(10, 284);
            this.listBoxClassA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxClassA.Name = "listBoxClassA";
            this.listBoxClassA.Size = new System.Drawing.Size(249, 169);
            this.listBoxClassA.TabIndex = 4;
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(128, 56);
            this.textSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(225, 23);
            this.textSurname.TabIndex = 7;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(128, 26);
            this.textName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(225, 23);
            this.textName.TabIndex = 8;
            // 
            // listBoxClassB
            // 
            this.listBoxClassB.FormattingEnabled = true;
            this.listBoxClassB.ItemHeight = 15;
            this.listBoxClassB.Location = new System.Drawing.Point(420, 284);
            this.listBoxClassB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxClassB.Name = "listBoxClassB";
            this.listBoxClassB.Size = new System.Drawing.Size(276, 169);
            this.listBoxClassB.TabIndex = 9;
            // 
            // buttonAddRight
            // 
            this.buttonAddRight.Location = new System.Drawing.Point(304, 305);
            this.buttonAddRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddRight.Name = "buttonAddRight";
            this.buttonAddRight.Size = new System.Drawing.Size(70, 29);
            this.buttonAddRight.TabIndex = 12;
            this.buttonAddRight.Text = ">";
            this.buttonAddRight.UseVisualStyleBackColor = true;
            this.buttonAddRight.Click += new System.EventHandler(this.buttonAddRight_Click);
            // 
            // buttonAddAllRight
            // 
            this.buttonAddAllRight.Location = new System.Drawing.Point(304, 339);
            this.buttonAddAllRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddAllRight.Name = "buttonAddAllRight";
            this.buttonAddAllRight.Size = new System.Drawing.Size(70, 32);
            this.buttonAddAllRight.TabIndex = 13;
            this.buttonAddAllRight.Text = ">>";
            this.buttonAddAllRight.UseVisualStyleBackColor = true;
            this.buttonAddAllRight.Click += new System.EventHandler(this.buttonAddAllRight_Click);
            // 
            // buttonAddLeft
            // 
            this.buttonAddLeft.Location = new System.Drawing.Point(304, 375);
            this.buttonAddLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddLeft.Name = "buttonAddLeft";
            this.buttonAddLeft.Size = new System.Drawing.Size(70, 29);
            this.buttonAddLeft.TabIndex = 14;
            this.buttonAddLeft.Text = "<";
            this.buttonAddLeft.UseVisualStyleBackColor = true;
            this.buttonAddLeft.Click += new System.EventHandler(this.buttonAddLeft_Click);
            // 
            // buttonAddAllLeft
            // 
            this.buttonAddAllLeft.Location = new System.Drawing.Point(304, 409);
            this.buttonAddAllLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddAllLeft.Name = "buttonAddAllLeft";
            this.buttonAddAllLeft.Size = new System.Drawing.Size(70, 31);
            this.buttonAddAllLeft.TabIndex = 15;
            this.buttonAddAllLeft.Text = "<<";
            this.buttonAddAllLeft.UseVisualStyleBackColor = true;
            this.buttonAddAllLeft.Click += new System.EventHandler(this.buttonAddAllLeft_Click);
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Location = new System.Drawing.Point(377, 26);
            this.buttonAddStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(104, 112);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(817, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem});
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.operationsToolStripMenuItem.Text = "Operations";
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportXMLToolStripMenuItem,
            this.importXMLToolStripMenuItem});
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.xMLToolStripMenuItem.Text = "XML";
            // 
            // exportXMLToolStripMenuItem
            // 
            this.exportXMLToolStripMenuItem.Name = "exportXMLToolStripMenuItem";
            this.exportXMLToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.exportXMLToolStripMenuItem.Text = "Export XML";
            this.exportXMLToolStripMenuItem.Click += new System.EventHandler(this.exportXMLToolStripMenuItem_Click);
            // 
            // importXMLToolStripMenuItem
            // 
            this.importXMLToolStripMenuItem.Name = "importXMLToolStripMenuItem";
            this.importXMLToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.importXMLToolStripMenuItem.Text = "Import XML";
            this.importXMLToolStripMenuItem.Click += new System.EventHandler(this.importXMLToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(128, 88);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(225, 23);
            this.dateTimePicker.TabIndex = 18;
            // 
            // comboClassSelection
            // 
            this.comboClassSelection.FormattingEnabled = true;
            this.comboClassSelection.Location = new System.Drawing.Point(128, 117);
            this.comboClassSelection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboClassSelection.Name = "comboClassSelection";
            this.comboClassSelection.Size = new System.Drawing.Size(225, 23);
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
            this.groupboxStudentInfo.Location = new System.Drawing.Point(13, 23);
            this.groupboxStudentInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupboxStudentInfo.Name = "groupboxStudentInfo";
            this.groupboxStudentInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupboxStudentInfo.Size = new System.Drawing.Size(508, 214);
            this.groupboxStudentInfo.TabIndex = 20;
            this.groupboxStudentInfo.TabStop = false;
            this.groupboxStudentInfo.Text = "Student Information";
            // 
            // checkBoxElectivePrompt
            // 
            this.checkBoxElectivePrompt.AutoSize = true;
            this.checkBoxElectivePrompt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxElectivePrompt.Location = new System.Drawing.Point(89, 169);
            this.checkBoxElectivePrompt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxElectivePrompt.Name = "checkBoxElectivePrompt";
            this.checkBoxElectivePrompt.Size = new System.Drawing.Size(290, 19);
            this.checkBoxElectivePrompt.TabIndex = 21;
            this.checkBoxElectivePrompt.Text = "Would you like to enroll for an elective lecture?";
            this.checkBoxElectivePrompt.UseVisualStyleBackColor = true;
            this.checkBoxElectivePrompt.CheckedChanged += new System.EventHandler(this.checkBoxElectivePrompt_CheckedChanged);
            // 
            // groupboxElectiveLectures
            // 
            this.groupboxElectiveLectures.Controls.Add(this.checkedListLectureSelection);
            this.groupboxElectiveLectures.Location = new System.Drawing.Point(588, 23);
            this.groupboxElectiveLectures.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupboxElectiveLectures.Name = "groupboxElectiveLectures";
            this.groupboxElectiveLectures.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupboxElectiveLectures.Size = new System.Drawing.Size(219, 214);
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
            this.checkedListLectureSelection.Location = new System.Drawing.Point(0, 23);
            this.checkedListLectureSelection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListLectureSelection.Name = "checkedListLectureSelection";
            this.checkedListLectureSelection.Size = new System.Drawing.Size(219, 184);
            this.checkedListLectureSelection.TabIndex = 21;
            this.checkedListLectureSelection.SelectedIndexChanged += new System.EventHandler(this.checkedListLectureSelection_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormStudentAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 539);
            this.Controls.Add(this.groupboxElectiveLectures);
            this.Controls.Add(this.groupboxStudentInfo);
            this.Controls.Add(this.buttonAddAllLeft);
            this.Controls.Add(this.buttonAddLeft);
            this.Controls.Add(this.buttonAddAllRight);
            this.Controls.Add(this.buttonAddRight);
            this.Controls.Add(this.listBoxClassB);
            this.Controls.Add(this.listBoxClassA);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormStudentAdd";
            this.Text = "Student Enrollment Form";
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