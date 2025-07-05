
namespace WolvenKit.RED4.Types
{
	public partial class gamedataGameplayLogicPackageUIData_Record
	{
		[RED("floatValues")]
		[REDProperty(IsIgnored = true)]
		public CArray<CFloat> FloatValues
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}
		
		[RED("iconPath")]
		[REDProperty(IsIgnored = true)]
		public CName IconPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("intValues")]
		[REDProperty(IsIgnored = true)]
		public CArray<CInt32> IntValues
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}
		
		[RED("localizedDescription")]
		[REDProperty(IsIgnored = true)]
		public CString LocalizedDescription
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("localizedName")]
		[REDProperty(IsIgnored = true)]
		public CString LocalizedName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("maxFactor")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("nameValues")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> NameValues
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("stats")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Stats
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
