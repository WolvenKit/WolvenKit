
namespace WolvenKit.RED4.Types
{
	public partial class gamedataSubstat_Record
	{
		[RED("modifierType")]
		[REDProperty(IsIgnored = true)]
		public CName ModifierType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
