namespace MouseKeyboardActivityMonitor.Demo
{
    partial class TestFormHookListeners {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
                m_KeyboardHookManager.Dispose();
                m_MouseHookManager.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.labelMousePosition = new System.Windows.Forms.Label();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.labelWheel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxSuppressMouse = new System.Windows.Forms.CheckBox();
            this.checkBoxEnabled = new System.Windows.Forms.CheckBox();
            this.panelSeparator = new System.Windows.Forms.Panel();
            this.radioGlobal = new System.Windows.Forms.RadioButton();
            this.radioApplication = new System.Windows.Forms.RadioButton();
            this.checkBoxKeyUp = new System.Windows.Forms.CheckBox();
            this.checkBoxKeyPress = new System.Windows.Forms.CheckBox();
            this.checkBoxKeyDown = new System.Windows.Forms.CheckBox();
            this.checkBoxMouseWheel = new System.Windows.Forms.CheckBox();
            this.checkBoxMouseDoubleClick = new System.Windows.Forms.CheckBox();
            this.checkBoxOnMouseUp = new System.Windows.Forms.CheckBox();
            this.checkBoxOnMouseDown = new System.Windows.Forms.CheckBox();
            this.checkBoxOnMouseClick = new System.Windows.Forms.CheckBox();
            this.checkBoxOnMouseMove = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMousePosition
            // 
            this.labelMousePosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMousePosition.AutoSize = true;
            this.labelMousePosition.BackColor = System.Drawing.Color.White;
            this.labelMousePosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMousePosition.Location = new System.Drawing.Point(588, 91);
            this.labelMousePosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMousePosition.Name = "labelMousePosition";
            this.labelMousePosition.Size = new System.Drawing.Size(179, 20);
            this.labelMousePosition.TabIndex = 2;
            this.labelMousePosition.Text = "x={0:####}; y={1:####}";
            // 
            // textBoxLog
            // 
            this.textBoxLog.BackColor = System.Drawing.Color.White;
            this.textBoxLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLog.Location = new System.Drawing.Point(0, 326);
            this.textBoxLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(840, 371);
            this.textBoxLog.TabIndex = 5;
            this.textBoxLog.WordWrap = false;
            // 
            // labelWheel
            // 
            this.labelWheel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWheel.AutoSize = true;
            this.labelWheel.BackColor = System.Drawing.Color.White;
            this.labelWheel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWheel.Location = new System.Drawing.Point(588, 122);
            this.labelWheel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWheel.Name = "labelWheel";
            this.labelWheel.Size = new System.Drawing.Size(128, 20);
            this.labelWheel.TabIndex = 6;
            this.labelWheel.Text = "Wheel={0:####}";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.checkBoxSuppressMouse);
            this.groupBox2.Controls.Add(this.checkBoxEnabled);
            this.groupBox2.Controls.Add(this.panelSeparator);
            this.groupBox2.Controls.Add(this.radioGlobal);
            this.groupBox2.Controls.Add(this.radioApplication);
            this.groupBox2.Controls.Add(this.checkBoxKeyUp);
            this.groupBox2.Controls.Add(this.labelWheel);
            this.groupBox2.Controls.Add(this.checkBoxKeyPress);
            this.groupBox2.Controls.Add(this.labelMousePosition);
            this.groupBox2.Controls.Add(this.checkBoxKeyDown);
            this.groupBox2.Controls.Add(this.checkBoxMouseWheel);
            this.groupBox2.Controls.Add(this.checkBoxMouseDoubleClick);
            this.groupBox2.Controls.Add(this.checkBoxOnMouseUp);
            this.groupBox2.Controls.Add(this.checkBoxOnMouseDown);
            this.groupBox2.Controls.Add(this.checkBoxOnMouseClick);
            this.groupBox2.Controls.Add(this.checkBoxOnMouseMove);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(840, 326);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // checkBoxSuppressMouse
            // 
            this.checkBoxSuppressMouse.AutoSize = true;
            this.checkBoxSuppressMouse.Location = new System.Drawing.Point(592, 162);
            this.checkBoxSuppressMouse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxSuppressMouse.Name = "checkBoxSuppressMouse";
            this.checkBoxSuppressMouse.Size = new System.Drawing.Size(247, 24);
            this.checkBoxSuppressMouse.TabIndex = 13;
            this.checkBoxSuppressMouse.Text = "Suppress Right Mouse Click";
            this.checkBoxSuppressMouse.UseVisualStyleBackColor = true;
            this.checkBoxSuppressMouse.CheckedChanged += new System.EventHandler(this.checkBoxSuppressMouse_CheckedChanged);
            // 
            // checkBoxEnabled
            // 
            this.checkBoxEnabled.AutoSize = true;
            this.checkBoxEnabled.Checked = true;
            this.checkBoxEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEnabled.Location = new System.Drawing.Point(350, 22);
            this.checkBoxEnabled.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxEnabled.Name = "checkBoxEnabled";
            this.checkBoxEnabled.Size = new System.Drawing.Size(95, 24);
            this.checkBoxEnabled.TabIndex = 12;
            this.checkBoxEnabled.Text = "Enabled";
            this.checkBoxEnabled.UseVisualStyleBackColor = true;
            this.checkBoxEnabled.CheckedChanged += new System.EventHandler(this.checkBoxEnabled_CheckedChanged);
            // 
            // panelSeparator
            // 
            this.panelSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSeparator.BackColor = System.Drawing.Color.White;
            this.panelSeparator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSeparator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelSeparator.Location = new System.Drawing.Point(9, 57);
            this.panelSeparator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSeparator.Name = "panelSeparator";
            this.panelSeparator.Size = new System.Drawing.Size(812, 0);
            this.panelSeparator.TabIndex = 11;
            // 
            // radioGlobal
            // 
            this.radioGlobal.AutoSize = true;
            this.radioGlobal.BackColor = System.Drawing.Color.White;
            this.radioGlobal.Checked = true;
            this.radioGlobal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGlobal.Location = new System.Drawing.Point(192, 20);
            this.radioGlobal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioGlobal.Name = "radioGlobal";
            this.radioGlobal.Size = new System.Drawing.Size(131, 24);
            this.radioGlobal.TabIndex = 10;
            this.radioGlobal.TabStop = true;
            this.radioGlobal.Text = "Global hooks";
            this.radioGlobal.UseVisualStyleBackColor = false;
            this.radioGlobal.CheckedChanged += new System.EventHandler(this.radioHooksType_CheckedChanged);
            // 
            // radioApplication
            // 
            this.radioApplication.AutoSize = true;
            this.radioApplication.BackColor = System.Drawing.Color.White;
            this.radioApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioApplication.Location = new System.Drawing.Point(18, 20);
            this.radioApplication.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioApplication.Name = "radioApplication";
            this.radioApplication.Size = new System.Drawing.Size(165, 24);
            this.radioApplication.TabIndex = 9;
            this.radioApplication.Text = "Application hooks";
            this.radioApplication.UseVisualStyleBackColor = false;
            this.radioApplication.CheckedChanged += new System.EventHandler(this.radioHooksType_CheckedChanged);
            // 
            // checkBoxKeyUp
            // 
            this.checkBoxKeyUp.AutoSize = true;
            this.checkBoxKeyUp.BackColor = System.Drawing.Color.White;
            this.checkBoxKeyUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxKeyUp.Location = new System.Drawing.Point(284, 162);
            this.checkBoxKeyUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxKeyUp.Name = "checkBoxKeyUp";
            this.checkBoxKeyUp.Size = new System.Drawing.Size(84, 24);
            this.checkBoxKeyUp.TabIndex = 8;
            this.checkBoxKeyUp.Text = "KeyUp";
            this.checkBoxKeyUp.UseVisualStyleBackColor = false;
            this.checkBoxKeyUp.CheckedChanged += new System.EventHandler(this.checkBoxKeyUp_CheckedChanged);
            // 
            // checkBoxKeyPress
            // 
            this.checkBoxKeyPress.AutoSize = true;
            this.checkBoxKeyPress.BackColor = System.Drawing.Color.White;
            this.checkBoxKeyPress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxKeyPress.Location = new System.Drawing.Point(284, 125);
            this.checkBoxKeyPress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxKeyPress.Name = "checkBoxKeyPress";
            this.checkBoxKeyPress.Size = new System.Drawing.Size(107, 24);
            this.checkBoxKeyPress.TabIndex = 7;
            this.checkBoxKeyPress.Text = "KeyPress";
            this.checkBoxKeyPress.UseVisualStyleBackColor = false;
            this.checkBoxKeyPress.CheckedChanged += new System.EventHandler(this.checkBoxKeyPress_CheckedChanged);
            // 
            // checkBoxKeyDown
            // 
            this.checkBoxKeyDown.AutoSize = true;
            this.checkBoxKeyDown.BackColor = System.Drawing.Color.White;
            this.checkBoxKeyDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxKeyDown.Location = new System.Drawing.Point(284, 89);
            this.checkBoxKeyDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxKeyDown.Name = "checkBoxKeyDown";
            this.checkBoxKeyDown.Size = new System.Drawing.Size(106, 24);
            this.checkBoxKeyDown.TabIndex = 6;
            this.checkBoxKeyDown.Text = "KeyDown";
            this.checkBoxKeyDown.UseVisualStyleBackColor = false;
            this.checkBoxKeyDown.CheckedChanged += new System.EventHandler(this.checkBoxKeyDown_CheckedChanged);
            // 
            // checkBoxMouseWheel
            // 
            this.checkBoxMouseWheel.AutoSize = true;
            this.checkBoxMouseWheel.BackColor = System.Drawing.Color.White;
            this.checkBoxMouseWheel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMouseWheel.Location = new System.Drawing.Point(18, 268);
            this.checkBoxMouseWheel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxMouseWheel.Name = "checkBoxMouseWheel";
            this.checkBoxMouseWheel.Size = new System.Drawing.Size(132, 24);
            this.checkBoxMouseWheel.TabIndex = 5;
            this.checkBoxMouseWheel.Text = "MouseWheel";
            this.checkBoxMouseWheel.UseVisualStyleBackColor = false;
            this.checkBoxMouseWheel.CheckedChanged += new System.EventHandler(this.checkBoxMouseWheel_CheckedChanged);
            // 
            // checkBoxMouseDoubleClick
            // 
            this.checkBoxMouseDoubleClick.AutoSize = true;
            this.checkBoxMouseDoubleClick.BackColor = System.Drawing.Color.White;
            this.checkBoxMouseDoubleClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMouseDoubleClick.Location = new System.Drawing.Point(18, 231);
            this.checkBoxMouseDoubleClick.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxMouseDoubleClick.Name = "checkBoxMouseDoubleClick";
            this.checkBoxMouseDoubleClick.Size = new System.Drawing.Size(175, 24);
            this.checkBoxMouseDoubleClick.TabIndex = 4;
            this.checkBoxMouseDoubleClick.Text = "MouseDoubleClick";
            this.checkBoxMouseDoubleClick.UseVisualStyleBackColor = false;
            this.checkBoxMouseDoubleClick.CheckedChanged += new System.EventHandler(this.checkBoxMouseDoubleClick_CheckedChanged);
            // 
            // checkBoxOnMouseUp
            // 
            this.checkBoxOnMouseUp.AutoSize = true;
            this.checkBoxOnMouseUp.BackColor = System.Drawing.Color.White;
            this.checkBoxOnMouseUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOnMouseUp.Location = new System.Drawing.Point(18, 198);
            this.checkBoxOnMouseUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxOnMouseUp.Name = "checkBoxOnMouseUp";
            this.checkBoxOnMouseUp.Size = new System.Drawing.Size(106, 24);
            this.checkBoxOnMouseUp.TabIndex = 3;
            this.checkBoxOnMouseUp.Text = "MouseUp";
            this.checkBoxOnMouseUp.UseVisualStyleBackColor = false;
            this.checkBoxOnMouseUp.CheckedChanged += new System.EventHandler(this.checkBoxOnMouseUp_CheckedChanged);
            // 
            // checkBoxOnMouseDown
            // 
            this.checkBoxOnMouseDown.AutoSize = true;
            this.checkBoxOnMouseDown.BackColor = System.Drawing.Color.White;
            this.checkBoxOnMouseDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOnMouseDown.Location = new System.Drawing.Point(18, 162);
            this.checkBoxOnMouseDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxOnMouseDown.Name = "checkBoxOnMouseDown";
            this.checkBoxOnMouseDown.Size = new System.Drawing.Size(128, 24);
            this.checkBoxOnMouseDown.TabIndex = 2;
            this.checkBoxOnMouseDown.Text = "MouseDown";
            this.checkBoxOnMouseDown.UseVisualStyleBackColor = false;
            this.checkBoxOnMouseDown.CheckedChanged += new System.EventHandler(this.checkBoxOnMouseDown_CheckedChanged);
            // 
            // checkBoxOnMouseClick
            // 
            this.checkBoxOnMouseClick.AutoSize = true;
            this.checkBoxOnMouseClick.BackColor = System.Drawing.Color.White;
            this.checkBoxOnMouseClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOnMouseClick.Location = new System.Drawing.Point(18, 125);
            this.checkBoxOnMouseClick.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxOnMouseClick.Name = "checkBoxOnMouseClick";
            this.checkBoxOnMouseClick.Size = new System.Drawing.Size(122, 24);
            this.checkBoxOnMouseClick.TabIndex = 1;
            this.checkBoxOnMouseClick.Text = "MouseClick";
            this.checkBoxOnMouseClick.UseVisualStyleBackColor = false;
            this.checkBoxOnMouseClick.CheckedChanged += new System.EventHandler(this.checkBoxOnMouseClick_CheckedChanged);
            // 
            // checkBoxOnMouseMove
            // 
            this.checkBoxOnMouseMove.AutoSize = true;
            this.checkBoxOnMouseMove.BackColor = System.Drawing.Color.White;
            this.checkBoxOnMouseMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOnMouseMove.Location = new System.Drawing.Point(18, 89);
            this.checkBoxOnMouseMove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxOnMouseMove.Name = "checkBoxOnMouseMove";
            this.checkBoxOnMouseMove.Size = new System.Drawing.Size(125, 24);
            this.checkBoxOnMouseMove.TabIndex = 0;
            this.checkBoxOnMouseMove.Text = "MouseMove";
            this.checkBoxOnMouseMove.UseVisualStyleBackColor = false;
            this.checkBoxOnMouseMove.CheckedChanged += new System.EventHandler(this.checkBoxOnMouseMove_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(618, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 36);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TestFormHookListeners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 697);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TestFormHookListeners";
            this.Text = "MouseLogger - EarlyDev";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMousePosition;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Label labelWheel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxKeyUp;
        private System.Windows.Forms.CheckBox checkBoxKeyPress;
        private System.Windows.Forms.CheckBox checkBoxKeyDown;
        private System.Windows.Forms.CheckBox checkBoxMouseWheel;
        private System.Windows.Forms.CheckBox checkBoxMouseDoubleClick;
        private System.Windows.Forms.CheckBox checkBoxOnMouseUp;
        private System.Windows.Forms.CheckBox checkBoxOnMouseDown;
        private System.Windows.Forms.CheckBox checkBoxOnMouseClick;
        private System.Windows.Forms.CheckBox checkBoxOnMouseMove;
        private System.Windows.Forms.RadioButton radioApplication;
        private System.Windows.Forms.Panel panelSeparator;
        private System.Windows.Forms.RadioButton radioGlobal;
        private System.Windows.Forms.CheckBox checkBoxEnabled;
        private System.Windows.Forms.CheckBox checkBoxSuppressMouse;
        private System.Windows.Forms.Button button1;
    }
}