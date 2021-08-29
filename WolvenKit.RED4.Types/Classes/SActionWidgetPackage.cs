using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SActionWidgetPackage : SWidgetPackage
	{
		private CHandle<gamedeviceAction> _action;
		private CBool _wasInitalized;
		private CArray<CHandle<gamedeviceAction>> _dependendActions;

		[Ordinal(17)] 
		[RED("action")] 
		public CHandle<gamedeviceAction> Action
		{
			get => GetProperty(ref _action);
			set => SetProperty(ref _action, value);
		}

		[Ordinal(18)] 
		[RED("wasInitalized")] 
		public CBool WasInitalized
		{
			get => GetProperty(ref _wasInitalized);
			set => SetProperty(ref _wasInitalized, value);
		}

		[Ordinal(19)] 
		[RED("dependendActions")] 
		public CArray<CHandle<gamedeviceAction>> DependendActions
		{
			get => GetProperty(ref _dependendActions);
			set => SetProperty(ref _dependendActions, value);
		}
	}
}
