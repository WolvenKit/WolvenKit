
namespace WolvenKit.RED4.Types
{
	public partial class gamedataGameplayTagsPrereq_Record
	{
		[RED("allowedTags")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> AllowedTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
	}
}
