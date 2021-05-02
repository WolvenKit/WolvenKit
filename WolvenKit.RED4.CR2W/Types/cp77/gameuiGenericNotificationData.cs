using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiGenericNotificationData : CVariable
	{
		private CFloat _time;
		private CName _widgetLibraryItemName;
		private CName _introAnimation;
		private redResourceReferenceScriptToken _widgetLibraryResource;
		private CHandle<gameuiGenericNotificationViewData> _notificationData;

		[Ordinal(0)] 
		[RED("time")] 
		public CFloat Time
		{
			get => GetProperty(ref _time);
			set => SetProperty(ref _time, value);
		}

		[Ordinal(1)] 
		[RED("widgetLibraryItemName")] 
		public CName WidgetLibraryItemName
		{
			get => GetProperty(ref _widgetLibraryItemName);
			set => SetProperty(ref _widgetLibraryItemName, value);
		}

		[Ordinal(2)] 
		[RED("introAnimation")] 
		public CName IntroAnimation
		{
			get => GetProperty(ref _introAnimation);
			set => SetProperty(ref _introAnimation, value);
		}

		[Ordinal(3)] 
		[RED("widgetLibraryResource")] 
		public redResourceReferenceScriptToken WidgetLibraryResource
		{
			get => GetProperty(ref _widgetLibraryResource);
			set => SetProperty(ref _widgetLibraryResource, value);
		}

		[Ordinal(4)] 
		[RED("notificationData")] 
		public CHandle<gameuiGenericNotificationViewData> NotificationData
		{
			get => GetProperty(ref _notificationData);
			set => SetProperty(ref _notificationData, value);
		}

		public gameuiGenericNotificationData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
