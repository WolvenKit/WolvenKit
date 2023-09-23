using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class IsValidCombatTarget : AIbehaviorconditionScript
	{
		[Ordinal(0)] 
		[RED("considerSourceAVehicleDriver")] 
		public CBool ConsiderSourceAVehicleDriver
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public IsValidCombatTarget()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
