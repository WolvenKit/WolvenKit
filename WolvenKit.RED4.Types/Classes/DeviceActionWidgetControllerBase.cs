using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeviceActionWidgetControllerBase : DeviceButtonLogicControllerBase
	{
		private CArray<CWeakHandle<gamedeviceAction>> _actions;
		private CHandle<ResolveActionData> _actionData;
		private CBool _isInactive;

		[Ordinal(26)] 
		[RED("actions")] 
		public CArray<CWeakHandle<gamedeviceAction>> Actions
		{
			get => GetProperty(ref _actions);
			set => SetProperty(ref _actions, value);
		}

		[Ordinal(27)] 
		[RED("actionData")] 
		public CHandle<ResolveActionData> ActionData
		{
			get => GetProperty(ref _actionData);
			set => SetProperty(ref _actionData, value);
		}

		[Ordinal(28)] 
		[RED("isInactive")] 
		public CBool IsInactive
		{
			get => GetProperty(ref _isInactive);
			set => SetProperty(ref _isInactive, value);
		}
	}
}
