
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAppearance_Record
	{
		[RED("tags")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> Tags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
	}
}
