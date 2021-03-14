using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCoordinates : CVariable
	{
		private CInt32 _latitude;
		private CInt32 _longitude;

		[Ordinal(0)] 
		[RED("latitude")] 
		public CInt32 Latitude
		{
			get
			{
				if (_latitude == null)
				{
					_latitude = (CInt32) CR2WTypeManager.Create("Int32", "latitude", cr2w, this);
				}
				return _latitude;
			}
			set
			{
				if (_latitude == value)
				{
					return;
				}
				_latitude = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("longitude")] 
		public CInt32 Longitude
		{
			get
			{
				if (_longitude == null)
				{
					_longitude = (CInt32) CR2WTypeManager.Create("Int32", "longitude", cr2w, this);
				}
				return _longitude;
			}
			set
			{
				if (_longitude == value)
				{
					return;
				}
				_longitude = value;
				PropertySet(this);
			}
		}

		public gameCoordinates(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
