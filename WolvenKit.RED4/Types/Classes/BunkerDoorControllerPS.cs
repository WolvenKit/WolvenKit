using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BunkerDoorControllerPS : DoorControllerPS
	{
		[Ordinal(117)] 
		[RED("NpcOpenSpeed")] 
		public CFloat NpcOpenSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(118)] 
		[RED("NpcOpenTime")] 
		public CFloat NpcOpenTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(119)] 
		[RED("malfunctioningType")] 
		public CEnum<EMalfunctioningType> MalfunctioningType
		{
			get => GetPropertyValue<CEnum<EMalfunctioningType>>();
			set => SetPropertyValue<CEnum<EMalfunctioningType>>(value);
		}

		[Ordinal(120)] 
		[RED("malfunctioningChance")] 
		public CInt32 MalfunctioningChance
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(121)] 
		[RED("malfunctioningStimRange")] 
		public CFloat MalfunctioningStimRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(122)] 
		[RED("malfanctioningBehaviourActive")] 
		public CBool MalfanctioningBehaviourActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public BunkerDoorControllerPS()
		{
			NpcOpenSpeed = 1.000000F;
			NpcOpenTime = 1.000000F;
			MalfunctioningChance = 100;
			MalfunctioningStimRange = 10.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
