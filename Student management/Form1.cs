using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void customizeDesign() { 
        
            panel_stdMenu.Visible = false;
            panel_courses.Visible = false;
            panel_score.Visible = false;
        }

       private void hideSubMenu()
        {
            if (panel_stdMenu.Visible == true)
                panel_stdMenu.Visible = false;
            if (panel_courses.Visible == true)
                panel_courses.Visible = false;
            if (panel_score.Visible == true)
                panel_score.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void button_std_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_stdMenu);
        }
        #region  studentSubMenu
        private void button_registration_Click(object sender, EventArgs e)
        {

        }
        private void button_manageStudent_Click(object sender, EventArgs e)
        {

        }

        private void button_status_Click(object sender, EventArgs e)
        {

        }

        private void button_stdPrint_Click(object sender, EventArgs e)
        {

        }

        #endregion studentSubMenu


        private void button_courses_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_courses);
        }

        #region coursesSubMenu
        private void button_newCourse_Click(object sender, EventArgs e)
        {

        }

        private void button_ManageCourse_Click(object sender, EventArgs e)
        {

        }

        private void button_coursePrint_Click(object sender, EventArgs e)
        {

        }

        #endregion
        private void button_score_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_score);
        }

        #region scoreSubMenu

        private void button_newScore_Click(object sender, EventArgs e)
        {

        }

        private void button_manageScore_Click(object sender, EventArgs e)
        {

        }

        private void button_scorePrint_Click(object sender, EventArgs e)
        {

        }
        #endregion  scoreSubMenu

    }
}
