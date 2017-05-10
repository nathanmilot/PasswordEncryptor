namespace PassGen
{
    partial class PassEncryptorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassEncryptorForm));
            this.Btn_View = new System.Windows.Forms.Button();
            this.Btn_Copy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.Txt_Result = new System.Windows.Forms.TextBox();
            this.Panel_Main = new System.Windows.Forms.Panel();
            this.Btn_Settings = new System.Windows.Forms.Button();
            this.Panel_Settings = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Settings_Cancel = new System.Windows.Forms.Button();
            this.Btn_Settings_Apply = new System.Windows.Forms.Button();
            this.Cmb_Encryption_Type = new System.Windows.Forms.ComboBox();
            this.Cmb_Output_Length = new System.Windows.Forms.ComboBox();
            this.Panel_Main.SuspendLayout();
            this.Panel_Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_View
            // 
            this.Btn_View.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_View.BackgroundImage")));
            this.Btn_View.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_View.Location = new System.Drawing.Point(547, 69);
            this.Btn_View.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_View.Name = "Btn_View";
            this.Btn_View.Size = new System.Drawing.Size(67, 34);
            this.Btn_View.TabIndex = 1;
            this.Btn_View.UseVisualStyleBackColor = true;
            this.Btn_View.Click += new System.EventHandler(this.Btn_View_Click);
            this.Btn_View.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Btn_View_KeyUp);
            this.Btn_View.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_View_MouseDown);
            this.Btn_View.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_View_MouseUp);
            // 
            // Btn_Copy
            // 
            this.Btn_Copy.Location = new System.Drawing.Point(547, 118);
            this.Btn_Copy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Copy.Name = "Btn_Copy";
            this.Btn_Copy.Size = new System.Drawing.Size(67, 34);
            this.Btn_Copy.TabIndex = 3;
            this.Btn_Copy.Text = "Copy";
            this.Btn_Copy.UseVisualStyleBackColor = true;
            this.Btn_Copy.Click += new System.EventHandler(this.Btn_Copy_Click);
            this.Btn_Copy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Btn_Copy_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Encryption";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_Password
            // 
            this.Txt_Password.Location = new System.Drawing.Point(128, 74);
            this.Txt_Password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.PasswordChar = '•';
            this.Txt_Password.Size = new System.Drawing.Size(409, 22);
            this.Txt_Password.TabIndex = 0;
            this.Txt_Password.TextChanged += new System.EventHandler(this.Txt_Password_TextChanged);
            // 
            // Txt_Result
            // 
            this.Txt_Result.Location = new System.Drawing.Point(128, 123);
            this.Txt_Result.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_Result.Name = "Txt_Result";
            this.Txt_Result.ReadOnly = true;
            this.Txt_Result.Size = new System.Drawing.Size(409, 22);
            this.Txt_Result.TabIndex = 6;
            this.Txt_Result.TabStop = false;
            // 
            // Panel_Main
            // 
            this.Panel_Main.Controls.Add(this.Btn_Settings);
            this.Panel_Main.Controls.Add(this.Txt_Result);
            this.Panel_Main.Controls.Add(this.Txt_Password);
            this.Panel_Main.Controls.Add(this.Btn_View);
            this.Panel_Main.Controls.Add(this.label2);
            this.Panel_Main.Controls.Add(this.Btn_Copy);
            this.Panel_Main.Controls.Add(this.label1);
            this.Panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Main.Location = new System.Drawing.Point(0, 0);
            this.Panel_Main.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel_Main.Name = "Panel_Main";
            this.Panel_Main.Size = new System.Drawing.Size(703, 224);
            this.Panel_Main.TabIndex = 7;
            // 
            // Btn_Settings
            // 
            this.Btn_Settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_Settings.BackgroundImage")));
            this.Btn_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Settings.Location = new System.Drawing.Point(659, 4);
            this.Btn_Settings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Settings.Name = "Btn_Settings";
            this.Btn_Settings.Size = new System.Drawing.Size(40, 37);
            this.Btn_Settings.TabIndex = 4;
            this.Btn_Settings.UseVisualStyleBackColor = true;
            this.Btn_Settings.Click += new System.EventHandler(this.Btn_Settings_Click);
            // 
            // Panel_Settings
            // 
            this.Panel_Settings.Controls.Add(this.label4);
            this.Panel_Settings.Controls.Add(this.label3);
            this.Panel_Settings.Controls.Add(this.Btn_Settings_Cancel);
            this.Panel_Settings.Controls.Add(this.Btn_Settings_Apply);
            this.Panel_Settings.Controls.Add(this.Cmb_Encryption_Type);
            this.Panel_Settings.Controls.Add(this.Cmb_Output_Length);
            this.Panel_Settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Settings.Location = new System.Drawing.Point(0, 0);
            this.Panel_Settings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel_Settings.Name = "Panel_Settings";
            this.Panel_Settings.Size = new System.Drawing.Size(703, 224);
            this.Panel_Settings.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Encryption Type";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Minimum Output Length";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Btn_Settings_Cancel
            // 
            this.Btn_Settings_Cancel.Location = new System.Drawing.Point(389, 164);
            this.Btn_Settings_Cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Settings_Cancel.Name = "Btn_Settings_Cancel";
            this.Btn_Settings_Cancel.Size = new System.Drawing.Size(125, 32);
            this.Btn_Settings_Cancel.TabIndex = 7;
            this.Btn_Settings_Cancel.TabStop = false;
            this.Btn_Settings_Cancel.Text = "Cancel";
            this.Btn_Settings_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Settings_Cancel.Click += new System.EventHandler(this.Btn_Settings_Cancel_Click);
            // 
            // Btn_Settings_Apply
            // 
            this.Btn_Settings_Apply.Location = new System.Drawing.Point(248, 164);
            this.Btn_Settings_Apply.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Settings_Apply.Name = "Btn_Settings_Apply";
            this.Btn_Settings_Apply.Size = new System.Drawing.Size(125, 32);
            this.Btn_Settings_Apply.TabIndex = 6;
            this.Btn_Settings_Apply.TabStop = false;
            this.Btn_Settings_Apply.Text = "Apply";
            this.Btn_Settings_Apply.UseVisualStyleBackColor = true;
            this.Btn_Settings_Apply.Click += new System.EventHandler(this.Btn_Settings_Apply_Click);
            // 
            // Cmb_Encryption_Type
            // 
            this.Cmb_Encryption_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Encryption_Type.FormattingEnabled = true;
            this.Cmb_Encryption_Type.Location = new System.Drawing.Point(248, 96);
            this.Cmb_Encryption_Type.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cmb_Encryption_Type.Name = "Cmb_Encryption_Type";
            this.Cmb_Encryption_Type.Size = new System.Drawing.Size(265, 24);
            this.Cmb_Encryption_Type.TabIndex = 5;
            this.Cmb_Encryption_Type.TabStop = false;
            // 
            // Cmb_Output_Length
            // 
            this.Cmb_Output_Length.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Output_Length.FormattingEnabled = true;
            this.Cmb_Output_Length.Location = new System.Drawing.Point(248, 49);
            this.Cmb_Output_Length.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cmb_Output_Length.Name = "Cmb_Output_Length";
            this.Cmb_Output_Length.Size = new System.Drawing.Size(265, 24);
            this.Cmb_Output_Length.TabIndex = 4;
            this.Cmb_Output_Length.TabStop = false;
            // 
            // PassGenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 224);
            this.Controls.Add(this.Panel_Main);
            this.Controls.Add(this.Panel_Settings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PassGenForm";
            this.Text = "Password Generator";
            this.Panel_Main.ResumeLayout(false);
            this.Panel_Main.PerformLayout();
            this.Panel_Settings.ResumeLayout(false);
            this.Panel_Settings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_View;
        private System.Windows.Forms.Button Btn_Copy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.TextBox Txt_Result;
        private System.Windows.Forms.Panel Panel_Main;
        private System.Windows.Forms.Panel Panel_Settings;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Settings_Cancel;
        private System.Windows.Forms.Button Btn_Settings_Apply;
        private System.Windows.Forms.ComboBox Cmb_Encryption_Type;
        private System.Windows.Forms.ComboBox Cmb_Output_Length;
        private System.Windows.Forms.Button Btn_Settings;
    }
}

