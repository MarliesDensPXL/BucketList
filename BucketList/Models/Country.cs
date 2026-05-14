using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;

namespace PE_BucketList.Models
{
    public class Country
    {
		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		private List<Place> _places;

		public List<Place> Places
		{
			get { return _places; }
			set { _places = value; }
		}



		public override string ToString()
        {
            return $"{Name}";
        }

    }
}
