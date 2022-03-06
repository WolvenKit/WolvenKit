
namespace WolvenKit.RED4.Types
{
	public partial class gamedataMovementPolicyTagList_Record
	{
		[RED("condition")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Condition
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("tags")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> Tags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
	}
}
