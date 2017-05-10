using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PassGen {
    public partial class PassEncryptorForm : Form {
        private enum EncryptionType { Custom = 0, CustomHex = 1, CustomHex2 = 2, Sha1 = 3, Sha256 = 4, Sha512 = 5 };
        private EncryptionType CurrentEncryption;
        private int OutputLength;

        public PassEncryptorForm() {
            InitializeComponent();
            CurrentEncryption = EncryptionType.Custom;
            string[] EncriptionNames = new string[] { "Custom", "CustomHex", "CustomHex2", "Sha1", "Shaw256", "Shaw512" };
            Cmb_Encryption_Type.DataSource = EncriptionNames;

            List<int> SizeList = new List<int>();
            for (int i = 3; i <= 100; i++) {
                SizeList.Add(i);
            }
            Cmb_Output_Length.DataSource = SizeList;
            Cmb_Output_Length.SelectedIndex = Cmb_Output_Length.FindStringExact("100");
            OutputLength = 100;
            SetSettingsPanelAccess(false);

            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - (Size.Width - 6), workingArea.Bottom - (Size.Height - 7));

            Txt_Password.Focus();

        }

        private void Btn_Settings_Cancel_Click(object sender, EventArgs e) {
            Cmb_Output_Length.SelectedIndex = Cmb_Output_Length.FindStringExact(OutputLength + "");
            Cmb_Encryption_Type.SelectedIndex = (int)CurrentEncryption;
            SetSettingsPanelAccess(false);
        }

        private void Btn_Settings_Click(object sender, EventArgs e) {
            Panel_Settings.BringToFront();
            SetSettingsPanelAccess(true);
        }

        private void SetSettingsPanelAccess(bool enable) {
            if (enable) {
                Btn_Settings_Apply.TabStop = true;
                Btn_Settings_Cancel.TabStop = true;
                Cmb_Encryption_Type.TabStop = true;
                Cmb_Output_Length.TabStop = true;
                Cmb_Output_Length.Focus();
                Cmb_Encryption_Type.SelectionLength = 0;
                Cmb_Output_Length.SelectionLength = 0;

                Btn_Copy.TabStop = false;
                Btn_View.TabStop = false;
                Txt_Password.TabStop = false;

                Panel_Settings.BringToFront();
            } else {
                Btn_Settings_Apply.TabStop = false;
                Btn_Settings_Cancel.TabStop = false;
                Cmb_Encryption_Type.TabStop = false;
                Cmb_Output_Length.TabStop = false;

                Btn_Copy.TabStop = true;
                Btn_View.TabStop = true;
                Txt_Password.TabStop = true;
                Txt_Password.Focus();

                Panel_Settings.SendToBack();
            }
        }

        private string Encrypt(string input) {
            Encryptor e = new Encryptor();
            switch (CurrentEncryption) {
                case EncryptionType.Custom:
                    return e.custom(input, OutputLength);
                case EncryptionType.CustomHex:
                    return e.customHex(input, OutputLength);
                case EncryptionType.CustomHex2:
                    return e.customHex2(input, OutputLength);
                case EncryptionType.Sha1:
                    return e.sha1(input);
                case EncryptionType.Sha256:
                    return e.sha256(input);
                case EncryptionType.Sha512:
                    return e.sha512(input);
            }
            throw new Exception("Current encryption not found");
        }

        private void Btn_View_MouseDown(object sender, MouseEventArgs e) {
            Txt_Password.PasswordChar = default(char);
        }

        private void Btn_View_MouseUp(object sender, MouseEventArgs e) {
            Txt_Password.PasswordChar = '*';
        }

        private void Btn_View_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                Btn_View_MouseUp(sender, null);
            }
        }

        private void Btn_View_Click(object sender, EventArgs e) {
            Btn_View_MouseDown(sender, null);
        }

        private void Txt_Password_TextChanged(object sender, EventArgs e) {
            if (Txt_Password.TextLength >= 3) {
                Txt_Result.Text = Encrypt(Txt_Password.Text);
                Txt_Result.SelectionStart = 0;
            } else {
                Txt_Result.Text = "";
                Txt_Result.SelectionStart = 0;
            }
        }

        private void Btn_Copy_Click(object sender, EventArgs e) {
            Clipboard.SetText(Txt_Result.Text);
        }

        private void Btn_Copy_KeyPress(object sender, KeyPressEventArgs e) {
            Btn_Copy_Click(sender, e);
        }

        private void Btn_Settings_Apply_Click(object sender, EventArgs e) {
            int index = Cmb_Encryption_Type.SelectedIndex;
            switch (index) {
                case 0:
                    CurrentEncryption = EncryptionType.Custom;
                    break;
                case 1:
                    CurrentEncryption = EncryptionType.CustomHex;
                    break;
                case 2:
                    CurrentEncryption = EncryptionType.CustomHex2;
                    break;
                case 3:
                    CurrentEncryption = EncryptionType.Sha1;
                    break;
                case 4:
                    CurrentEncryption = EncryptionType.Sha256;
                    break;
                case 5:
                    CurrentEncryption = EncryptionType.Sha512;
                    break;
            }

            if (Txt_Password.TextLength >= 3) {
                OutputLength = (int)Cmb_Output_Length.SelectedValue;
                Txt_Result.Text = Encrypt(Txt_Password.Text);
            }
            SetSettingsPanelAccess(false);
        }
    }
}
