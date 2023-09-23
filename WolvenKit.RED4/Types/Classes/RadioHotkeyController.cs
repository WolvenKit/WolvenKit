using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RadioHotkeyController : GenericHotkeyController
	{
		[Ordinal(23)] 
		[RED("vehicleBB")] 
		public CWeakHandle<gameIBlackboard> VehicleBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(24)] 
		[RED("vehicleEnterListener")] 
		public CHandle<redCallbackObject> VehicleEnterListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(25)] 
		[RED("factListener")] 
		public CUInt32 FactListener
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(26)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public RadioHotkeyController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
