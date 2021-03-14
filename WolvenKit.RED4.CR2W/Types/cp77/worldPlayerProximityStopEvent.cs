using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldPlayerProximityStopEvent : redEvent
	{
		private CName _profile;

		[Ordinal(0)] 
		[RED("profile")] 
		public CName Profile
		{
			get
			{
				if (_profile == null)
				{
					_profile = (CName) CR2WTypeManager.Create("CName", "profile", cr2w, this);
				}
				return _profile;
			}
			set
			{
				if (_profile == value)
				{
					return;
				}
				_profile = value;
				PropertySet(this);
			}
		}

		public worldPlayerProximityStopEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
