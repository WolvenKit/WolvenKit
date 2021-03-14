using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkPhotoModeCursorStateChangedEvent : redEvent
	{
		private CBool _cursorEnabled;

		[Ordinal(0)] 
		[RED("cursorEnabled")] 
		public CBool CursorEnabled
		{
			get
			{
				if (_cursorEnabled == null)
				{
					_cursorEnabled = (CBool) CR2WTypeManager.Create("Bool", "cursorEnabled", cr2w, this);
				}
				return _cursorEnabled;
			}
			set
			{
				if (_cursorEnabled == value)
				{
					return;
				}
				_cursorEnabled = value;
				PropertySet(this);
			}
		}

		public inkPhotoModeCursorStateChangedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
