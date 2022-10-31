
namespace WolvenKit.RED4.Types
{
	public partial class gamedataScannableData_Record
	{
		[RED("friendlyName")]
		[REDProperty(IsIgnored = true)]
		public CString FriendlyName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("iconName")]
		[REDProperty(IsIgnored = true)]
		public CName IconName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("iconRecord")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID IconRecord
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("localizedDescription")]
		[REDProperty(IsIgnored = true)]
		public gamedataLocKeyWrapper LocalizedDescription
		{
			get => GetPropertyValue<gamedataLocKeyWrapper>();
			set => SetPropertyValue<gamedataLocKeyWrapper>(value);
		}
		
		[RED("localizedName")]
		[REDProperty(IsIgnored = true)]
		public gamedataLocKeyWrapper LocalizedName
		{
			get => GetPropertyValue<gamedataLocKeyWrapper>();
			set => SetPropertyValue<gamedataLocKeyWrapper>(value);
		}
	}
}
