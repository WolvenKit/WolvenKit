using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UIScriptableSystemWardrobeSetAdded : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("wardrobeSet")] 
		public CEnum<gameWardrobeClothingSetIndex> WardrobeSet
		{
			get => GetPropertyValue<CEnum<gameWardrobeClothingSetIndex>>();
			set => SetPropertyValue<CEnum<gameWardrobeClothingSetIndex>>(value);
		}

		public UIScriptableSystemWardrobeSetAdded()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
