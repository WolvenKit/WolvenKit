
namespace WolvenKit.RED4.Types
{
	public partial class gamedataRecipeItem_Record
	{
		[RED("craftableItems")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> CraftableItems
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
