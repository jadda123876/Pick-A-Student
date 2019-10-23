using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
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
                menuScreen.Visible = false;
                editorScreen.Visible = true;
                randomizationScreen.Visible = false;
                helpScreen.Visible = false;
            }
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

        //====Help Screen====
        private void help_ToMenuButton_Click(object sender, EventArgs e)
        {
            if (helpScreen.Visible)
            {
                helpScreen.Visible = false;
                menuScreen.Visible = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editor_SaveChanges_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "WAP Files (*.txt)|*.txt";
            sfd.OverwritePrompt = true;
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(File.Create(sfd.FileName));

                string str = editor_ClassName.Text + "\n";
                int row = editor_classGrid.Rows.Count;
                int cell = editor_classGrid.Rows[1].Cells.Count;
                for(int i = 0; i < row; i++)
                {
                    for(int j = 0; j < cell; j++)
                    {
                        if(editor_classGrid.Rows[i].Cells[j].Value != null)
                        {
                            str += editor_classGrid.Rows[i].Cells[j].Value.ToString() + "\n";
                        }
                        else if(editor_classGrid.Rows[i].Cells[j].Value == null)
                        {
                            break;
                        }
                       
                    }
                }
                write.WriteLine(str);
                write.Close();
                write.Dispose();
            }
        }
    }
}
