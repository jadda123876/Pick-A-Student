namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuScreen = new System.Windows.Forms.Panel();
            this.menu_NameLabel = new System.Windows.Forms.Label();
            this.menu_QuitButton = new System.Windows.Forms.Button();
            this.menu_ToHelpButton = new System.Windows.Forms.Button();
            this.menu_ExportButton = new System.Windows.Forms.Button();
            this.menu_ImportButton = new System.Windows.Forms.Button();
            this.menu_ToEditorButton = new System.Windows.Forms.Button();
            this.menu_ToRandomButton = new System.Windows.Forms.Button();
            this.randomizationScreen = new System.Windows.Forms.Panel();
            this.random_NextStudent = new System.Windows.Forms.Button();
            this.random_NumStudents = new System.Windows.Forms.Label();
            this.random_RemainingStudents = new System.Windows.Forms.Label();
            this.random_IncorrectLabel = new System.Windows.Forms.Label();
            this.random_AbsentLabel = new System.Windows.Forms.Label();
            this.random_CorrectLabel = new System.Windows.Forms.Label();
            this.random_CurrentStudent = new System.Windows.Forms.Label();
            this.random_ToMainMenu = new System.Windows.Forms.Button();
            this.editorScreen = new System.Windows.Forms.Panel();
            this.editor_NumStudentsLabel = new System.Windows.Forms.Label();
            this.editor_NumPeopleInClass = new System.Windows.Forms.Label();
            this.editor_RevertChangesButton = new System.Windows.Forms.Button();
            this.editor_SaveChanges = new System.Windows.Forms.Button();
            this.editor_ResetQueueButton = new System.Windows.Forms.Button();
            this.editor_ClassName = new System.Windows.Forms.TextBox();
            this.editor_Label1 = new System.Windows.Forms.Label();
            this.editor_ToMainMenu = new System.Windows.Forms.Button();
            this.helpScreen = new System.Windows.Forms.Panel();
            this.help_ToMenuButton = new System.Windows.Forms.Button();
            this.editor_classGrid = new System.Windows.Forms.DataGridView();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correctColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incorrectColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.absentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuScreen.SuspendLayout();
            this.randomizationScreen.SuspendLayout();
            this.editorScreen.SuspendLayout();
            this.helpScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editor_classGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuScreen
            // 
            this.menuScreen.Controls.Add(this.menu_NameLabel);
            this.menuScreen.Controls.Add(this.menu_QuitButton);
            this.menuScreen.Controls.Add(this.menu_ToHelpButton);
            this.menuScreen.Controls.Add(this.menu_ExportButton);
            this.menuScreen.Controls.Add(this.menu_ImportButton);
            this.menuScreen.Controls.Add(this.menu_ToEditorButton);
            this.menuScreen.Controls.Add(this.menu_ToRandomButton);
            this.menuScreen.Location = new System.Drawing.Point(-1, 0);
            this.menuScreen.Name = "menuScreen";
            this.menuScreen.Size = new System.Drawing.Size(783, 653);
            this.menuScreen.TabIndex = 0;
            // 
            // menu_NameLabel
            // 
            this.menu_NameLabel.AutoSize = true;
            this.menu_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.menu_NameLabel.Location = new System.Drawing.Point(292, 61);
            this.menu_NameLabel.Name = "menu_NameLabel";
            this.menu_NameLabel.Size = new System.Drawing.Size(216, 36);
            this.menu_NameLabel.TabIndex = 6;
            this.menu_NameLabel.Text = "Pick-A-Student";
            // 
            // menu_QuitButton
            // 
            this.menu_QuitButton.Location = new System.Drawing.Point(322, 374);
            this.menu_QuitButton.Name = "menu_QuitButton";
            this.menu_QuitButton.Size = new System.Drawing.Size(150, 30);
            this.menu_QuitButton.TabIndex = 5;
            this.menu_QuitButton.Text = "Exit";
            this.menu_QuitButton.UseVisualStyleBackColor = true;
            this.menu_QuitButton.Click += new System.EventHandler(this.menu_QuitButton_Click);
            // 
            // menu_ToHelpButton
            // 
            this.menu_ToHelpButton.Location = new System.Drawing.Point(322, 324);
            this.menu_ToHelpButton.Name = "menu_ToHelpButton";
            this.menu_ToHelpButton.Size = new System.Drawing.Size(150, 30);
            this.menu_ToHelpButton.TabIndex = 4;
            this.menu_ToHelpButton.Text = "Help";
            this.menu_ToHelpButton.UseVisualStyleBackColor = true;
            this.menu_ToHelpButton.Click += new System.EventHandler(this.menu_ToHelpButton_Click);
            // 
            // menu_ExportButton
            // 
            this.menu_ExportButton.Location = new System.Drawing.Point(322, 274);
            this.menu_ExportButton.Name = "menu_ExportButton";
            this.menu_ExportButton.Size = new System.Drawing.Size(150, 30);
            this.menu_ExportButton.TabIndex = 3;
            this.menu_ExportButton.Text = "Export Data";
            this.menu_ExportButton.UseVisualStyleBackColor = true;
            // 
            // menu_ImportButton
            // 
            this.menu_ImportButton.Location = new System.Drawing.Point(322, 224);
            this.menu_ImportButton.Name = "menu_ImportButton";
            this.menu_ImportButton.Size = new System.Drawing.Size(150, 30);
            this.menu_ImportButton.TabIndex = 2;
            this.menu_ImportButton.Text = "Import Data";
            this.menu_ImportButton.UseVisualStyleBackColor = true;
            // 
            // menu_ToEditorButton
            // 
            this.menu_ToEditorButton.Location = new System.Drawing.Point(322, 173);
            this.menu_ToEditorButton.Name = "menu_ToEditorButton";
            this.menu_ToEditorButton.Size = new System.Drawing.Size(150, 30);
            this.menu_ToEditorButton.TabIndex = 1;
            this.menu_ToEditorButton.Text = "Create/Edit Class";
            this.menu_ToEditorButton.UseVisualStyleBackColor = true;
            this.menu_ToEditorButton.Click += new System.EventHandler(this.menu_ToEditorButton_Click);
            // 
            // menu_ToRandomButton
            // 
            this.menu_ToRandomButton.Location = new System.Drawing.Point(322, 125);
            this.menu_ToRandomButton.Name = "menu_ToRandomButton";
            this.menu_ToRandomButton.Size = new System.Drawing.Size(150, 30);
            this.menu_ToRandomButton.TabIndex = 0;
            this.menu_ToRandomButton.Text = "Start";
            this.menu_ToRandomButton.UseVisualStyleBackColor = true;
            this.menu_ToRandomButton.Click += new System.EventHandler(this.menu_ToRandomButton_Click);
            // 
            // randomizationScreen
            // 
            this.randomizationScreen.Controls.Add(this.random_NextStudent);
            this.randomizationScreen.Controls.Add(this.random_NumStudents);
            this.randomizationScreen.Controls.Add(this.random_RemainingStudents);
            this.randomizationScreen.Controls.Add(this.random_IncorrectLabel);
            this.randomizationScreen.Controls.Add(this.random_AbsentLabel);
            this.randomizationScreen.Controls.Add(this.random_CorrectLabel);
            this.randomizationScreen.Controls.Add(this.random_CurrentStudent);
            this.randomizationScreen.Controls.Add(this.random_ToMainMenu);
            this.randomizationScreen.Location = new System.Drawing.Point(2, 0);
            this.randomizationScreen.Name = "randomizationScreen";
            this.randomizationScreen.Size = new System.Drawing.Size(779, 653);
            this.randomizationScreen.TabIndex = 1;
            this.randomizationScreen.Visible = false;
            // 
            // random_NextStudent
            // 
            this.random_NextStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.random_NextStudent.Location = new System.Drawing.Point(570, 61);
            this.random_NextStudent.Name = "random_NextStudent";
            this.random_NextStudent.Size = new System.Drawing.Size(84, 36);
            this.random_NextStudent.TabIndex = 7;
            this.random_NextStudent.Text = ">";
            this.random_NextStudent.UseVisualStyleBackColor = true;
            // 
            // random_NumStudents
            // 
            this.random_NumStudents.AutoSize = true;
            this.random_NumStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.random_NumStudents.Location = new System.Drawing.Point(531, 456);
            this.random_NumStudents.Name = "random_NumStudents";
            this.random_NumStudents.Size = new System.Drawing.Size(26, 29);
            this.random_NumStudents.TabIndex = 6;
            this.random_NumStudents.Text = "0";
            // 
            // random_RemainingStudents
            // 
            this.random_RemainingStudents.AutoSize = true;
            this.random_RemainingStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.random_RemainingStudents.Location = new System.Drawing.Point(290, 456);
            this.random_RemainingStudents.Name = "random_RemainingStudents";
            this.random_RemainingStudents.Size = new System.Drawing.Size(235, 29);
            this.random_RemainingStudents.TabIndex = 5;
            this.random_RemainingStudents.Text = "Remaining Students:";
            // 
            // random_IncorrectLabel
            // 
            this.random_IncorrectLabel.AutoSize = true;
            this.random_IncorrectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.random_IncorrectLabel.Location = new System.Drawing.Point(361, 368);
            this.random_IncorrectLabel.Name = "random_IncorrectLabel";
            this.random_IncorrectLabel.Size = new System.Drawing.Size(124, 32);
            this.random_IncorrectLabel.TabIndex = 4;
            this.random_IncorrectLabel.Text = "Incorrect";
            // 
            // random_AbsentLabel
            // 
            this.random_AbsentLabel.AutoSize = true;
            this.random_AbsentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.random_AbsentLabel.Location = new System.Drawing.Point(550, 368);
            this.random_AbsentLabel.Name = "random_AbsentLabel";
            this.random_AbsentLabel.Size = new System.Drawing.Size(104, 32);
            this.random_AbsentLabel.TabIndex = 3;
            this.random_AbsentLabel.Text = "Absent";
            // 
            // random_CorrectLabel
            // 
            this.random_CorrectLabel.AutoSize = true;
            this.random_CorrectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.random_CorrectLabel.Location = new System.Drawing.Point(170, 368);
            this.random_CorrectLabel.Name = "random_CorrectLabel";
            this.random_CorrectLabel.Size = new System.Drawing.Size(107, 32);
            this.random_CorrectLabel.TabIndex = 2;
            this.random_CorrectLabel.Text = "Correct";
            // 
            // random_CurrentStudent
            // 
            this.random_CurrentStudent.AutoSize = true;
            this.random_CurrentStudent.BackColor = System.Drawing.SystemColors.ControlDark;
            this.random_CurrentStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.random_CurrentStudent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.random_CurrentStudent.Location = new System.Drawing.Point(288, 58);
            this.random_CurrentStudent.Name = "random_CurrentStudent";
            this.random_CurrentStudent.Size = new System.Drawing.Size(254, 38);
            this.random_CurrentStudent.TabIndex = 1;
            this.random_CurrentStudent.Text = "<StudentName>";
            this.random_CurrentStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // random_ToMainMenu
            // 
            this.random_ToMainMenu.Location = new System.Drawing.Point(10, 12);
            this.random_ToMainMenu.Name = "random_ToMainMenu";
            this.random_ToMainMenu.Size = new System.Drawing.Size(75, 23);
            this.random_ToMainMenu.TabIndex = 0;
            this.random_ToMainMenu.Text = "Menu";
            this.random_ToMainMenu.UseVisualStyleBackColor = true;
            this.random_ToMainMenu.Click += new System.EventHandler(this.random_ToMainMenu_Click);
            // 
            // editorScreen
            // 
            this.editorScreen.Controls.Add(this.editor_classGrid);
            this.editorScreen.Controls.Add(this.editor_NumStudentsLabel);
            this.editorScreen.Controls.Add(this.editor_NumPeopleInClass);
            this.editorScreen.Controls.Add(this.editor_RevertChangesButton);
            this.editorScreen.Controls.Add(this.editor_SaveChanges);
            this.editorScreen.Controls.Add(this.editor_ResetQueueButton);
            this.editorScreen.Controls.Add(this.editor_ClassName);
            this.editorScreen.Controls.Add(this.editor_Label1);
            this.editorScreen.Controls.Add(this.editor_ToMainMenu);
            this.editorScreen.Location = new System.Drawing.Point(0, 0);
            this.editorScreen.Name = "editorScreen";
            this.editorScreen.Size = new System.Drawing.Size(782, 594);
            this.editorScreen.TabIndex = 2;
            // 
            // editor_NumStudentsLabel
            // 
            this.editor_NumStudentsLabel.AutoSize = true;
            this.editor_NumStudentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editor_NumStudentsLabel.Location = new System.Drawing.Point(649, 70);
            this.editor_NumStudentsLabel.Name = "editor_NumStudentsLabel";
            this.editor_NumStudentsLabel.Size = new System.Drawing.Size(23, 25);
            this.editor_NumStudentsLabel.TabIndex = 7;
            this.editor_NumStudentsLabel.Text = "3";
            // 
            // editor_NumPeopleInClass
            // 
            this.editor_NumPeopleInClass.AutoSize = true;
            this.editor_NumPeopleInClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editor_NumPeopleInClass.Location = new System.Drawing.Point(531, 69);
            this.editor_NumPeopleInClass.Name = "editor_NumPeopleInClass";
            this.editor_NumPeopleInClass.Size = new System.Drawing.Size(112, 25);
            this.editor_NumPeopleInClass.TabIndex = 6;
            this.editor_NumPeopleInClass.Text = "Class Size:";
            // 
            // editor_RevertChangesButton
            // 
            this.editor_RevertChangesButton.Location = new System.Drawing.Point(178, 489);
            this.editor_RevertChangesButton.Name = "editor_RevertChangesButton";
            this.editor_RevertChangesButton.Size = new System.Drawing.Size(124, 26);
            this.editor_RevertChangesButton.TabIndex = 5;
            this.editor_RevertChangesButton.Text = "Revert Changes";
            this.editor_RevertChangesButton.UseVisualStyleBackColor = true;
            // 
            // editor_SaveChanges
            // 
            this.editor_SaveChanges.Location = new System.Drawing.Point(469, 488);
            this.editor_SaveChanges.Name = "editor_SaveChanges";
            this.editor_SaveChanges.Size = new System.Drawing.Size(113, 29);
            this.editor_SaveChanges.TabIndex = 4;
            this.editor_SaveChanges.Text = "Save Changes";
            this.editor_SaveChanges.UseVisualStyleBackColor = true;
            this.editor_SaveChanges.Click += new System.EventHandler(this.editor_SaveChanges_Click);
            // 
            // editor_ResetQueueButton
            // 
            this.editor_ResetQueueButton.Location = new System.Drawing.Point(321, 463);
            this.editor_ResetQueueButton.Name = "editor_ResetQueueButton";
            this.editor_ResetQueueButton.Size = new System.Drawing.Size(126, 23);
            this.editor_ResetQueueButton.TabIndex = 3;
            this.editor_ResetQueueButton.Text = "Reset Queue";
            this.editor_ResetQueueButton.UseVisualStyleBackColor = true;
            // 
            // editor_ClassName
            // 
            this.editor_ClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editor_ClassName.Location = new System.Drawing.Point(256, 66);
            this.editor_ClassName.Name = "editor_ClassName";
            this.editor_ClassName.Size = new System.Drawing.Size(269, 30);
            this.editor_ClassName.TabIndex = 2;
            this.editor_ClassName.Text = "[Class Name Here]";
            this.editor_ClassName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // editor_Label1
            // 
            this.editor_Label1.AutoSize = true;
            this.editor_Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editor_Label1.Location = new System.Drawing.Point(125, 70);
            this.editor_Label1.Name = "editor_Label1";
            this.editor_Label1.Size = new System.Drawing.Size(125, 25);
            this.editor_Label1.TabIndex = 1;
            this.editor_Label1.Text = "Class Name:";
            // 
            // editor_ToMainMenu
            // 
            this.editor_ToMainMenu.Location = new System.Drawing.Point(12, 12);
            this.editor_ToMainMenu.Name = "editor_ToMainMenu";
            this.editor_ToMainMenu.Size = new System.Drawing.Size(75, 23);
            this.editor_ToMainMenu.TabIndex = 0;
            this.editor_ToMainMenu.Text = "Main Menu";
            this.editor_ToMainMenu.UseVisualStyleBackColor = true;
            this.editor_ToMainMenu.Click += new System.EventHandler(this.editor_ToMainMenu_Click_1);
            // 
            // helpScreen
            // 
            this.helpScreen.Controls.Add(this.help_ToMenuButton);
            this.helpScreen.Location = new System.Drawing.Point(2, 0);
            this.helpScreen.Name = "helpScreen";
            this.helpScreen.Size = new System.Drawing.Size(778, 653);
            this.helpScreen.TabIndex = 3;
            // 
            // help_ToMenuButton
            // 
            this.help_ToMenuButton.Location = new System.Drawing.Point(0, 0);
            this.help_ToMenuButton.Name = "help_ToMenuButton";
            this.help_ToMenuButton.Size = new System.Drawing.Size(75, 23);
            this.help_ToMenuButton.TabIndex = 0;
            this.help_ToMenuButton.Text = "Main Menu";
            this.help_ToMenuButton.UseVisualStyleBackColor = true;
            this.help_ToMenuButton.Click += new System.EventHandler(this.help_ToMenuButton_Click);
            // 
            // editor_classGrid
            // 
            this.editor_classGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.editor_classGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn,
            this.correctColumn,
            this.incorrectColumn,
            this.absentColumn});
            this.editor_classGrid.Location = new System.Drawing.Point(130, 118);
            this.editor_classGrid.Name = "editor_classGrid";
            this.editor_classGrid.RowTemplate.Height = 24;
            this.editor_classGrid.Size = new System.Drawing.Size(542, 150);
            this.editor_classGrid.TabIndex = 4;
            this.editor_classGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.Width = 200;
            // 
            // correctColumn
            // 
            this.correctColumn.HeaderText = "Correct";
            this.correctColumn.Name = "correctColumn";
            this.correctColumn.Width = 75;
            // 
            // incorrectColumn
            // 
            this.incorrectColumn.HeaderText = "Incorrect";
            this.incorrectColumn.Name = "incorrectColumn";
            this.incorrectColumn.Width = 75;
            // 
            // absentColumn
            // 
            this.absentColumn.HeaderText = "Absent";
            this.absentColumn.Name = "absentColumn";
            this.absentColumn.Width = 75;
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(WindowsFormsApplication1.Form1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 653);
            this.Controls.Add(this.editorScreen);
            this.Controls.Add(this.helpScreen);
            this.Controls.Add(this.menuScreen);
            this.Controls.Add(this.randomizationScreen);
            this.Name = "Form1";
            this.Text = "Pick-A-Student (Development Version)";
            this.menuScreen.ResumeLayout(false);
            this.menuScreen.PerformLayout();
            this.randomizationScreen.ResumeLayout(false);
            this.randomizationScreen.PerformLayout();
            this.editorScreen.ResumeLayout(false);
            this.editorScreen.PerformLayout();
            this.helpScreen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editor_classGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuScreen;
        private System.Windows.Forms.Label menu_NameLabel;
        private System.Windows.Forms.Button menu_QuitButton;
        private System.Windows.Forms.Button menu_ToHelpButton;
        private System.Windows.Forms.Button menu_ExportButton;
        private System.Windows.Forms.Button menu_ImportButton;
        private System.Windows.Forms.Button menu_ToEditorButton;
        private System.Windows.Forms.Button menu_ToRandomButton;
        private System.Windows.Forms.Panel randomizationScreen;
        private System.Windows.Forms.Button random_ToMainMenu;
        private System.Windows.Forms.Label random_CurrentStudent;
        private System.Windows.Forms.Button random_NextStudent;
        private System.Windows.Forms.Label random_NumStudents;
        private System.Windows.Forms.Label random_RemainingStudents;
        private System.Windows.Forms.Label random_IncorrectLabel;
        private System.Windows.Forms.Label random_AbsentLabel;
        private System.Windows.Forms.Label random_CorrectLabel;
        private System.Windows.Forms.Panel editorScreen;
        private System.Windows.Forms.Button editor_ToMainMenu;
        private System.Windows.Forms.Panel helpScreen;
        private System.Windows.Forms.Button help_ToMenuButton;
        private System.Windows.Forms.Label editor_NumStudentsLabel;
        private System.Windows.Forms.Label editor_NumPeopleInClass;
        private System.Windows.Forms.Button editor_RevertChangesButton;
        private System.Windows.Forms.Button editor_SaveChanges;
        private System.Windows.Forms.Button editor_ResetQueueButton;
        private System.Windows.Forms.TextBox editor_ClassName;
        private System.Windows.Forms.Label editor_Label1;
        private System.Windows.Forms.DataGridView editor_classGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correctColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incorrectColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn absentColumn;
        private System.Windows.Forms.BindingSource form1BindingSource;
    }
}

