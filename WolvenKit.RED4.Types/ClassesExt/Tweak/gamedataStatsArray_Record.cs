
namespace WolvenKit.RED4.Types
{
	public partial class gamedataStatsArray_Record
	{
		[RED("additionalStats")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> AdditionalStats
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("arrayName")]
		[REDProperty(IsIgnored = true)]
		public CName ArrayName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("enumStats")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> EnumStats
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
