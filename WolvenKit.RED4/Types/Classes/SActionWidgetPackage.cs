using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SActionWidgetPackage : SWidgetPackage
	{
		[Ordinal(18)] 
		[RED("action")] 
		public CHandle<gamedeviceAction> Action
		{
			get => GetPropertyValue<CHandle<gamedeviceAction>>();
			set => SetPropertyValue<CHandle<gamedeviceAction>>(value);
		}

		[Ordinal(19)] 
		[RED("wasInitalized")] 
		public CBool WasInitalized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("dependendActions")] 
		public CArray<CHandle<gamedeviceAction>> DependendActions
		{
			get => GetPropertyValue<CArray<CHandle<gamedeviceAction>>>();
			set => SetPropertyValue<CArray<CHandle<gamedeviceAction>>>(value);
		}

		public SActionWidgetPackage()
		{
			DependendActions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
