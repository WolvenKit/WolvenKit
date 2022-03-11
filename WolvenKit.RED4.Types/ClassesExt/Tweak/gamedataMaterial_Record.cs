
namespace WolvenKit.RED4.Types
{
	public partial class gamedataMaterial_Record
	{
		[RED("name")]
		[REDProperty(IsIgnored = true)]
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
