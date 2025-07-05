using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class grenadeSpawner : gameweaponObject
	{
		[Ordinal(66)] 
		[RED("isCombatGadgetActive")] 
		public CBool IsCombatGadgetActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public grenadeSpawner()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
