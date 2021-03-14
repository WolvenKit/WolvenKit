using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameVisionAppearanceForcedEvent : redEvent
	{
		private CBool _state;

		[Ordinal(0)] 
		[RED("state")] 
		public CBool State
		{
			get
			{
				if (_state == null)
				{
					_state = (CBool) CR2WTypeManager.Create("Bool", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		public gameVisionAppearanceForcedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
