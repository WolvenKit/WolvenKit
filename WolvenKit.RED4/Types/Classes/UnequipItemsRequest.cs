using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UnequipItemsRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("items")] 
		public CArray<gameItemID> Items
		{
			get => GetPropertyValue<CArray<gameItemID>>();
			set => SetPropertyValue<CArray<gameItemID>>(value);
		}

		public UnequipItemsRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
