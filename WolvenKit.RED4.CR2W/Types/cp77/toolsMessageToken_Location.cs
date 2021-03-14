using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class toolsMessageToken_Location : toolsIMessageToken
	{
		private CHandle<toolsIMessageLocation> _location;

		[Ordinal(0)] 
		[RED("location")] 
		public CHandle<toolsIMessageLocation> Location
		{
			get
			{
				if (_location == null)
				{
					_location = (CHandle<toolsIMessageLocation>) CR2WTypeManager.Create("handle:toolsIMessageLocation", "location", cr2w, this);
				}
				return _location;
			}
			set
			{
				if (_location == value)
				{
					return;
				}
				_location = value;
				PropertySet(this);
			}
		}

		public toolsMessageToken_Location(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
