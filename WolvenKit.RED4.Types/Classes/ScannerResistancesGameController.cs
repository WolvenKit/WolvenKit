using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScannerResistancesGameController : BaseChunkGameController
	{
		[Ordinal(5)] 
		[RED("physicalResistText")] 
		public inkTextWidgetReference PhysicalResistText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("physicalResistContainer")] 
		public inkCompoundWidgetReference PhysicalResistContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("thermalResistText")] 
		public inkTextWidgetReference ThermalResistText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("thermalResistContainer")] 
		public inkCompoundWidgetReference ThermalResistContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("chemicalResistText")] 
		public inkTextWidgetReference ChemicalResistText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("chemicalResistContainer")] 
		public inkCompoundWidgetReference ChemicalResistContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("electricResistText")] 
		public inkTextWidgetReference ElectricResistText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("electricResistContainer")] 
		public inkCompoundWidgetReference ElectricResistContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("hackingResistText")] 
		public inkTextWidgetReference HackingResistText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("hackingResistContainer")] 
		public inkCompoundWidgetReference HackingResistContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("physicalWeaknessText")] 
		public inkTextWidgetReference PhysicalWeaknessText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("physicalWeaknessContainer")] 
		public inkCompoundWidgetReference PhysicalWeaknessContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("thermalWeaknessText")] 
		public inkTextWidgetReference ThermalWeaknessText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("thermalWeaknessContainer")] 
		public inkCompoundWidgetReference ThermalWeaknessContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("chemicalWeaknessText")] 
		public inkTextWidgetReference ChemicalWeaknessText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("chemicalWeaknessContainer")] 
		public inkCompoundWidgetReference ChemicalWeaknessContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("electricWeaknessText")] 
		public inkTextWidgetReference ElectricWeaknessText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("electricWeaknessContainer")] 
		public inkCompoundWidgetReference ElectricWeaknessContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("hackingWeaknessText")] 
		public inkTextWidgetReference HackingWeaknessText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("hackingWeaknessContainer")] 
		public inkCompoundWidgetReference HackingWeaknessContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("leftPanel")] 
		public inkCompoundWidgetReference LeftPanel
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("rightPanel")] 
		public inkCompoundWidgetReference RightPanel
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("resistancesCallbackID")] 
		public CHandle<redCallbackObject> ResistancesCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(28)] 
		[RED("isValidResistances")] 
		public CBool IsValidResistances
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ScannerResistancesGameController()
		{
			PhysicalResistText = new();
			PhysicalResistContainer = new();
			ThermalResistText = new();
			ThermalResistContainer = new();
			ChemicalResistText = new();
			ChemicalResistContainer = new();
			ElectricResistText = new();
			ElectricResistContainer = new();
			HackingResistText = new();
			HackingResistContainer = new();
			PhysicalWeaknessText = new();
			PhysicalWeaknessContainer = new();
			ThermalWeaknessText = new();
			ThermalWeaknessContainer = new();
			ChemicalWeaknessText = new();
			ChemicalWeaknessContainer = new();
			ElectricWeaknessText = new();
			ElectricWeaknessContainer = new();
			HackingWeaknessText = new();
			HackingWeaknessContainer = new();
			LeftPanel = new();
			RightPanel = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
