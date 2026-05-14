using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_BucketList.Models
{
    public class Place
    {
		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}


		private string _city;

		public string City
		{
			get { return _city; }
			set { _city = value; }
		}

		private string _description;

		public string Description
		{
			get { return _description; }
			set { _description = value; }
		}

		private bool _isVisited;

		public bool IsVisited
		{
			get { return _isVisited; }
			set { _isVisited = value; }
		}

		private string _imageSource;

		public string ImageSource
		{
			get { return _imageSource; }
			set { _imageSource = value; }
		}

        public override string ToString()
        {
			return $"{Name}";
        }



	}
}
