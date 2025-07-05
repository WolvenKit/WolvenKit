
namespace WolvenKit.RED4.Types
{
	public partial class gamedataIPrereq_Record
	{
		[RED("prereqClassName")]
		[REDProperty(IsIgnored = true)]
		public CName PrereqClassName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
