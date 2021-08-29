using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SmartWindowMainLayoutWidgetController : ComputerMainLayoutWidgetController
	{
		private inkWidgetReference _menuMailsSlot;
		private inkWidgetReference _menuFilesSlot;
		private inkWidgetReference _menuNewsFeedSlot;
		private inkWidgetReference _menuDevicesSlot;

		[Ordinal(35)] 
		[RED("menuMailsSlot")] 
		public inkWidgetReference MenuMailsSlot
		{
			get => GetProperty(ref _menuMailsSlot);
			set => SetProperty(ref _menuMailsSlot, value);
		}

		[Ordinal(36)] 
		[RED("menuFilesSlot")] 
		public inkWidgetReference MenuFilesSlot
		{
			get => GetProperty(ref _menuFilesSlot);
			set => SetProperty(ref _menuFilesSlot, value);
		}

		[Ordinal(37)] 
		[RED("menuNewsFeedSlot")] 
		public inkWidgetReference MenuNewsFeedSlot
		{
			get => GetProperty(ref _menuNewsFeedSlot);
			set => SetProperty(ref _menuNewsFeedSlot, value);
		}

		[Ordinal(38)] 
		[RED("menuDevicesSlot")] 
		public inkWidgetReference MenuDevicesSlot
		{
			get => GetProperty(ref _menuDevicesSlot);
			set => SetProperty(ref _menuDevicesSlot, value);
		}
	}
}
