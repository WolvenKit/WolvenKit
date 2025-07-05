
namespace WolvenKit.RED4.Types
{
	public partial class gamedataCooldownType_Record
	{
		[RED("type")]
		[REDProperty(IsIgnored = true)]
		public CName Type
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
