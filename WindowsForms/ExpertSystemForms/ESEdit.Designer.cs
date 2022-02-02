namespace WindowsForms.ExpertSystemForms
{
    partial class ESEdit
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
            this.lb_Variables = new System.Windows.Forms.ListBox();
            this.lb_Rules = new System.Windows.Forms.ListBox();
            this.bt_AddRule = new System.Windows.Forms.Button();
            this.bt_AddVariable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Variables
            // 
            this.lb_Variables.FormattingEnabled = true;
            this.lb_Variables.ItemHeight = 20;
            this.lb_Variables.Location = new System.Drawing.Point(45, 42);
            this.lb_Variables.Name = "lb_Variables";
            this.lb_Variables.Size = new System.Drawing.Size(150, 104);
            this.lb_Variables.TabIndex = 0;
            // 
            // lb_Rules
            // 
            this.lb_Rules.FormattingEnabled = true;
            this.lb_Rules.ItemHeight = 20;
            this.lb_Rules.Location = new System.Drawing.Point(259, 42);
            this.lb_Rules.Name = "lb_Rules";
            this.lb_Rules.Size = new System.Drawing.Size(150, 104);
            this.lb_Rules.TabIndex = 1;
            // 
            // bt_AddRule
            // 
            this.bt_AddRule.Location = new System.Drawing.Point(374, 152);
            this.bt_AddRule.Name = "bt_AddRule";
            this.bt_AddRule.Size = new System.Drawing.Size(35, 29);
            this.bt_AddRule.TabIndex = 2;
            this.bt_AddRule.Text = "+";
            this.bt_AddRule.UseVisualStyleBackColor = true;
            this.bt_AddRule.Click += new System.EventHandler(this.bt_AddRule_Click);
            // 
            // bt_AddVariable
            // 
            this.bt_AddVariable.Location = new System.Drawing.Point(45, 152);
            this.bt_AddVariable.Name = "bt_AddVariable";
            this.bt_AddVariable.Size = new System.Drawing.Size(35, 29);
            this.bt_AddVariable.TabIndex = 3;
            this.bt_AddVariable.Text = "+";
            this.bt_AddVariable.UseVisualStyleBackColor = true;
            // 
            // ESEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 309);
            this.Controls.Add(this.bt_AddVariable);
            this.Controls.Add(this.bt_AddRule);
            this.Controls.Add(this.lb_Rules);
            this.Controls.Add(this.lb_Variables);
            this.Name = "ESEdit";
            this.Text = "ES";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lb_Variables;
        private ListBox lb_Rules;
        private Button bt_AddRule;
        private Button bt_AddVariable;
    }
}