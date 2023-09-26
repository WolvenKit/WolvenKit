
namespace WolvenKit.RED4.Types
{
	public partial class gamedataSearchFilterMaskTypeCond_Record
	{
		[RED("opType")]
		[REDProperty(IsIgnored = true)]
		public CName OpType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("values")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Values
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
