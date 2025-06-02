namespace Student_management
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
            this.panel_side = new System.Windows.Forms.Panel();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.button_std = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_stdMenu = new System.Windows.Forms.Panel();
            this.button_registration = new System.Windows.Forms.Button();
            this.button_manageStudent = new System.Windows.Forms.Button();
            this.button_status = new System.Windows.Forms.Button();
            this.button_stdPrint = new System.Windows.Forms.Button();
            this.button_courses = new System.Windows.Forms.Button();
            this.panel_courses = new System.Windows.Forms.Panel();
            this.button_coursePrint = new System.Windows.Forms.Button();
            this.button_ManageCourse = new System.Windows.Forms.Button();
            this.button_newCourse = new System.Windows.Forms.Button();
            this.button_score = new System.Windows.Forms.Button();
            this.panel_score = new System.Windows.Forms.Panel();
            this.button_scorePrint = new System.Windows.Forms.Button();
            this.button_manageScore = new System.Windows.Forms.Button();
            this.button_newScore = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.panel_side.SuspendLayout();
            this.panel_stdMenu.SuspendLayout();
            this.panel_courses.SuspendLayout();
            this.panel_score.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_side
            // 
            this.panel_side.AutoScroll = true;
            this.panel_side.BackColor = System.Drawing.Color.Navy;
            this.panel_side.Controls.Add(this.button_exit);
            this.panel_side.Controls.Add(this.panel_score);
            this.panel_side.Controls.Add(this.button_score);
            this.panel_side.Controls.Add(this.panel_courses);
            this.panel_side.Controls.Add(this.button_courses);
            this.panel_side.Controls.Add(this.panel_stdMenu);
            this.panel_side.Controls.Add(this.flowLayoutPanel1);
            this.panel_side.Controls.Add(this.button_std);
            this.panel_side.Controls.Add(this.panel_logo);
            this.panel_side.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_side.Location = new System.Drawing.Point(0, 0);
            this.panel_side.Name = "panel_side";
            this.panel_side.Size = new System.Drawing.Size(250, 594);
            this.panel_side.TabIndex = 0;
            // 
            // panel_logo
            // 
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(224, 100);
            this.panel_logo.TabIndex = 0;
            // 
            // button_std
            // 
            this.button_std.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_std.FlatAppearance.BorderSize = 0;
            this.button_std.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_std.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_std.ForeColor = System.Drawing.Color.White;
            this.button_std.Location = new System.Drawing.Point(0, 100);
            this.button_std.Name = "button_std";
            this.button_std.Size = new System.Drawing.Size(224, 50);
            this.button_std.TabIndex = 1;
            this.button_std.Text = "Students";
            this.button_std.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_std.UseVisualStyleBackColor = true;
            this.button_std.Click += new System.EventHandler(this.button_std_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(221, 100);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel_stdMenu
            // 
            this.panel_stdMenu.Controls.Add(this.button_stdPrint);
            this.panel_stdMenu.Controls.Add(this.button_status);
            this.panel_stdMenu.Controls.Add(this.button_manageStudent);
            this.panel_stdMenu.Controls.Add(this.button_registration);
            this.panel_stdMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_stdMenu.Location = new System.Drawing.Point(0, 150);
            this.panel_stdMenu.Name = "panel_stdMenu";
            this.panel_stdMenu.Size = new System.Drawing.Size(224, 206);
            this.panel_stdMenu.TabIndex = 3;
            // 
            // button_registration
            // 
            this.button_registration.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_registration.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_registration.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button_registration.FlatAppearance.BorderSize = 0;
            this.button_registration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_registration.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_registration.ForeColor = System.Drawing.Color.White;
            this.button_registration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_registration.Location = new System.Drawing.Point(0, 0);
            this.button_registration.Name = "button_registration";
            this.button_registration.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button_registration.Size = new System.Drawing.Size(224, 50);
            this.button_registration.TabIndex = 0;
            this.button_registration.Text = "Registration";
            this.button_registration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_registration.UseVisualStyleBackColor = false;
            this.button_registration.Click += new System.EventHandler(this.button_registration_Click);
            // 
            // button_manageStudent
            // 
            this.button_manageStudent.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_manageStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_manageStudent.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button_manageStudent.FlatAppearance.BorderSize = 0;
            this.button_manageStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_manageStudent.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_manageStudent.ForeColor = System.Drawing.Color.White;
            this.button_manageStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_manageStudent.Location = new System.Drawing.Point(0, 50);
            this.button_manageStudent.Name = "button_manageStudent";
            this.button_manageStudent.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button_manageStudent.Size = new System.Drawing.Size(224, 50);
            this.button_manageStudent.TabIndex = 1;
            this.button_manageStudent.Text = "Manage Student";
            this.button_manageStudent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_manageStudent.UseVisualStyleBackColor = false;
            this.button_manageStudent.Click += new System.EventHandler(this.button_manageStudent_Click);
            // 
            // button_status
            // 
            this.button_status.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_status.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_status.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button_status.FlatAppearance.BorderSize = 0;
            this.button_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_status.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_status.ForeColor = System.Drawing.Color.White;
            this.button_status.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_status.Location = new System.Drawing.Point(0, 100);
            this.button_status.Name = "button_status";
            this.button_status.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button_status.Size = new System.Drawing.Size(224, 50);
            this.button_status.TabIndex = 2;
            this.button_status.Text = "Status";
            this.button_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_status.UseVisualStyleBackColor = false;
            this.button_status.Click += new System.EventHandler(this.button_status_Click);
            // 
            // button_stdPrint
            // 
            this.button_stdPrint.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_stdPrint.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_stdPrint.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button_stdPrint.FlatAppearance.BorderSize = 0;
            this.button_stdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_stdPrint.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stdPrint.ForeColor = System.Drawing.Color.White;
            this.button_stdPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_stdPrint.Location = new System.Drawing.Point(0, 150);
            this.button_stdPrint.Name = "button_stdPrint";
            this.button_stdPrint.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button_stdPrint.Size = new System.Drawing.Size(224, 50);
            this.button_stdPrint.TabIndex = 3;
            this.button_stdPrint.Text = "Print";
            this.button_stdPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_stdPrint.UseVisualStyleBackColor = false;
            this.button_stdPrint.Click += new System.EventHandler(this.button_stdPrint_Click);
            // 
            // button_courses
            // 
            this.button_courses.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_courses.FlatAppearance.BorderSize = 0;
            this.button_courses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_courses.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_courses.ForeColor = System.Drawing.Color.White;
            this.button_courses.Location = new System.Drawing.Point(0, 356);
            this.button_courses.Name = "button_courses";
            this.button_courses.Size = new System.Drawing.Size(224, 50);
            this.button_courses.TabIndex = 4;
            this.button_courses.Text = "Courses";
            this.button_courses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_courses.UseVisualStyleBackColor = true;
            this.button_courses.Click += new System.EventHandler(this.button_courses_Click);
            // 
            // panel_courses
            // 
            this.panel_courses.Controls.Add(this.button_coursePrint);
            this.panel_courses.Controls.Add(this.button_ManageCourse);
            this.panel_courses.Controls.Add(this.button_newCourse);
            this.panel_courses.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_courses.Location = new System.Drawing.Point(0, 406);
            this.panel_courses.Name = "panel_courses";
            this.panel_courses.Size = new System.Drawing.Size(224, 150);
            this.panel_courses.TabIndex = 5;
            // 
            // button_coursePrint
            // 
            this.button_coursePrint.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_coursePrint.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_coursePrint.FlatAppearance.BorderSize = 0;
            this.button_coursePrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_coursePrint.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_coursePrint.ForeColor = System.Drawing.Color.White;
            this.button_coursePrint.Location = new System.Drawing.Point(0, 100);
            this.button_coursePrint.Name = "button_coursePrint";
            this.button_coursePrint.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button_coursePrint.Size = new System.Drawing.Size(224, 50);
            this.button_coursePrint.TabIndex = 3;
            this.button_coursePrint.Text = "Print";
            this.button_coursePrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_coursePrint.UseVisualStyleBackColor = false;
            this.button_coursePrint.Click += new System.EventHandler(this.button_coursePrint_Click);
            // 
            // button_ManageCourse
            // 
            this.button_ManageCourse.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_ManageCourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_ManageCourse.FlatAppearance.BorderSize = 0;
            this.button_ManageCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ManageCourse.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ManageCourse.ForeColor = System.Drawing.Color.White;
            this.button_ManageCourse.Location = new System.Drawing.Point(0, 50);
            this.button_ManageCourse.Name = "button_ManageCourse";
            this.button_ManageCourse.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button_ManageCourse.Size = new System.Drawing.Size(224, 50);
            this.button_ManageCourse.TabIndex = 1;
            this.button_ManageCourse.Text = "Manage Course";
            this.button_ManageCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ManageCourse.UseVisualStyleBackColor = false;
            this.button_ManageCourse.Click += new System.EventHandler(this.button_ManageCourse_Click);
            // 
            // button_newCourse
            // 
            this.button_newCourse.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_newCourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_newCourse.FlatAppearance.BorderSize = 0;
            this.button_newCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_newCourse.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_newCourse.ForeColor = System.Drawing.Color.White;
            this.button_newCourse.Location = new System.Drawing.Point(0, 0);
            this.button_newCourse.Name = "button_newCourse";
            this.button_newCourse.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button_newCourse.Size = new System.Drawing.Size(224, 50);
            this.button_newCourse.TabIndex = 0;
            this.button_newCourse.Text = "New Course";
            this.button_newCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_newCourse.UseVisualStyleBackColor = false;
            this.button_newCourse.Click += new System.EventHandler(this.button_newCourse_Click);
            // 
            // button_score
            // 
            this.button_score.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_score.FlatAppearance.BorderSize = 0;
            this.button_score.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_score.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_score.ForeColor = System.Drawing.Color.White;
            this.button_score.Location = new System.Drawing.Point(0, 556);
            this.button_score.Name = "button_score";
            this.button_score.Size = new System.Drawing.Size(224, 50);
            this.button_score.TabIndex = 7;
            this.button_score.Text = "Score";
            this.button_score.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_score.UseVisualStyleBackColor = true;
            this.button_score.Click += new System.EventHandler(this.button_score_Click);
            // 
            // panel_score
            // 
            this.panel_score.Controls.Add(this.button_scorePrint);
            this.panel_score.Controls.Add(this.button_manageScore);
            this.panel_score.Controls.Add(this.button_newScore);
            this.panel_score.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_score.Location = new System.Drawing.Point(0, 606);
            this.panel_score.Name = "panel_score";
            this.panel_score.Size = new System.Drawing.Size(224, 150);
            this.panel_score.TabIndex = 8;
            // 
            // button_scorePrint
            // 
            this.button_scorePrint.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_scorePrint.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_scorePrint.FlatAppearance.BorderSize = 0;
            this.button_scorePrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_scorePrint.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_scorePrint.ForeColor = System.Drawing.Color.White;
            this.button_scorePrint.Location = new System.Drawing.Point(0, 100);
            this.button_scorePrint.Name = "button_scorePrint";
            this.button_scorePrint.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button_scorePrint.Size = new System.Drawing.Size(224, 50);
            this.button_scorePrint.TabIndex = 3;
            this.button_scorePrint.Text = "Print";
            this.button_scorePrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_scorePrint.UseVisualStyleBackColor = false;
            this.button_scorePrint.Click += new System.EventHandler(this.button_scorePrint_Click);
            // 
            // button_manageScore
            // 
            this.button_manageScore.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_manageScore.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_manageScore.FlatAppearance.BorderSize = 0;
            this.button_manageScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_manageScore.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_manageScore.ForeColor = System.Drawing.Color.White;
            this.button_manageScore.Location = new System.Drawing.Point(0, 50);
            this.button_manageScore.Name = "button_manageScore";
            this.button_manageScore.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button_manageScore.Size = new System.Drawing.Size(224, 50);
            this.button_manageScore.TabIndex = 1;
            this.button_manageScore.Text = "Manage Score";
            this.button_manageScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_manageScore.UseVisualStyleBackColor = false;
            this.button_manageScore.Click += new System.EventHandler(this.button_manageScore_Click);
            // 
            // button_newScore
            // 
            this.button_newScore.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_newScore.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_newScore.FlatAppearance.BorderSize = 0;
            this.button_newScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_newScore.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_newScore.ForeColor = System.Drawing.Color.White;
            this.button_newScore.Location = new System.Drawing.Point(0, 0);
            this.button_newScore.Name = "button_newScore";
            this.button_newScore.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button_newScore.Size = new System.Drawing.Size(224, 50);
            this.button_newScore.TabIndex = 0;
            this.button_newScore.Text = "New Score";
            this.button_newScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_newScore.UseVisualStyleBackColor = false;
            this.button_newScore.Click += new System.EventHandler(this.button_newScore_Click);
            // 
            // button_exit
            // 
            this.button_exit.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_exit.FlatAppearance.BorderSize = 0;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.ForeColor = System.Drawing.Color.White;
            this.button_exit.Location = new System.Drawing.Point(0, 756);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(224, 50);
            this.button_exit.TabIndex = 9;
            this.button_exit.Text = "Exit";
            this.button_exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_exit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 594);
            this.Controls.Add(this.panel_side);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximumSize = new System.Drawing.Size(1150, 650);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_side.ResumeLayout(false);
            this.panel_stdMenu.ResumeLayout(false);
            this.panel_courses.ResumeLayout(false);
            this.panel_score.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_side;
        private System.Windows.Forms.Button button_std;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Panel panel_stdMenu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button_registration;
        private System.Windows.Forms.Button button_stdPrint;
        private System.Windows.Forms.Button button_status;
        private System.Windows.Forms.Button button_manageStudent;
        private System.Windows.Forms.Button button_courses;
        private System.Windows.Forms.Button button_score;
        private System.Windows.Forms.Panel panel_courses;
        private System.Windows.Forms.Button button_coursePrint;
        private System.Windows.Forms.Button button_ManageCourse;
        private System.Windows.Forms.Button button_newCourse;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Panel panel_score;
        private System.Windows.Forms.Button button_scorePrint;
        private System.Windows.Forms.Button button_manageScore;
        private System.Windows.Forms.Button button_newScore;
    }
}

