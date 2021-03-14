using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnOutputSocket : CVariable
	{
		private scnOutputSocketStamp _stamp;
		private CArray<scnInputSocketId> _destinations;

		[Ordinal(0)] 
		[RED("stamp")] 
		public scnOutputSocketStamp Stamp
		{
			get
			{
				if (_stamp == null)
				{
					_stamp = (scnOutputSocketStamp) CR2WTypeManager.Create("scnOutputSocketStamp", "stamp", cr2w, this);
				}
				return _stamp;
			}
			set
			{
				if (_stamp == value)
				{
					return;
				}
				_stamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("destinations")] 
		public CArray<scnInputSocketId> Destinations
		{
			get
			{
				if (_destinations == null)
				{
					_destinations = (CArray<scnInputSocketId>) CR2WTypeManager.Create("array:scnInputSocketId", "destinations", cr2w, this);
				}
				return _destinations;
			}
			set
			{
				if (_destinations == value)
				{
					return;
				}
				_destinations = value;
				PropertySet(this);
			}
		}

		public scnOutputSocket(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
