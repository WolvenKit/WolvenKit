using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiContraPlayer : gameuiSideScrollerMiniGameDynObjectLogicAdvanced
	{
		[Ordinal(1)] 
		[RED("mass")] 
		public CFloat Mass
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("jumpForce")] 
		public CFloat JumpForce
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("movementSpeed")] 
		public CFloat MovementSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameuiContraPlayer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
