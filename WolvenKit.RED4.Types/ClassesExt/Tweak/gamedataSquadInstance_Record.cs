
namespace WolvenKit.RED4.Types
{
	public partial class gamedataSquadInstance_Record
	{
		[RED("squadName")]
		[REDProperty(IsIgnored = true)]
		public CName SquadName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("squadTemplate")]
		[REDProperty(IsIgnored = true)]
		public CName SquadTemplate
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
