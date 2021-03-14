using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EndLookatEvent : redEvent
	{
		private CBool _repeat;

		[Ordinal(0)] 
		[RED("repeat")] 
		public CBool Repeat
		{
			get
			{
				if (_repeat == null)
				{
					_repeat = (CBool) CR2WTypeManager.Create("Bool", "repeat", cr2w, this);
				}
				return _repeat;
			}
			set
			{
				if (_repeat == value)
				{
					return;
				}
				_repeat = value;
				PropertySet(this);
			}
		}

		public EndLookatEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
