using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerHandicapSystem : gameIPlayerHandicapSystem
	{
		[Ordinal(0)] 
		[RED("canDropHealingConsumable")] 
		public CBool CanDropHealingConsumable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("canDropAmmo")] 
		public CBool CanDropAmmo
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PlayerHandicapSystem()
		{
			CanDropHealingConsumable = true;
			CanDropAmmo = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
