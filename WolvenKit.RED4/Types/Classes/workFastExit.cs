using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class workFastExit : workIEntry
	{
		[Ordinal(2)] 
		[RED("animName")] 
		public CName AnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("forcedBlendIn")] 
		public CFloat ForcedBlendIn
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("movementType")] 
		public CEnum<moveMovementType> MovementType
		{
			get => GetPropertyValue<CEnum<moveMovementType>>();
			set => SetPropertyValue<CEnum<moveMovementType>>(value);
		}

		public workFastExit()
		{
			Id = new workWorkEntryId { Id = uint.MaxValue };
			Flags = 32772;
			ForcedBlendIn = 0.200000F;
			MovementType = Enums.moveMovementType.Stand;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
