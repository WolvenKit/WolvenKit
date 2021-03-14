using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ToggleStreamFeed : ActionBool
	{
		private CBool _vRoomFake;

		[Ordinal(25)] 
		[RED("vRoomFake")] 
		public CBool VRoomFake
		{
			get
			{
				if (_vRoomFake == null)
				{
					_vRoomFake = (CBool) CR2WTypeManager.Create("Bool", "vRoomFake", cr2w, this);
				}
				return _vRoomFake;
			}
			set
			{
				if (_vRoomFake == value)
				{
					return;
				}
				_vRoomFake = value;
				PropertySet(this);
			}
		}

		public ToggleStreamFeed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
