
namespace WolvenKit.RED4.Types
{
	public partial class gamedataUICharacterCreationAttribute_Record
	{
		[RED("attribute")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Attribute
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("description")]
		[REDProperty(IsIgnored = true)]
		public CString Description
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("iconPath")]
		[REDProperty(IsIgnored = true)]
		public CName IconPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("shortcut")]
		[REDProperty(IsIgnored = true)]
		public CString Shortcut
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("value")]
		[REDProperty(IsIgnored = true)]
		public CFloat Value
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
