using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameClothingSet : IScriptable
	{
		[Ordinal(0)] 
		[RED("setID")] 
		public CEnum<gameWardrobeClothingSetIndex> SetID
		{
			get => GetPropertyValue<CEnum<gameWardrobeClothingSetIndex>>();
			set => SetPropertyValue<CEnum<gameWardrobeClothingSetIndex>>(value);
		}

		[Ordinal(1)] 
		[RED("clothingList")] 
		public CArray<gameSSlotVisualInfo> ClothingList
		{
			get => GetPropertyValue<CArray<gameSSlotVisualInfo>>();
			set => SetPropertyValue<CArray<gameSSlotVisualInfo>>(value);
		}

		[Ordinal(2)] 
		[RED("iconID")] 
		public TweakDBID IconID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public gameClothingSet()
		{
			SetID = Enums.gameWardrobeClothingSetIndex.INVALID;
			ClothingList = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
