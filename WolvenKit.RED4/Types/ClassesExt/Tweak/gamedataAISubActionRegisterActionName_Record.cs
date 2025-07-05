
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionRegisterActionName_Record
	{
		[RED("actionName")]
		[REDProperty(IsIgnored = true)]
		public CName ActionName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
