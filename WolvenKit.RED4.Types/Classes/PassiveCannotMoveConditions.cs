using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PassiveCannotMoveConditions : PassiveAutonomousCondition
	{
		[Ordinal(0)] 
		[RED("statusEffectRemovedId")] 
		public CUInt32 StatusEffectRemovedId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public PassiveCannotMoveConditions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
