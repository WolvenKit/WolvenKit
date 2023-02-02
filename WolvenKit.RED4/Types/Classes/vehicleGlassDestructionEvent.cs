using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleGlassDestructionEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("glassName")] 
		public CName GlassName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public vehicleGlassDestructionEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
