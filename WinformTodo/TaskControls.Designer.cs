namespace WinformTodo
{
    partial class TaskControls
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskControls));
            button1 = new Button();
            label2 = new Label();
            lblDueDate = new Label();
            label4 = new Label();
            lblDescription = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // lblDueDate
            // 
            resources.ApplyResources(lblDueDate, "lblDueDate");
            lblDueDate.Name = "lblDueDate";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // lblDescription
            // 
            resources.ApplyResources(lblDescription, "lblDescription");
            lblDescription.Name = "lblDescription";
            lblDescription.Click += lblDescription_Click;
            // 
            // TaskControls
            // 
            AutoScaleMode = AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            Controls.Add(lblDescription);
            Controls.Add(label4);
            Controls.Add(lblDueDate);
            Controls.Add(label2);
            Controls.Add(button1);
            Name = "TaskControls";
            Load += TaskControls_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private Label lblDueDate;
        private Label label4;
        private Label lblDescription;
    }
}
