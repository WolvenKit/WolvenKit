
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionSetItemAsTarget_Record
	{
		[RED("itemCategory")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ItemCategory
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("itemType")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ItemType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
