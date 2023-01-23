
namespace WolvenKit.RED4.Types
{
	public partial class gamedataDPadUIData_Record
	{
		[RED("restrictionTags")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> RestrictionTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
	}
}
