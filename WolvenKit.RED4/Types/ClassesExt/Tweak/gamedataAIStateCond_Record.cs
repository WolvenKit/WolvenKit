
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIStateCond_Record
	{
		[RED("checkAllTypes")]
		[REDProperty(IsIgnored = true)]
		public CBool CheckAllTypes
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("inStates")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> InStates
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("target")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Target
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
