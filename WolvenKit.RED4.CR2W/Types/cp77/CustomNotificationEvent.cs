using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CustomNotificationEvent : redEvent
	{
		private CString _header;
		private CString _description;
		private CName _icon;
		private CString _fluff_header;

		[Ordinal(0)] 
		[RED("header")] 
		public CString Header
		{
			get => GetProperty(ref _header);
			set => SetProperty(ref _header, value);
		}

		[Ordinal(1)] 
		[RED("description")] 
		public CString Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		[Ordinal(2)] 
		[RED("icon")] 
		public CName Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(3)] 
		[RED("fluff_header")] 
		public CString Fluff_header
		{
			get => GetProperty(ref _fluff_header);
			set => SetProperty(ref _fluff_header, value);
		}

		public CustomNotificationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
