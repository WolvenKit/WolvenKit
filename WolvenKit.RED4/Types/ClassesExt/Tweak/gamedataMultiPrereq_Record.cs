
namespace WolvenKit.RED4.Types
{
	public partial class gamedataMultiPrereq_Record
	{
		[RED("aggregationType")]
		[REDProperty(IsIgnored = true)]
		public CName AggregationType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("nestedPrereqs")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> NestedPrereqs
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
