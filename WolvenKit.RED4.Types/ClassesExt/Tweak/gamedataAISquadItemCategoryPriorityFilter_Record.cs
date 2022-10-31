
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISquadItemCategoryPriorityFilter_Record
	{
		[RED("categories")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Categories
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
