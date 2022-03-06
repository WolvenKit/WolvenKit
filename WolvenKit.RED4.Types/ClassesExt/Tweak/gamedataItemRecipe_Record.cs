
namespace WolvenKit.RED4.Types
{
	public partial class gamedataItemRecipe_Record
	{
		[RED("craftingResult")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID CraftingResult
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("hideOnItemsAdded")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> HideOnItemsAdded
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
