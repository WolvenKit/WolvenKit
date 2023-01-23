using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DeleteWardrobeSetRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("setID")] 
		public CEnum<gameWardrobeClothingSetIndex> SetID
		{
			get => GetPropertyValue<CEnum<gameWardrobeClothingSetIndex>>();
			set => SetPropertyValue<CEnum<gameWardrobeClothingSetIndex>>(value);
		}

		public DeleteWardrobeSetRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
