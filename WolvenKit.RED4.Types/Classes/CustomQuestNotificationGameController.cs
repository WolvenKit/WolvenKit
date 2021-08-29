using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CustomQuestNotificationGameController : gameuiHUDGameController
	{
		private inkTextWidgetReference _label;
		private inkTextWidgetReference _desc;
		private inkImageWidgetReference _icon;
		private inkTextWidgetReference _fluffHeader;
		private CWeakHandle<inkWidget> _root;
		private CHandle<CustomQuestNotificationUserData> _data;
		private CHandle<inkanimProxy> _animationProxy;

		[Ordinal(9)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(10)] 
		[RED("desc")] 
		public inkTextWidgetReference Desc
		{
			get => GetProperty(ref _desc);
			set => SetProperty(ref _desc, value);
		}

		[Ordinal(11)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(12)] 
		[RED("fluffHeader")] 
		public inkTextWidgetReference FluffHeader
		{
			get => GetProperty(ref _fluffHeader);
			set => SetProperty(ref _fluffHeader, value);
		}

		[Ordinal(13)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(14)] 
		[RED("data")] 
		public CHandle<CustomQuestNotificationUserData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(15)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetProperty(ref _animationProxy);
			set => SetProperty(ref _animationProxy, value);
		}
	}
}
