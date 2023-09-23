using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CoolExitingEvents : ExitingEvents
	{
		[Ordinal(5)] 
		[RED("exitMomentum")] 
		public Vector4 ExitMomentum
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(6)] 
		[RED("coolExitMagnitude")] 
		public CEnum<vehicleCoolExitImpulseLevel> CoolExitMagnitude
		{
			get => GetPropertyValue<CEnum<vehicleCoolExitImpulseLevel>>();
			set => SetPropertyValue<CEnum<vehicleCoolExitImpulseLevel>>(value);
		}

		[Ordinal(7)] 
		[RED("willEquipMeleeWeapon")] 
		public CBool WillEquipMeleeWeapon
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CoolExitingEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
