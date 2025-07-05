
namespace WolvenKit.RED4.Types
{
	public partial class gamedataCraftingPackage_Record
	{
		[RED("craftingExpModifier")]
		[REDProperty(IsIgnored = true)]
		public CFloat CraftingExpModifier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("craftingRecipe")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> CraftingRecipe
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("overcraftPenaltyModifier")]
		[REDProperty(IsIgnored = true)]
		public CFloat OvercraftPenaltyModifier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
