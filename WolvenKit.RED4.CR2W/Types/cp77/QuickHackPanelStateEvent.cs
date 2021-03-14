using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickHackPanelStateEvent : redEvent
	{
		private CBool _isOpened;

		[Ordinal(0)] 
		[RED("isOpened")] 
		public CBool IsOpened
		{
			get
			{
				if (_isOpened == null)
				{
					_isOpened = (CBool) CR2WTypeManager.Create("Bool", "isOpened", cr2w, this);
				}
				return _isOpened;
			}
			set
			{
				if (_isOpened == value)
				{
					return;
				}
				_isOpened = value;
				PropertySet(this);
			}
		}

		public QuickHackPanelStateEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
