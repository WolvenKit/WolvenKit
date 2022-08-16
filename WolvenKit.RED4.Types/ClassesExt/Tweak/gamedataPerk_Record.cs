
namespace WolvenKit.RED4.Types
{
	public partial class gamedataPerk_Record
	{
		[RED("binkPath")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> BinkPath
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("displayName")]
		[REDProperty(IsIgnored = true)]
		public CString DisplayName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
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
		
		[RED("iconPath")]
		[REDProperty(IsIgnored = true)]
		public CName IconPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("levels")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Levels
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
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
		
		[RED("perkIcon")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID PerkIcon
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("utility")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Utility
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
