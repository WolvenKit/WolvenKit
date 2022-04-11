using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeviceActionWidgetControllerBase : DeviceButtonLogicControllerBase
	{
		[Ordinal(26)] 
		[RED("actions")] 
		public CArray<CWeakHandle<gamedeviceAction>> Actions
		{
			get => GetPropertyValue<CArray<CWeakHandle<gamedeviceAction>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gamedeviceAction>>>(value);
		}

		[Ordinal(27)] 
		[RED("actionData")] 
		public CHandle<ResolveActionData> ActionData
		{
			get => GetPropertyValue<CHandle<ResolveActionData>>();
			set => SetPropertyValue<CHandle<ResolveActionData>>(value);
		}

		[Ordinal(28)] 
		[RED("isInactive")] 
		public CBool IsInactive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public DeviceActionWidgetControllerBase()
		{
			Actions = new();
		}
	}
}
