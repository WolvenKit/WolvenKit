
namespace WolvenKit.RED4.Types
{
	public partial class gamedataMappinUIFilterGroup_Record
	{
		[RED("filterName")]
		[REDProperty(IsIgnored = true)]
		public CName FilterName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("filterType")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID FilterType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("mappins")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Mappins
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("shouldCollectMappins")]
		[REDProperty(IsIgnored = true)]
		public CBool ShouldCollectMappins
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
