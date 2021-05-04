using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeviceInkLogicControllerBase : inkWidgetLogicController
	{
		private inkWidgetReference _targetWidgetRef;
		private inkTextWidgetReference _displayNameWidget;
		private CBool _isInitialized;
		private wCHandle<inkWidget> _targetWidget;

		[Ordinal(1)] 
		[RED("targetWidgetRef")] 
		public inkWidgetReference TargetWidgetRef
		{
			get => GetProperty(ref _targetWidgetRef);
			set => SetProperty(ref _targetWidgetRef, value);
		}

		[Ordinal(2)] 
		[RED("displayNameWidget")] 
		public inkTextWidgetReference DisplayNameWidget
		{
			get => GetProperty(ref _displayNameWidget);
			set => SetProperty(ref _displayNameWidget, value);
		}

		[Ordinal(3)] 
		[RED("isInitialized")] 
		public CBool IsInitialized
		{
			get => GetProperty(ref _isInitialized);
			set => SetProperty(ref _isInitialized, value);
		}

		[Ordinal(4)] 
		[RED("targetWidget")] 
		public wCHandle<inkWidget> TargetWidget
		{
			get => GetProperty(ref _targetWidget);
			set => SetProperty(ref _targetWidget, value);
		}

		public DeviceInkLogicControllerBase(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
