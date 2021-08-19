using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerResistancesGameController : BaseChunkGameController
	{
		private inkTextWidgetReference _physicalResistText;
		private inkCompoundWidgetReference _physicalResistContainer;
		private inkTextWidgetReference _thermalResistText;
		private inkCompoundWidgetReference _thermalResistContainer;
		private inkTextWidgetReference _chemicalResistText;
		private inkCompoundWidgetReference _chemicalResistContainer;
		private inkTextWidgetReference _electricResistText;
		private inkCompoundWidgetReference _electricResistContainer;
		private inkTextWidgetReference _hackingResistText;
		private inkCompoundWidgetReference _hackingResistContainer;
		private inkTextWidgetReference _physicalWeaknessText;
		private inkCompoundWidgetReference _physicalWeaknessContainer;
		private inkTextWidgetReference _thermalWeaknessText;
		private inkCompoundWidgetReference _thermalWeaknessContainer;
		private inkTextWidgetReference _chemicalWeaknessText;
		private inkCompoundWidgetReference _chemicalWeaknessContainer;
		private inkTextWidgetReference _electricWeaknessText;
		private inkCompoundWidgetReference _electricWeaknessContainer;
		private inkTextWidgetReference _hackingWeaknessText;
		private inkCompoundWidgetReference _hackingWeaknessContainer;
		private inkCompoundWidgetReference _leftPanel;
		private inkCompoundWidgetReference _rightPanel;
		private CHandle<redCallbackObject> _resistancesCallbackID;
		private CBool _isValidResistances;

		[Ordinal(5)] 
		[RED("physicalResistText")] 
		public inkTextWidgetReference PhysicalResistText
		{
			get => GetProperty(ref _physicalResistText);
			set => SetProperty(ref _physicalResistText, value);
		}

		[Ordinal(6)] 
		[RED("physicalResistContainer")] 
		public inkCompoundWidgetReference PhysicalResistContainer
		{
			get => GetProperty(ref _physicalResistContainer);
			set => SetProperty(ref _physicalResistContainer, value);
		}

		[Ordinal(7)] 
		[RED("thermalResistText")] 
		public inkTextWidgetReference ThermalResistText
		{
			get => GetProperty(ref _thermalResistText);
			set => SetProperty(ref _thermalResistText, value);
		}

		[Ordinal(8)] 
		[RED("thermalResistContainer")] 
		public inkCompoundWidgetReference ThermalResistContainer
		{
			get => GetProperty(ref _thermalResistContainer);
			set => SetProperty(ref _thermalResistContainer, value);
		}

		[Ordinal(9)] 
		[RED("chemicalResistText")] 
		public inkTextWidgetReference ChemicalResistText
		{
			get => GetProperty(ref _chemicalResistText);
			set => SetProperty(ref _chemicalResistText, value);
		}

		[Ordinal(10)] 
		[RED("chemicalResistContainer")] 
		public inkCompoundWidgetReference ChemicalResistContainer
		{
			get => GetProperty(ref _chemicalResistContainer);
			set => SetProperty(ref _chemicalResistContainer, value);
		}

		[Ordinal(11)] 
		[RED("electricResistText")] 
		public inkTextWidgetReference ElectricResistText
		{
			get => GetProperty(ref _electricResistText);
			set => SetProperty(ref _electricResistText, value);
		}

		[Ordinal(12)] 
		[RED("electricResistContainer")] 
		public inkCompoundWidgetReference ElectricResistContainer
		{
			get => GetProperty(ref _electricResistContainer);
			set => SetProperty(ref _electricResistContainer, value);
		}

		[Ordinal(13)] 
		[RED("hackingResistText")] 
		public inkTextWidgetReference HackingResistText
		{
			get => GetProperty(ref _hackingResistText);
			set => SetProperty(ref _hackingResistText, value);
		}

		[Ordinal(14)] 
		[RED("hackingResistContainer")] 
		public inkCompoundWidgetReference HackingResistContainer
		{
			get => GetProperty(ref _hackingResistContainer);
			set => SetProperty(ref _hackingResistContainer, value);
		}

		[Ordinal(15)] 
		[RED("physicalWeaknessText")] 
		public inkTextWidgetReference PhysicalWeaknessText
		{
			get => GetProperty(ref _physicalWeaknessText);
			set => SetProperty(ref _physicalWeaknessText, value);
		}

		[Ordinal(16)] 
		[RED("physicalWeaknessContainer")] 
		public inkCompoundWidgetReference PhysicalWeaknessContainer
		{
			get => GetProperty(ref _physicalWeaknessContainer);
			set => SetProperty(ref _physicalWeaknessContainer, value);
		}

		[Ordinal(17)] 
		[RED("thermalWeaknessText")] 
		public inkTextWidgetReference ThermalWeaknessText
		{
			get => GetProperty(ref _thermalWeaknessText);
			set => SetProperty(ref _thermalWeaknessText, value);
		}

		[Ordinal(18)] 
		[RED("thermalWeaknessContainer")] 
		public inkCompoundWidgetReference ThermalWeaknessContainer
		{
			get => GetProperty(ref _thermalWeaknessContainer);
			set => SetProperty(ref _thermalWeaknessContainer, value);
		}

		[Ordinal(19)] 
		[RED("chemicalWeaknessText")] 
		public inkTextWidgetReference ChemicalWeaknessText
		{
			get => GetProperty(ref _chemicalWeaknessText);
			set => SetProperty(ref _chemicalWeaknessText, value);
		}

		[Ordinal(20)] 
		[RED("chemicalWeaknessContainer")] 
		public inkCompoundWidgetReference ChemicalWeaknessContainer
		{
			get => GetProperty(ref _chemicalWeaknessContainer);
			set => SetProperty(ref _chemicalWeaknessContainer, value);
		}

		[Ordinal(21)] 
		[RED("electricWeaknessText")] 
		public inkTextWidgetReference ElectricWeaknessText
		{
			get => GetProperty(ref _electricWeaknessText);
			set => SetProperty(ref _electricWeaknessText, value);
		}

		[Ordinal(22)] 
		[RED("electricWeaknessContainer")] 
		public inkCompoundWidgetReference ElectricWeaknessContainer
		{
			get => GetProperty(ref _electricWeaknessContainer);
			set => SetProperty(ref _electricWeaknessContainer, value);
		}

		[Ordinal(23)] 
		[RED("hackingWeaknessText")] 
		public inkTextWidgetReference HackingWeaknessText
		{
			get => GetProperty(ref _hackingWeaknessText);
			set => SetProperty(ref _hackingWeaknessText, value);
		}

		[Ordinal(24)] 
		[RED("hackingWeaknessContainer")] 
		public inkCompoundWidgetReference HackingWeaknessContainer
		{
			get => GetProperty(ref _hackingWeaknessContainer);
			set => SetProperty(ref _hackingWeaknessContainer, value);
		}

		[Ordinal(25)] 
		[RED("leftPanel")] 
		public inkCompoundWidgetReference LeftPanel
		{
			get => GetProperty(ref _leftPanel);
			set => SetProperty(ref _leftPanel, value);
		}

		[Ordinal(26)] 
		[RED("rightPanel")] 
		public inkCompoundWidgetReference RightPanel
		{
			get => GetProperty(ref _rightPanel);
			set => SetProperty(ref _rightPanel, value);
		}

		[Ordinal(27)] 
		[RED("resistancesCallbackID")] 
		public CHandle<redCallbackObject> ResistancesCallbackID
		{
			get => GetProperty(ref _resistancesCallbackID);
			set => SetProperty(ref _resistancesCallbackID, value);
		}

		[Ordinal(28)] 
		[RED("isValidResistances")] 
		public CBool IsValidResistances
		{
			get => GetProperty(ref _isValidResistances);
			set => SetProperty(ref _isValidResistances, value);
		}

		public ScannerResistancesGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
