using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameFactChangedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("factName")] 
		public CName FactName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
