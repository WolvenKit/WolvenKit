using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AddRecipeRequest : gamePlayerScriptableSystemRequest
	{
		private TweakDBID _recipe;
		private CInt32 _amount;
		private CArray<CWeakHandle<gamedataItem_Record>> _hideOnItemsAdded;

		[Ordinal(1)] 
		[RED("recipe")] 
		public TweakDBID Recipe
		{
			get => GetProperty(ref _recipe);
			set => SetProperty(ref _recipe, value);
		}

		[Ordinal(2)] 
		[RED("amount")] 
		public CInt32 Amount
		{
			get => GetProperty(ref _amount);
			set => SetProperty(ref _amount, value);
		}

		[Ordinal(3)] 
		[RED("hideOnItemsAdded")] 
		public CArray<CWeakHandle<gamedataItem_Record>> HideOnItemsAdded
		{
			get => GetProperty(ref _hideOnItemsAdded);
			set => SetProperty(ref _hideOnItemsAdded, value);
		}
	}
}
