using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RadioHotkeyController : GenericHotkeyController
	{
		[Ordinal(25)] 
		[RED("vehicleBB")] 
		public CWeakHandle<gameIBlackboard> VehicleBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(26)] 
		[RED("vehicleEnterListener")] 
		public CHandle<redCallbackObject> VehicleEnterListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(27)] 
		[RED("factListener")] 
		public CUInt32 FactListener
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(28)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(29)] 
		[RED("equalizerAnimProxy")] 
		public CHandle<inkanimProxy> EqualizerAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(30)] 
		[RED("pocketRadioToken")] 
		public CHandle<inkGameNotificationToken> PocketRadioToken
		{
			get => GetPropertyValue<CHandle<inkGameNotificationToken>>();
			set => SetPropertyValue<CHandle<inkGameNotificationToken>>(value);
		}

		[Ordinal(31)] 
		[RED("isInDefaultState")] 
		public CBool IsInDefaultState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public RadioHotkeyController()
		{
			HotkeyBackground = new inkImageWidgetReference();
			ButtonHint = new inkWidgetReference();
			Restrictions = new();
			DebugCommands = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
