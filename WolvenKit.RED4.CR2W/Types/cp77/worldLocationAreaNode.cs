using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldLocationAreaNode : worldTriggerAreaNode
	{
		private CString _locationName;

		[Ordinal(7)] 
		[RED("locationName")] 
		public CString LocationName
		{
			get
			{
				if (_locationName == null)
				{
					_locationName = (CString) CR2WTypeManager.Create("String", "locationName", cr2w, this);
				}
				return _locationName;
			}
			set
			{
				if (_locationName == value)
				{
					return;
				}
				_locationName = value;
				PropertySet(this);
			}
		}

		public worldLocationAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
