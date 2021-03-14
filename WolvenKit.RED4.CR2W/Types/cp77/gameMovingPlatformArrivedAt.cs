using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMovingPlatformArrivedAt : redEvent
	{
		private CName _destinationName;
		private CInt32 _data;

		[Ordinal(0)] 
		[RED("destinationName")] 
		public CName DestinationName
		{
			get
			{
				if (_destinationName == null)
				{
					_destinationName = (CName) CR2WTypeManager.Create("CName", "destinationName", cr2w, this);
				}
				return _destinationName;
			}
			set
			{
				if (_destinationName == value)
				{
					return;
				}
				_destinationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("data")] 
		public CInt32 Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CInt32) CR2WTypeManager.Create("Int32", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		public gameMovingPlatformArrivedAt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
