using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace FirstWindowsFormsApp
{
    public partial class FormStudentAdd : Form
    {
        List<string> ClassList = new List<string>() { "Section A", "Section B " };
        List<Student> ClassAStudents = new List<Student>();
        List<Student> ClassBStudents = new List<Student>();
        List<string> ChoosenElectives = new List<string>();
        public FormStudentAdd()
        {
            InitializeComponent();
            //comboClassSelection.Items.AddRange(SectionList.ToArray());
            foreach (string item in ClassList)
            {
                comboClassSelection.Items.Add(item);
            }
            textName.TabIndex = 0;
            textSurname.TabIndex = 1;
            dateTimePicker.TabIndex = 2;
            comboClassSelection.TabIndex = 3;
            buttonAddStudent.TabIndex = 4;
            groupboxElectiveLectures.Enabled = false;
            checkedListLectureSelection.CheckOnClick = true;
 

        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textName.Text) || string.IsNullOrEmpty(textSurname.Text))    //Returns boolean true if string is null or empty.
            {
                MessageBox.Show("Name and Surname fields can't be empty!");
            }
            else
            {
                Student student = new Student()
                {
                    Name = textName.Text,
                    Surname = textSurname.Text,
                    DateOfBirth = dateTimePicker.Value
                };

                if (DoesClassAContainStudent(student))
                {
                    MessageBox.Show("This student is already enrolled for class A!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (DoesClassBContainStudent(student))
                {
                    MessageBox.Show("This student is already enrolled for class B!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (comboClassSelection.SelectedIndex >= 0)
                {
                    student.SectionName = comboClassSelection.SelectedItem.ToString();
                    switch (comboClassSelection.SelectedIndex)
                    {
                        case 0:
                            if (!DoesClassAContainStudent(student))
                            {
                                ClassAStudents.Add(student);
                            }
                            else
                            {
                                MessageBox.Show("You have already added this student","WARNING",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            break;
                        case 1:
                            if (!DoesClassBContainStudent(student))
                            {
                                ClassBStudents.Add(student);
                            }
                            else
                            {
                                MessageBox.Show("You have already added this student");
                            }
                            break;
                        default:
                            break;
                    }

                    student.doesEnrolledElective = checkBoxElectivePrompt.Checked;

                    if (student.doesEnrolledElective)
                    {
                        student.EnrolledElectiveLectures.AddRange(ChoosenElectives);
                    }

                    CleanControls();
                    FillLists();
                }
                else
                {
                    MessageBox.Show("Please choose a section");
                }
            }
        }

        private bool DoesClassAContainStudent(Student student)
        {
            bool result =  false;
            foreach (var item in ClassAStudents)
            {
                if (item.Name == student.Name && item.Surname == student.Surname && item.DateOfBirth.ToShortDateString() == student.DateOfBirth.ToShortDateString())
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        private bool DoesClassBContainStudent(Student student)
        {
            bool result = false;
            foreach (var item in ClassBStudents)
            {
                if (item.Name == student.Name && item.Surname == student.Surname && item.DateOfBirth.ToShortDateString() == student.DateOfBirth.ToShortDateString())
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        private void CleanControls()
        {
            textName.Text = "";
            textSurname.Text = string.Empty;
            comboClassSelection.SelectedIndex = -1;
            comboClassSelection.Text = "Select your class section..";
            dateTimePicker.Value = DateTime.Now;
            ChoosenElectives.Clear();
            foreach (int index in checkedListLectureSelection.CheckedIndices)
            {
                checkedListLectureSelection.SetItemCheckState(index, CheckState.Unchecked);
            }
            ChoosenElectives.Clear();
            checkBoxElectivePrompt.Checked = false;
            FillLists();
        }

        private void FillLists()
        {
            listBoxClassA.Items.Clear();
            listBoxClassA.BackColor = Color.AliceBlue;
            listBoxClassA.Items.AddRange(ClassAStudents.ToArray());

            listBoxClassB.Items.Clear();
            listBoxClassB.BackColor = Color.Azure;
            listBoxClassB.Items.AddRange(ClassBStudents.ToArray());
        }

        private void buttonAddAllRight_Click(object sender, EventArgs e)
        {
            foreach (var item in ClassAStudents)
            {
                item.SectionName = "Class B";

            }
            ClassBStudents.AddRange(ClassAStudents.ToArray());
            ClassAStudents.Clear();
            FillLists();
        }

        private void buttonAddAllLeft_Click(object sender, EventArgs e)
        {
            foreach (var item in ClassBStudents)
            {
                item.SectionName = "Class B";
            }
            ClassAStudents.AddRange(ClassBStudents.ToArray());
            ClassBStudents.Clear();
            FillLists();
        }

        private void buttonAddRight_Click(object sender, EventArgs e)
        {
            Student studentTransfer = (Student) listBoxClassA.SelectedItem;
            if (studentTransfer!=null)
            {
                ClassAStudents.Remove(studentTransfer);
                studentTransfer.SectionName = "Class B";
                ClassBStudents.Add(studentTransfer);
                FillLists();

            }
            
        }

        private void buttonAddLeft_Click(object sender, EventArgs e)
        {
            Student studentTransfer = (Student)listBoxClassB.SelectedItem;
            if (studentTransfer != null)
            {

                ClassBStudents.Remove(studentTransfer);
                studentTransfer.SectionName = "Class A";
                ClassAStudents.Add(studentTransfer);
                FillLists();
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxElectivePrompt_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxElectivePrompt.Checked)
            {
                groupboxElectiveLectures.Enabled = true;
            }
            else 
            {
                groupboxElectiveLectures.Enabled = false;
            }
        }

        private void checkedListLectureSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChoosenElectives.Clear();
            foreach (var item in checkedListLectureSelection.CheckedItems)
            {
                if (ChoosenElectives.Count(x => x == item.ToString()) == 0)       //If the list doesn't contain the item, add the item in the list.
                {
                    ChoosenElectives.Add(item.ToString());
                }
            }
        }

        private void exportXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Student> StudentsToExport = new List<Student>();
            if (ClassAStudents.Count > 0)
            {
                StudentsToExport.AddRange(ClassAStudents);
            }
            if (ClassBStudents.Count > 0)
            {
                StudentsToExport.AddRange(ClassBStudents);
            }
            //Dialogue object is required to store XML file for certain location.
            //Serialize XML
            saveFileDialog1.Title = "Save Student XML Folder";
            saveFileDialog1.Filter = "XML Format | *.xml";
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //If opened dialog window confirmed, we can create XML File
                //Serialize XML. //Using System.Xml.Serialization;
                XmlSerializer myXMLSerializer = new XmlSerializer(typeof(List<Student>));
                //using block: handles the resource and performs additional closing operations after use, automatically.
                //IDisposable derived classes required. Disposing with Garbage Collector.
                using (TextWriter writer = new StreamWriter(saveFileDialog1.FileName))  //Include, using System.IO;
                {
                    myXMLSerializer.Serialize(writer, StudentsToExport);
                }
                MessageBox.Show($"{StudentsToExport.Count} students are exported in XML format");
            }
        }

        private void importXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Existing XML document will be imported. Another dialogue object.

            CleanControls();
            openFileDialog1.Title = "Choose an XML file";
            openFileDialog1.Multiselect = false;
            openFileDialog1.FileName = string.Empty;
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer myXMLSerializer = new XmlSerializer(typeof(List<Student>));
                //To read from an existing file, it is evident that we need a reader.
                using (TextReader reader = new StreamReader(openFileDialog1.FileName))  //Stream reader inherits from text reader.
                {
                    ClassAStudents = (List<Student>) myXMLSerializer.Deserialize (reader);
                    MessageBox.Show($"{ClassAStudents.Count} students has been imported from the file.");
                    FillLists();
                }
            }
        }
    }
}
