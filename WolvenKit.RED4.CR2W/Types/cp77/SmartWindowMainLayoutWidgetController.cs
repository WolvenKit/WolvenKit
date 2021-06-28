using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SmartWindowMainLayoutWidgetController : ComputerMainLayoutWidgetController
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

		public SmartWindowMainLayoutWidgetController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
