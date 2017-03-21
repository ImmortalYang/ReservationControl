using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationSystemControl
{
    public class ResourceLabel: Label
    {
        public Resource resource;

        public ResourceLabel(Resource resource): base()
        {
            this.resource = resource;
            this.Text = this.ToString();
        }

        public override string ToString()
        {
            return this.resource.Name;
        }
    }
}
