
namespace WolvenKit.RED4.Types
{
	public partial class gamedataModifyStaminaHandlerEffector_Record
	{
		[RED("opSymbol")]
		[REDProperty(IsIgnored = true)]
		public CName OpSymbol
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
