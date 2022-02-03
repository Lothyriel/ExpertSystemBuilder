namespace WindowsForms.ExpertSystemForms
{
    partial class RuleCreate
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
            this.tb_TargetValue = new System.Windows.Forms.TextBox();
            this.cb_Variables = new System.Windows.Forms.ComboBox();
            this.cb_OperationTypes = new System.Windows.Forms.ComboBox();
            this.bt_Create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_TargetValue
            // 
            this.tb_TargetValue.Location = new System.Drawing.Point(398, 24);
            this.tb_TargetValue.Name = "tb_TargetValue";
            this.tb_TargetValue.Size = new System.Drawing.Size(125, 27);
            this.tb_TargetValue.TabIndex = 0;
            this.tb_TargetValue.TextChanged += new System.EventHandler(this.tb_TargetValue_TextChanged);
            // 
            // cb_Variables
            // 
            this.cb_Variables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Variables.FormattingEnabled = true;
            this.cb_Variables.Location = new System.Drawing.Point(47, 23);
            this.cb_Variables.Name = "cb_Variables";
            this.cb_Variables.Size = new System.Drawing.Size(151, 28);
            this.cb_Variables.TabIndex = 1;
            // 
            // cb_OperationTypes
            // 
            this.cb_OperationTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_OperationTypes.FormattingEnabled = true;
            this.cb_OperationTypes.Location = new System.Drawing.Point(221, 23);
            this.cb_OperationTypes.Name = "cb_OperationTypes";
            this.cb_OperationTypes.Size = new System.Drawing.Size(151, 28);
            this.cb_OperationTypes.TabIndex = 2;
            // 
            // bt_Create
            // 
            this.bt_Create.Location = new System.Drawing.Point(249, 81);
            this.bt_Create.Name = "bt_Create";
            this.bt_Create.Size = new System.Drawing.Size(94, 29);
            this.bt_Create.TabIndex = 3;
            this.bt_Create.Text = "Create";
            this.bt_Create.UseVisualStyleBackColor = true;
            this.bt_Create.Click += new System.EventHandler(this.bt_Create_Click);
            // 
            // RuleCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_Create);
            this.Controls.Add(this.cb_OperationTypes);
            this.Controls.Add(this.cb_Variables);
            this.Controls.Add(this.tb_TargetValue);
            this.Name = "RuleCreate";
            this.Text = "RuleCreate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_TargetValue;
        private ComboBox cb_Variables;
        private ComboBox cb_OperationTypes;
        private Button bt_Create;
    }
}