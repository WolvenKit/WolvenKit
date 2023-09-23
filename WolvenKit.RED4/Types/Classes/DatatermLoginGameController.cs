using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DatatermLoginGameController : BaseBunkerComputerGameController
	{
		[Ordinal(4)] 
		[RED("loopAnimName")] 
		public CName LoopAnimName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("alphaSys")] 
		public inkWidgetReference AlphaSys
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("bravoSys")] 
		public inkWidgetReference BravoSys
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("sierraSys")] 
		public inkWidgetReference SierraSys
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("victorSys")] 
		public inkWidgetReference VictorSys
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public DatatermLoginGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
