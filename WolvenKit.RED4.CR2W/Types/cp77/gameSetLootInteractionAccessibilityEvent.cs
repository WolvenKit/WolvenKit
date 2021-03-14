using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSetLootInteractionAccessibilityEvent : redEvent
	{
		private CBool _accessible;

		[Ordinal(0)] 
		[RED("accessible")] 
		public CBool Accessible
		{
			get
			{
				if (_accessible == null)
				{
					_accessible = (CBool) CR2WTypeManager.Create("Bool", "accessible", cr2w, this);
				}
				return _accessible;
			}
			set
			{
				if (_accessible == value)
				{
					return;
				}
				_accessible = value;
				PropertySet(this);
			}
		}

		public gameSetLootInteractionAccessibilityEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
