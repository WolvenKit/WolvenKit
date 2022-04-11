using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SaveWardrobeSetRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("clothingSet")] 
		public ClothingSet ClothingSet
		{
			get => GetPropertyValue<ClothingSet>();
			set => SetPropertyValue<ClothingSet>(value);
		}

		public SaveWardrobeSetRequest()
		{
			ClothingSet = new() { SetID = -1, ClothingList = new() };
		}
	}
}
