
namespace WolvenKit.RED4.Types
{
	public partial class gamedataItemType_Record
	{
		[RED("animFeatureIndex")]
		[REDProperty(IsIgnored = true)]
		public CInt32 AnimFeatureIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("localizedType")]
		[REDProperty(IsIgnored = true)]
		public gamedataLocKeyWrapper LocalizedType
		{
			get => GetPropertyValue<gamedataLocKeyWrapper>();
			set => SetPropertyValue<gamedataLocKeyWrapper>(value);
		}
		
		[RED("name")]
		[REDProperty(IsIgnored = true)]
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
