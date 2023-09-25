using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RoadBlockControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(107)] 
		[RED("isBlocking")] 
		public CBool IsBlocking
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(108)] 
		[RED("negateAnimState")] 
		public CBool NegateAnimState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(109)] 
		[RED("nameForBlocking")] 
		public TweakDBID NameForBlocking
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(110)] 
		[RED("nameForUnblocking")] 
		public TweakDBID NameForUnblocking
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public RoadBlockControllerPS()
		{
			DeviceName = "LocKey#126";
			TweakDBRecord = "Devices.RoadBlock";
			TweakDBDescriptionRecord = 127230302630;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
