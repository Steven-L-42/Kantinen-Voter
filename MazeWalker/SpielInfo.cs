using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeWalker
{
    public partial class SpielInfo : Form
    {
        public SpielInfo()
        {
            InitializeComponent();
        }
        public void SetScores()
        {
            var items = ScoreUtils.ReadTopScores()
                .Select(item => new ListViewItem(item.ToString()))
                .ToArray();

            listView1.Items.AddRange(items);
        }
      

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SpielInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
