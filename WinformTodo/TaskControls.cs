using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformTodo
{
    public partial class TaskControls : UserControl
    {
        private Todo TaskData;
        public TaskControls(Todo Task)
        {
            InitializeComponent();
            TaskData = Task;

            lblDescription.Text = TaskData.TaskDescription;
            lblDueDate.Text = TaskData.DueDate.ToShortDateString();
        }



        private void TaskControls_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }
    }
}
