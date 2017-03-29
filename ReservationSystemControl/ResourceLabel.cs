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
        public ResourceLabel() : base()
        {
            this.Dock = DockStyle.Fill;
            this.Text = this.ToString();
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.BackColor = Color.NavajoWhite;
        }

        public ResourceLabel(Resource resource): this()
        {
            this.resource = resource;
            this.Dock = DockStyle.Fill;
            this.Text = this.ToString();
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.BackColor = Color.NavajoWhite;
        }

        public override string ToString()
        {
            if (this.resource != null)
                return this.resource.Name;
            else return base.ToString();
        }
    }
}
