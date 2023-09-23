using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AddRecipeRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("recipe")] 
		public TweakDBID Recipe
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(2)] 
		[RED("amount")] 
		public CInt32 Amount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("hideOnItemsAdded")] 
		public CArray<CWeakHandle<gamedataItem_Record>> HideOnItemsAdded
		{
			get => GetPropertyValue<CArray<CWeakHandle<gamedataItem_Record>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gamedataItem_Record>>>(value);
		}

		public AddRecipeRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
