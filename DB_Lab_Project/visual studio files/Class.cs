﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using MyApplication;

namespace intial_form_1_
{
    public partial class Class : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        String teacherUsername;
        String teacherName;
        String classroomID;
        public Class()
        {
            InitializeComponent();
        }
        //parameterized constructor that accepts the teacher's username and class code
        public Class(String teacherName, String teacherUsername, String classroomID)
        {
            InitializeComponent();
            //Set the teacher's username and class code
            this.teacherUsername = teacherUsername;
            this.classroomID = classroomID;
            this.teacherName = teacherName;
        }
        

        private void Class_Load(object sender, EventArgs e)
        {
         //change the name of the classroom to the class name of the class code received
            try
            {
                //MessageBox.Show("Class code is " + classCode);
                 cn = new SqlConnection(dbcon.MyConnection());
                 cn.Open();
                 cm = new SqlCommand("select * from Classroom where classroomID = @classroomID", cn);
                 cm.Parameters.AddWithValue("@classroomID", classroomID); //this is the class code received
                 dr = cm.ExecuteReader();
                 dr.Read();
                 if (dr.HasRows)
                 {
                     classroomName.Text = dr["classroomName"].ToString();
                     teacherNameLabel.Text = "Name: " + teacherName;
                     //
                 }
                 else
                 {
                     MessageBox.Show("No class found");
                     this.Close();
                 }
                 dr.Close();
                 cn.Close();
            }
            catch (Exception ex)
            {
                //Show the error message
                MessageBox.Show(ex.Message);
            }
        }

        private void createAssignmentButton_Clicked(object sender, EventArgs e)
        {
            this.Hide();
            Assignments assignments = new Assignments(teacherUsername, classroomID);
            assignments.Show();
        }

        private void Class_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            classroom classroom = new classroom(teacherName, teacherUsername);
            classroom.Show();
        }
        //function that changes the name of classroom to the clas name of class code received


    }
}