using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MenuScenario_SingleplayerMenu : MenuScenario_PreGameSubMenu
	{
		[Ordinal(2)] 
		[RED("expansionHintShown")] 
		public CBool ExpansionHintShown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public MenuScenario_SingleplayerMenu()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
