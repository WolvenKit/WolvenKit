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
			get => GetProperty(ref _text);
			set => SetProperty(ref _text, value);
		}

		[Ordinal(1)] 
		[RED("icons")] 
		public CArray<CString> Icons
		{
			get => GetProperty(ref _icons);
			set => SetProperty(ref _icons, value);
		}

		public HackingRewardNotificationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
