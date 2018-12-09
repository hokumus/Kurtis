using Kurtis.Helper;
using Kurtis.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurtis
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private List<TimeModel> m_items;

        private void FormSetting_Load(object sender, EventArgs e)
        {
            cbHour.SelectedIndex = 0;
            cbMinute.SelectedIndex = 0;

            LoadItems();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var model = new TimeModel(cbHour.Text, cbMinute.Text);

            var hasItem = m_items.FirstOrDefault(x => x.Hour == model.Hour && x.Minute == model.Minute);
            if (hasItem != null)
                return;

            m_items.Add(model);

            TimeHelper.Instance.Save(m_items.ToList());
            LoadItems();
        }

        private void LoadItems()
        {
            m_items = TimeHelper.Instance.Load();

            if (m_items == null)
                m_items = new List<TimeModel>();

            lbHours.DataSource = m_items.ToList().OrderBy(x => x.Hour).ThenBy(x => x.Minute).ToList();
            lbHours.DisplayMember = "DisplayText";
            lbHours.ValueMember = "ID";
        }

        private void cmDelete_Click(object sender, EventArgs e)
        {
            if (lbHours.SelectedValue == null)
                return;

            if (!(lbHours.SelectedValue is Guid))
                return;

            var item = m_items.FirstOrDefault(x => x.ID == (Guid)lbHours.SelectedValue);
            if (item != null)
            {
                m_items.Remove(item);

                TimeHelper.Instance.Save(m_items);
                LoadItems();
            }
        }
    }
}
