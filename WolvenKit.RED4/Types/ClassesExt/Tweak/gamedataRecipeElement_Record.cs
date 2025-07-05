
namespace WolvenKit.RED4.Types
{
	public partial class gamedataRecipeElement_Record
	{
		[RED("amount")]
		[REDProperty(IsIgnored = true)]
		public CInt32 Amount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("ingredient")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Ingredient
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
