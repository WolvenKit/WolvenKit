
namespace WolvenKit.RED4.Types
{
	public partial class gamedataTrait_Record
	{
		[RED("baseTraitData")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID BaseTraitData
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
		
		[RED("infiniteTraitData")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID InfiniteTraitData
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
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
		
		[RED("requirement")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Requirement
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("traitIcon")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID TraitIcon
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
