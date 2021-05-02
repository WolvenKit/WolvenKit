using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeviceWidgetControllerBase : DeviceInkLogicControllerBase
	{
		private inkImageWidgetReference _backgroundTextureRef;
		private inkTextWidgetReference _statusNameWidget;
		private inkWidgetReference _actionsListWidget;
		private CArray<SActionWidgetPackage> _actionWidgetsData;
		private CHandle<ResolveActionData> _actionData;

		[Ordinal(5)] 
		[RED("backgroundTextureRef")] 
		public inkImageWidgetReference BackgroundTextureRef
		{
			get => GetProperty(ref _backgroundTextureRef);
			set => SetProperty(ref _backgroundTextureRef, value);
		}

		[Ordinal(6)] 
		[RED("statusNameWidget")] 
		public inkTextWidgetReference StatusNameWidget
		{
			get => GetProperty(ref _statusNameWidget);
			set => SetProperty(ref _statusNameWidget, value);
		}

		[Ordinal(7)] 
		[RED("actionsListWidget")] 
		public inkWidgetReference ActionsListWidget
		{
			get => GetProperty(ref _actionsListWidget);
			set => SetProperty(ref _actionsListWidget, value);
		}

		[Ordinal(8)] 
		[RED("actionWidgetsData")] 
		public CArray<SActionWidgetPackage> ActionWidgetsData
		{
			get => GetProperty(ref _actionWidgetsData);
			set => SetProperty(ref _actionWidgetsData, value);
		}

		[Ordinal(9)] 
		[RED("actionData")] 
		public CHandle<ResolveActionData> ActionData
		{
			get => GetProperty(ref _actionData);
			set => SetProperty(ref _actionData, value);
		}

		public DeviceWidgetControllerBase(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
