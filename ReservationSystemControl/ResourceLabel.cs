using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ReservationSystemControl
{
    public class ResourceLabel: Label
    {
        public Resource resource;

        public ResourceLabel(Resource resource): base()
        {
            this.resource = resource;
            this.Dock = DockStyle.Fill;
            this.Text = this.ToString();
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.BackColor = Color.NavajoWhite;
        }

        public override string ToString()
        {
            return this.resource.Name;
        }
    }
}
