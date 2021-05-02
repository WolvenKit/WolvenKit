using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCustomQuestNotificationData : CVariable
	{
		private CString _header;
		private CString _desc;
		private CName _icon;
		private CString _fluffHeader;

		[Ordinal(0)] 
		[RED("header")] 
		public CString Header
		{
			get => GetProperty(ref _header);
			set => SetProperty(ref _header, value);
		}

		[Ordinal(1)] 
		[RED("desc")] 
		public CString Desc
		{
			get => GetProperty(ref _desc);
			set => SetProperty(ref _desc, value);
		}

		[Ordinal(2)] 
		[RED("icon")] 
		public CName Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(3)] 
		[RED("fluffHeader")] 
		public CString FluffHeader
		{
			get => GetProperty(ref _fluffHeader);
			set => SetProperty(ref _fluffHeader, value);
		}

		public questCustomQuestNotificationData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
