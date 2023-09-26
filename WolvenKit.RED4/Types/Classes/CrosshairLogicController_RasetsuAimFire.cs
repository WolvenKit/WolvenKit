using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CrosshairLogicController_RasetsuAimFire : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("chargebarContainer")] 
		public inkWidgetReference ChargebarContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("perfectChargeIndicator")] 
		public inkWidgetReference PerfectChargeIndicator
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("chargeBar")] 
		public CWeakHandle<ChargebarController> ChargeBar
		{
			get => GetPropertyValue<CWeakHandle<ChargebarController>>();
			set => SetPropertyValue<CWeakHandle<ChargebarController>>(value);
		}

		[Ordinal(4)] 
		[RED("animPerfectCharge")] 
		public CHandle<inkanimProxy> AnimPerfectCharge
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public CrosshairLogicController_RasetsuAimFire()
		{
			ChargebarContainer = new inkWidgetReference();
			PerfectChargeIndicator = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
