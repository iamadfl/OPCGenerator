using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reticle_OPC_Generator
{
    public partial class Help : Form
    {

        public Help()
        {
            InitializeComponent();
            HelpListNotes.Hide();
        }

        public Help(int queryForm)
        {
            InitializeComponent();
            setHelpList(queryForm);
            HelpListNotes.Hide();

        }
        private void setHelpList(int queryForm)
        {
            if (Viewer.Items.Count > 0)
            {
                Viewer.Groups.RemoveAt(0);
                Viewer.Groups.Clear();
            }

            List<string> list = HelpListNotes.Groups[queryForm].Items.Cast<ListViewItem>().Select(item => item.Text).ToList();
            var group = new ListViewGroup(HelpListNotes.Groups[queryForm].Header, HorizontalAlignment.Left);
            Viewer.Groups.Add(group);

            foreach (var line in list) 
            {
                ListViewItem item = new ListViewItem(line,group);
                Viewer.Items.Add(item);
            }

        }
    }
}
