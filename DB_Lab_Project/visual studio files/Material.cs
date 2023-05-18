using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intial_form_1_
{
    public partial class Material : Form
    {
        String teacherUsername;
        String teacherName;
        String classroomID;
        public Material()
        {
            InitializeComponent();
        }
        public Material(String teacherName, String teacherUsername, String classroomID)
        {
            InitializeComponent();
            this.teacherName = teacherName;
            this.teacherUsername = teacherUsername;
            this.classroomID = classroomID;
        }
    }
}
