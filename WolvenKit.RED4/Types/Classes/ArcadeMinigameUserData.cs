using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ArcadeMinigameUserData : inkUserData
	{
		[Ordinal(0)] 
		[RED("minigame")] 
		public CEnum<ArcadeMinigame> Minigame
		{
			get => GetPropertyValue<CEnum<ArcadeMinigame>>();
			set => SetPropertyValue<CEnum<ArcadeMinigame>>(value);
		}

		public ArcadeMinigameUserData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
