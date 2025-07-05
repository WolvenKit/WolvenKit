
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAttributeData_Record
	{
		[RED("attribute")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Attribute
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("attrIcon")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID AttrIcon
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("enumComment")]
		[REDProperty(IsIgnored = true)]
		public CString EnumComment
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("enumName")]
		[REDProperty(IsIgnored = true)]
		public CName EnumName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("loc_desc_key")]
		[REDProperty(IsIgnored = true)]
		public CString Loc_desc_key
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("loc_name_key")]
		[REDProperty(IsIgnored = true)]
		public CString Loc_name_key
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("perks")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Perks
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
	}
}
