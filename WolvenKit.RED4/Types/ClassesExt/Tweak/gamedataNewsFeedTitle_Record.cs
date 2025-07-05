
namespace WolvenKit.RED4.Types
{
	public partial class gamedataNewsFeedTitle_Record
	{
		[RED("titlesList")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> TitlesList
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
	}
}
