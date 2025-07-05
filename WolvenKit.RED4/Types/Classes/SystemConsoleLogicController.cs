using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SystemConsoleLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("alphaSys")] 
		public inkWidgetReference AlphaSys
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("bravoSys")] 
		public inkWidgetReference BravoSys
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("sierraSys")] 
		public inkWidgetReference SierraSys
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("victorSys")] 
		public inkWidgetReference VictorSys
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public SystemConsoleLogicController()
		{
			AlphaSys = new inkWidgetReference();
			BravoSys = new inkWidgetReference();
			SierraSys = new inkWidgetReference();
			VictorSys = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
