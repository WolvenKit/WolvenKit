
namespace WolvenKit.RED4.Types
{
	public partial class gamedataEthnicNames_Record
	{
		[RED("displayName")]
		[REDProperty(IsIgnored = true)]
		public gamedataLocKeyWrapper DisplayName
		{
			get => GetPropertyValue<gamedataLocKeyWrapper>();
			set => SetPropertyValue<gamedataLocKeyWrapper>(value);
		}
		
		[RED("ethnicity")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Ethnicity
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("gender")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Gender
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("nameOrderFormat")]
		[REDProperty(IsIgnored = true)]
		public gamedataLocKeyWrapper NameOrderFormat
		{
			get => GetPropertyValue<gamedataLocKeyWrapper>();
			set => SetPropertyValue<gamedataLocKeyWrapper>(value);
		}
		
		[RED("names")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> Names
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("surnames")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> Surnames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("visualTags")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> VisualTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
	}
}
