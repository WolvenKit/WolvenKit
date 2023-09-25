using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DeviceActionWidgetControllerBase : DeviceButtonLogicControllerBase
	{
		[Ordinal(29)] 
		[RED("actions")] 
		public CArray<CWeakHandle<gamedeviceAction>> Actions
		{
			get => GetPropertyValue<CArray<CWeakHandle<gamedeviceAction>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gamedeviceAction>>>(value);
		}

		[Ordinal(30)] 
		[RED("actionData")] 
		public CHandle<ResolveActionData> ActionData
		{
			get => GetPropertyValue<CHandle<ResolveActionData>>();
			set => SetPropertyValue<CHandle<ResolveActionData>>(value);
		}

		[Ordinal(31)] 
		[RED("isInactive")] 
		public CBool IsInactive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public DeviceActionWidgetControllerBase()
		{
			Actions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
