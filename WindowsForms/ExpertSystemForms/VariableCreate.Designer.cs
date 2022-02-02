namespace WindowsForms.ExpertSystemForms
{
    partial class VariableCreate
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
            this.bt_Create = new System.Windows.Forms.Button();
            this.cb_Type = new System.Windows.Forms.ComboBox();
            this.lb_Name = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Value = new System.Windows.Forms.TextBox();
            this.lb_ObjectiveValues = new System.Windows.Forms.ListBox();
            this.bt_AddObjectiveValue = new System.Windows.Forms.Button();
            this.bt_RemoveObjectiveValue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_Create
            // 
            this.bt_Create.Location = new System.Drawing.Point(42, 203);
            this.bt_Create.Name = "bt_Create";
            this.bt_Create.Size = new System.Drawing.Size(94, 29);
            this.bt_Create.TabIndex = 0;
            this.bt_Create.Text = "Create";
            this.bt_Create.UseVisualStyleBackColor = true;
            this.bt_Create.Click += new System.EventHandler(this.bt_Create_Click);
            // 
            // cb_Type
            // 
            this.cb_Type.FormattingEnabled = true;
            this.cb_Type.Location = new System.Drawing.Point(42, 79);
            this.cb_Type.Name = "cb_Type";
            this.cb_Type.Size = new System.Drawing.Size(151, 28);
            this.cb_Type.TabIndex = 1;
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(51, 25);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(52, 20);
            this.lb_Name.TabIndex = 2;
            this.lb_Name.Text = "Name:";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(109, 25);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(125, 27);
            this.tb_Name.TabIndex = 3;
            // 
            // tb_Value
            // 
            this.tb_Value.Location = new System.Drawing.Point(42, 131);
            this.tb_Value.Name = "tb_Value";
            this.tb_Value.Size = new System.Drawing.Size(151, 27);
            this.tb_Value.TabIndex = 4;
            // 
            // lb_ObjectiveValues
            // 
            this.lb_ObjectiveValues.FormattingEnabled = true;
            this.lb_ObjectiveValues.ItemHeight = 20;
            this.lb_ObjectiveValues.Location = new System.Drawing.Point(272, 25);
            this.lb_ObjectiveValues.Name = "lb_ObjectiveValues";
            this.lb_ObjectiveValues.Size = new System.Drawing.Size(150, 104);
            this.lb_ObjectiveValues.TabIndex = 5;
            this.lb_ObjectiveValues.Tag = "ObjectiveValue";
            // 
            // bt_AddObjectiveValue
            // 
            this.bt_AddObjectiveValue.Location = new System.Drawing.Point(272, 145);
            this.bt_AddObjectiveValue.Name = "bt_AddObjectiveValue";
            this.bt_AddObjectiveValue.Size = new System.Drawing.Size(33, 29);
            this.bt_AddObjectiveValue.TabIndex = 6;
            this.bt_AddObjectiveValue.Tag = "ObjectiveValue";
            this.bt_AddObjectiveValue.Text = "+";
            this.bt_AddObjectiveValue.UseVisualStyleBackColor = true;
            // 
            // bt_RemoveObjectiveValue
            // 
            this.bt_RemoveObjectiveValue.Location = new System.Drawing.Point(389, 145);
            this.bt_RemoveObjectiveValue.Name = "bt_RemoveObjectiveValue";
            this.bt_RemoveObjectiveValue.Size = new System.Drawing.Size(33, 29);
            this.bt_RemoveObjectiveValue.TabIndex = 7;
            this.bt_RemoveObjectiveValue.Tag = "ObjectiveValue";
            this.bt_RemoveObjectiveValue.Text = "-";
            this.bt_RemoveObjectiveValue.UseVisualStyleBackColor = true;
            // 
            // VariableCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_RemoveObjectiveValue);
            this.Controls.Add(this.bt_AddObjectiveValue);
            this.Controls.Add(this.lb_ObjectiveValues);
            this.Controls.Add(this.tb_Value);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.cb_Type);
            this.Controls.Add(this.bt_Create);
            this.Name = "VariableCreate";
            this.Text = "VariableCreate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bt_Create;
        private ComboBox cb_Type;
        private Label lb_Name;
        private TextBox tb_Name;
        private TextBox tb_Value;
        private ListBox lb_ObjectiveValues;
        private Button bt_AddObjectiveValue;
        private Button bt_RemoveObjectiveValue;
    }
}