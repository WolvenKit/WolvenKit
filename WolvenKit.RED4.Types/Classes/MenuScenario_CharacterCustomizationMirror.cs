using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MenuScenario_CharacterCustomizationMirror : MenuScenario_BaseMenu
	{
		[Ordinal(4)] 
		[RED("morphMenuUserData")] 
		public CHandle<MorphMenuUserData> MorphMenuUserData
		{
			get => GetPropertyValue<CHandle<MorphMenuUserData>>();
			set => SetPropertyValue<CHandle<MorphMenuUserData>>(value);
		}

		public MenuScenario_CharacterCustomizationMirror()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
