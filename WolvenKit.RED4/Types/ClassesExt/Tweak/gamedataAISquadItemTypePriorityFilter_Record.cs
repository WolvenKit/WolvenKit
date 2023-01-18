
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISquadItemTypePriorityFilter_Record
	{
		[RED("types")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Types
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
