using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection("Data Source=.;database=studentDataSet");
        
        //current storage method for the classes of students
        ArrayList classes = new ArrayList();

        public Form1()
        {
            InitializeComponent();
            menuScreen.Visible = true;
            randomizationScreen.Visible = false;
            editorScreen.Visible = false;
            helpScreen.Visible = false;

        }



        //=====Main Menu====
        private void menu_ToRandomButton_Click(object sender, EventArgs e)
        {
            if (menuScreen.Visible) { 
                menuScreen.Visible = false;
                randomizationScreen.Visible = true;
                helpScreen.Visible = false;
            }
        }
        private void menu_ToEditorButton_Click(object sender, EventArgs e)
        {
            if (menuScreen.Visible)
            {

                /*
                var result = MessageBox.Show("Are you creating a new class?", "Class Editor", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.Yes:   // Yes button pressed

                        editor_classGrid.Rows.Clear();
                        editor_classGrid.Refresh();

                        menuScreen.Visible = false; //note to self: consider creating show() methods for each of the screen changes
                        editorScreen.Visible = true;
                        randomizationScreen.Visible = false;
                        helpScreen.Visible = false;
                        break;
                    case DialogResult.No:    // No button pressed
                        menuScreen.Visible = false;
                        editorScreen.Visible = true;
                        randomizationScreen.Visible = false;
                        helpScreen.Visible = false;
                        break;
                    case DialogResult.Cancel:
                        break;
                    default:                 // Neither Yes nor No pressed (just in case)
                        MessageBox.Show("What did you press?");
                        break;
                }
                */


                
                menuScreen.Visible = false;
                editorScreen.Visible = true;
                randomizationScreen.Visible = false;
                helpScreen.Visible = false;
                
            }
        }

        //creates a textfile for the user that contains the data contained in this version of the application, for tranfer between different installations
        private void menu_ExportButton_Click(object sender, EventArgs e)
        {

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "WAP Files (*.txt)|*.txt";
            sfd.OverwritePrompt = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //str contains the entire string that will e added to the text file
                StreamWriter write = new StreamWriter(File.Create(sfd.FileName));
                string str = "";

                foreach (Classroom theClass in classes)
                {
                    str += theClass.name + "\n";

                    for (int i = 0; i < theClass.myStudents.Count; i++)
                    {
                        Student student = (Student)theClass.myStudents[i];
                        str += student.name + "\n" + student.correctScore + "\n" + student.incorrectScore + "\n" + student.absentScore + "\n";
                    }
                }

                write.WriteLine(str);
                write.Close();
                write.Dispose();
            }
            /*
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "WAP Files (*.txt)|*.txt";
            sfd.OverwritePrompt = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(File.Create(sfd.FileName));

                string str = editor_ClassName.Text + "\n";
                int row = editor_classGrid.Rows.Count;
                int cell = editor_classGrid.Rows[1].Cells.Count;
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < cell; j++)
                    {
                        if (editor_classGrid.Rows[i].Cells[j].Value != null)
                        {
                            str += editor_classGrid.Rows[i].Cells[j].Value.ToString() + "\n";
                        }
                        else if (editor_classGrid.Rows[i].Cells[j].Value == null)
                        {
                            break;
                        }

                    }
                }
                write.WriteLine(str);
                write.Close();
                write.Dispose();
            }
            */
        }

        private void menu_ToHelpButton_Click(object sender, EventArgs e)
        {
            if (menuScreen.Visible)
            {
                menuScreen.Visible = false;
                editorScreen.Visible = false;
                randomizationScreen.Visible = false;
                helpScreen.Visible = true;
            }
        }
        private void menu_QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        //====Randomization Screen====
        private void random_ToMainMenu_Click(object sender, EventArgs e)
        {
            if (randomizationScreen.Visible)
            {
                menuScreen.Visible = true;
                randomizationScreen.Visible = false;
            }
        }

        //====Class/Student Editor Screen====
        private void editor_ToMainMenu_Click_1(object sender, EventArgs e)
        {
            if (editorScreen.Visible)
            {
                menuScreen.Visible = true;
                editorScreen.Visible = false;
            }
        }

        //commit current changes to the class, or save the new class if it did not already exist
        private void editor_SaveChanges_Click(object sender, EventArgs e)
        {

            Classroom theClass = new Classroom(editor_ClassName.Text);
            //create a new student object for each row, give it the values from the datagrid, then store them
            foreach (DataGridViewRow row in editor_classGrid.Rows)
            {
                //Student student = new Student(editor_classGrid.Rows[count].Cells[0].Value.ToString(), (int)editor_classGrid.Rows[count].Cells[1].Value, 
                //(int)editor_classGrid.Rows[count].Cells[2].Value, (int)editor_classGrid.Rows[count].Cells[3].Value);
                if (row.Cells[0].Value != null)
                {
                    try
                    {
                        Student student = new Student(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString());
                        theClass.addStudent(student);
                    } catch (NullReferenceException n)
                    {
                        System.Diagnostics.Debug.WriteLine("Stop being stupid you moron");
                    }
                    
                }

            }
            classes.Add(theClass);
        }

        private void editor_RevertChangesButton_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //====Help Screen====
        private void help_ToMenuButton_Click(object sender, EventArgs e)
        {
            if (helpScreen.Visible)
            {
                helpScreen.Visible = false;
                menuScreen.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet.studentTable' table. You can move, or remove it, as needed.
            this.studentTableTableAdapter.Fill(this.studentDataSet.studentTable);

        }

    }
}
