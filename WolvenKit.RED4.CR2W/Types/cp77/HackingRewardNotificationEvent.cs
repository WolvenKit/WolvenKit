using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HackingRewardNotificationEvent : redEvent
	{
		private CString _text;
		private CArray<CString> _icons;

		[Ordinal(0)] 
		[RED("text")] 
		public CString Text
		{
			get
			{
				if (_text == null)
				{
					_text = (CString) CR2WTypeManager.Create("String", "text", cr2w, this);
				}
				return _text;
			}
			set
			{
				if (_text == value)
				{
					return;
				}
				_text = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("icons")] 
		public CArray<CString> Icons
		{
			get
			{
				if (_icons == null)
				{
					_icons = (CArray<CString>) CR2WTypeManager.Create("array:String", "icons", cr2w, this);
				}
				return _icons;
			}
			set
			{
				if (_icons == value)
				{
					return;
				}
				_icons = value;
				PropertySet(this);
			}
		}

		public HackingRewardNotificationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
