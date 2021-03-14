using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VRoomFeed : redEvent
	{
		private CBool _on;

		[Ordinal(0)] 
		[RED("On")] 
		public CBool On
		{
			get
			{
				if (_on == null)
				{
					_on = (CBool) CR2WTypeManager.Create("Bool", "On", cr2w, this);
				}
				return _on;
			}
			set
			{
				if (_on == value)
				{
					return;
				}
				_on = value;
				PropertySet(this);
			}
		}

		public VRoomFeed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
