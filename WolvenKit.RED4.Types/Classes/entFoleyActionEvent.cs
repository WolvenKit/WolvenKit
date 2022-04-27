using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entFoleyActionEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("actionName")] 
		public CName ActionName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public entFoleyActionEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
