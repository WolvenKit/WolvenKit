using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeviceInkLogicControllerBase : inkWidgetLogicController
	{
		private inkWidgetReference _targetWidgetRef;
		private inkTextWidgetReference _displayNameWidget;
		private CBool _isInitialized;
		private CWeakHandle<inkWidget> _targetWidget;

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
		public CWeakHandle<inkWidget> TargetWidget
		{
			get => GetProperty(ref _targetWidget);
			set => SetProperty(ref _targetWidget, value);
		}
	}
}
