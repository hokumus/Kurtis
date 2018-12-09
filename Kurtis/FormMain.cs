using Kurtis.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurtis
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            SetTitle();
            FormHide();

            cbMinute.SelectedIndex = 0;
            cbMinuteInput.SelectedIndex = 0;
            cbSystemMessage.Checked = true;

            new JobHelper().Init();
        }

        private void SetTitle()
        {
            this.Text =
            notifyIcon.Text =
            notifyIcon.BalloonTipTitle = AppCaption.Instance.Caption;
        }

        private void FormHide()
        {
            this.ShowInTaskbar = false;
            this.Hide();

            notifyIcon.Visible = true;
            notifyIcon.BalloonTipText = "Uygulama çalışıyor.";
            notifyIcon.ShowBalloonTip(100);
        }

        private void FormShow()
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            this.Show();

            notifyIcon.Visible = false;
        }

        private void FormMain_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                FormHide();
            }
            else
            {
                FormShow();
            }
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            FormShow();
        }

        private void cbSystemMessage_CheckedChanged(object sender, EventArgs e)
        {
            groupBox.Enabled = cbSystemMessage.Checked;

            string message = $"Bilgisayarınız {Convert.ToInt32(cbMinute.Text)} dakika sonra otomatik kilitlenecektir.";

            WindowsLockHelper.Instance.SetTooltip(
                cbSystemMessage.Checked,
                Convert.ToInt32(cbMinute.Text), () =>
                {
                    notifyIcon.Visible = true;
                    notifyIcon.ShowBalloonTip(300, "Windows Kilitlenecek", message, ToolTipIcon.Info);
                });
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            InteropHelper.LockWorkStation();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            new FormSettings().ShowDialog();

            WindowsLockHelper.Instance.SetTimes();
        }

        private void cbLockDisable_CheckedChanged(object sender, EventArgs e)
        {
            WindowsLockHelper.Instance.LockDisable = cbLockDisable.Checked;
            InputIdleLockHelper.Instance.LockDisable = cbLockDisable.Checked;
            cmDeactive.Checked = cbLockDisable.Checked;
        }

        private void cbInput_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxMouse.Enabled = cbInput.Checked;

            InputIdleLockHelper.Instance.CheckInputIdleTime = cbInput.Checked;
            InputIdleLockHelper.Instance.Minute = Convert.ToInt32(cbMinuteInput.Text);
        }

        private void cbMinute_SelectedIndexChanged(object sender, EventArgs e)
        {
            WindowsLockHelper.Instance.SetMinute(Convert.ToInt32(cbMinute.Text));
        }

        private void cbMinuteInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            InputIdleLockHelper.Instance.Minute = Convert.ToInt32(cbMinuteInput.Text);
        }

        private void cmExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmDeactive_Click(object sender, EventArgs e)
        {
            if (cmDeactive.Checked)
            {
                cmDeactive.Checked = false;
                cbLockDisable.Checked = false;
            }
            else
            {
                cmDeactive.Checked = true;
                cbLockDisable.Checked = true;
            }
        }

        private void cmOpen_Click(object sender, EventArgs e)
        {
            FormShow();
        }

        private void cmSettings_Click(object sender, EventArgs e)
        {
            var form = new FormSettings()
            {
                StartPosition = FormStartPosition.CenterScreen
            };

            form.ShowDialog();
            WindowsLockHelper.Instance.SetTimes();
        }
    }
}
