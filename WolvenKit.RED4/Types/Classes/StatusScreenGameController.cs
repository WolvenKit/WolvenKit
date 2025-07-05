using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StatusScreenGameController : BaseBunkerComputerGameController
	{
		[Ordinal(4)] 
		[RED("alphaSys")] 
		public inkWidgetReference AlphaSys
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("bravoSys")] 
		public inkWidgetReference BravoSys
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("sierraSys")] 
		public inkWidgetReference SierraSys
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("victorSys")] 
		public inkWidgetReference VictorSys
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("sierraBackupSys")] 
		public inkWidgetReference SierraBackupSys
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("victorBackupSys")] 
		public inkWidgetReference VictorBackupSys
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public StatusScreenGameController()
		{
			AlphaSys = new inkWidgetReference();
			BravoSys = new inkWidgetReference();
			SierraSys = new inkWidgetReference();
			VictorSys = new inkWidgetReference();
			SierraBackupSys = new inkWidgetReference();
			VictorBackupSys = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
