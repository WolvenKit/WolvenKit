using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickHackScreenOpen : redEvent
	{
		private CBool _setToOpen;

		[Ordinal(0)] 
		[RED("setToOpen")] 
		public CBool SetToOpen
		{
			get
			{
				if (_setToOpen == null)
				{
					_setToOpen = (CBool) CR2WTypeManager.Create("Bool", "setToOpen", cr2w, this);
				}
				return _setToOpen;
			}
			set
			{
				if (_setToOpen == value)
				{
					return;
				}
				_setToOpen = value;
				PropertySet(this);
			}
		}

		public QuickHackScreenOpen(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
