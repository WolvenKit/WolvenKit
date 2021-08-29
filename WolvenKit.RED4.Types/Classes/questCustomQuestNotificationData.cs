using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCustomQuestNotificationData : RedBaseClass
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
	}
}
