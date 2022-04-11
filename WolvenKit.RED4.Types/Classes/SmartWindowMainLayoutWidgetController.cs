using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SmartWindowMainLayoutWidgetController : ComputerMainLayoutWidgetController
	{
		[Ordinal(35)] 
		[RED("menuMailsSlot")] 
		public inkWidgetReference MenuMailsSlot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(36)] 
		[RED("menuFilesSlot")] 
		public inkWidgetReference MenuFilesSlot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(37)] 
		[RED("menuNewsFeedSlot")] 
		public inkWidgetReference MenuNewsFeedSlot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(38)] 
		[RED("menuDevicesSlot")] 
		public inkWidgetReference MenuDevicesSlot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public SmartWindowMainLayoutWidgetController()
		{
			MenuMailsSlot = new();
			MenuFilesSlot = new();
			MenuNewsFeedSlot = new();
			MenuDevicesSlot = new();
		}
	}
}
