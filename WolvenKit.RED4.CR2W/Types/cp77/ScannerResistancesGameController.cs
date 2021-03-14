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
		private CUInt32 _resistancesCallbackID;
		private CBool _isValidResistances;

		[Ordinal(5)] 
		[RED("physicalResistText")] 
		public inkTextWidgetReference PhysicalResistText
		{
			get
			{
				if (_physicalResistText == null)
				{
					_physicalResistText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "physicalResistText", cr2w, this);
				}
				return _physicalResistText;
			}
			set
			{
				if (_physicalResistText == value)
				{
					return;
				}
				_physicalResistText = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("physicalResistContainer")] 
		public inkCompoundWidgetReference PhysicalResistContainer
		{
			get
			{
				if (_physicalResistContainer == null)
				{
					_physicalResistContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "physicalResistContainer", cr2w, this);
				}
				return _physicalResistContainer;
			}
			set
			{
				if (_physicalResistContainer == value)
				{
					return;
				}
				_physicalResistContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("thermalResistText")] 
		public inkTextWidgetReference ThermalResistText
		{
			get
			{
				if (_thermalResistText == null)
				{
					_thermalResistText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "thermalResistText", cr2w, this);
				}
				return _thermalResistText;
			}
			set
			{
				if (_thermalResistText == value)
				{
					return;
				}
				_thermalResistText = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("thermalResistContainer")] 
		public inkCompoundWidgetReference ThermalResistContainer
		{
			get
			{
				if (_thermalResistContainer == null)
				{
					_thermalResistContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "thermalResistContainer", cr2w, this);
				}
				return _thermalResistContainer;
			}
			set
			{
				if (_thermalResistContainer == value)
				{
					return;
				}
				_thermalResistContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("chemicalResistText")] 
		public inkTextWidgetReference ChemicalResistText
		{
			get
			{
				if (_chemicalResistText == null)
				{
					_chemicalResistText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "chemicalResistText", cr2w, this);
				}
				return _chemicalResistText;
			}
			set
			{
				if (_chemicalResistText == value)
				{
					return;
				}
				_chemicalResistText = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("chemicalResistContainer")] 
		public inkCompoundWidgetReference ChemicalResistContainer
		{
			get
			{
				if (_chemicalResistContainer == null)
				{
					_chemicalResistContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "chemicalResistContainer", cr2w, this);
				}
				return _chemicalResistContainer;
			}
			set
			{
				if (_chemicalResistContainer == value)
				{
					return;
				}
				_chemicalResistContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("electricResistText")] 
		public inkTextWidgetReference ElectricResistText
		{
			get
			{
				if (_electricResistText == null)
				{
					_electricResistText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "electricResistText", cr2w, this);
				}
				return _electricResistText;
			}
			set
			{
				if (_electricResistText == value)
				{
					return;
				}
				_electricResistText = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("electricResistContainer")] 
		public inkCompoundWidgetReference ElectricResistContainer
		{
			get
			{
				if (_electricResistContainer == null)
				{
					_electricResistContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "electricResistContainer", cr2w, this);
				}
				return _electricResistContainer;
			}
			set
			{
				if (_electricResistContainer == value)
				{
					return;
				}
				_electricResistContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("hackingResistText")] 
		public inkTextWidgetReference HackingResistText
		{
			get
			{
				if (_hackingResistText == null)
				{
					_hackingResistText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "hackingResistText", cr2w, this);
				}
				return _hackingResistText;
			}
			set
			{
				if (_hackingResistText == value)
				{
					return;
				}
				_hackingResistText = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("hackingResistContainer")] 
		public inkCompoundWidgetReference HackingResistContainer
		{
			get
			{
				if (_hackingResistContainer == null)
				{
					_hackingResistContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "hackingResistContainer", cr2w, this);
				}
				return _hackingResistContainer;
			}
			set
			{
				if (_hackingResistContainer == value)
				{
					return;
				}
				_hackingResistContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("physicalWeaknessText")] 
		public inkTextWidgetReference PhysicalWeaknessText
		{
			get
			{
				if (_physicalWeaknessText == null)
				{
					_physicalWeaknessText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "physicalWeaknessText", cr2w, this);
				}
				return _physicalWeaknessText;
			}
			set
			{
				if (_physicalWeaknessText == value)
				{
					return;
				}
				_physicalWeaknessText = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("physicalWeaknessContainer")] 
		public inkCompoundWidgetReference PhysicalWeaknessContainer
		{
			get
			{
				if (_physicalWeaknessContainer == null)
				{
					_physicalWeaknessContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "physicalWeaknessContainer", cr2w, this);
				}
				return _physicalWeaknessContainer;
			}
			set
			{
				if (_physicalWeaknessContainer == value)
				{
					return;
				}
				_physicalWeaknessContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("thermalWeaknessText")] 
		public inkTextWidgetReference ThermalWeaknessText
		{
			get
			{
				if (_thermalWeaknessText == null)
				{
					_thermalWeaknessText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "thermalWeaknessText", cr2w, this);
				}
				return _thermalWeaknessText;
			}
			set
			{
				if (_thermalWeaknessText == value)
				{
					return;
				}
				_thermalWeaknessText = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("thermalWeaknessContainer")] 
		public inkCompoundWidgetReference ThermalWeaknessContainer
		{
			get
			{
				if (_thermalWeaknessContainer == null)
				{
					_thermalWeaknessContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "thermalWeaknessContainer", cr2w, this);
				}
				return _thermalWeaknessContainer;
			}
			set
			{
				if (_thermalWeaknessContainer == value)
				{
					return;
				}
				_thermalWeaknessContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("chemicalWeaknessText")] 
		public inkTextWidgetReference ChemicalWeaknessText
		{
			get
			{
				if (_chemicalWeaknessText == null)
				{
					_chemicalWeaknessText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "chemicalWeaknessText", cr2w, this);
				}
				return _chemicalWeaknessText;
			}
			set
			{
				if (_chemicalWeaknessText == value)
				{
					return;
				}
				_chemicalWeaknessText = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("chemicalWeaknessContainer")] 
		public inkCompoundWidgetReference ChemicalWeaknessContainer
		{
			get
			{
				if (_chemicalWeaknessContainer == null)
				{
					_chemicalWeaknessContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "chemicalWeaknessContainer", cr2w, this);
				}
				return _chemicalWeaknessContainer;
			}
			set
			{
				if (_chemicalWeaknessContainer == value)
				{
					return;
				}
				_chemicalWeaknessContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("electricWeaknessText")] 
		public inkTextWidgetReference ElectricWeaknessText
		{
			get
			{
				if (_electricWeaknessText == null)
				{
					_electricWeaknessText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "electricWeaknessText", cr2w, this);
				}
				return _electricWeaknessText;
			}
			set
			{
				if (_electricWeaknessText == value)
				{
					return;
				}
				_electricWeaknessText = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("electricWeaknessContainer")] 
		public inkCompoundWidgetReference ElectricWeaknessContainer
		{
			get
			{
				if (_electricWeaknessContainer == null)
				{
					_electricWeaknessContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "electricWeaknessContainer", cr2w, this);
				}
				return _electricWeaknessContainer;
			}
			set
			{
				if (_electricWeaknessContainer == value)
				{
					return;
				}
				_electricWeaknessContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("hackingWeaknessText")] 
		public inkTextWidgetReference HackingWeaknessText
		{
			get
			{
				if (_hackingWeaknessText == null)
				{
					_hackingWeaknessText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "hackingWeaknessText", cr2w, this);
				}
				return _hackingWeaknessText;
			}
			set
			{
				if (_hackingWeaknessText == value)
				{
					return;
				}
				_hackingWeaknessText = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("hackingWeaknessContainer")] 
		public inkCompoundWidgetReference HackingWeaknessContainer
		{
			get
			{
				if (_hackingWeaknessContainer == null)
				{
					_hackingWeaknessContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "hackingWeaknessContainer", cr2w, this);
				}
				return _hackingWeaknessContainer;
			}
			set
			{
				if (_hackingWeaknessContainer == value)
				{
					return;
				}
				_hackingWeaknessContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("leftPanel")] 
		public inkCompoundWidgetReference LeftPanel
		{
			get
			{
				if (_leftPanel == null)
				{
					_leftPanel = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "leftPanel", cr2w, this);
				}
				return _leftPanel;
			}
			set
			{
				if (_leftPanel == value)
				{
					return;
				}
				_leftPanel = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("rightPanel")] 
		public inkCompoundWidgetReference RightPanel
		{
			get
			{
				if (_rightPanel == null)
				{
					_rightPanel = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "rightPanel", cr2w, this);
				}
				return _rightPanel;
			}
			set
			{
				if (_rightPanel == value)
				{
					return;
				}
				_rightPanel = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("resistancesCallbackID")] 
		public CUInt32 ResistancesCallbackID
		{
			get
			{
				if (_resistancesCallbackID == null)
				{
					_resistancesCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "resistancesCallbackID", cr2w, this);
				}
				return _resistancesCallbackID;
			}
			set
			{
				if (_resistancesCallbackID == value)
				{
					return;
				}
				_resistancesCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("isValidResistances")] 
		public CBool IsValidResistances
		{
			get
			{
				if (_isValidResistances == null)
				{
					_isValidResistances = (CBool) CR2WTypeManager.Create("Bool", "isValidResistances", cr2w, this);
				}
				return _isValidResistances;
			}
			set
			{
				if (_isValidResistances == value)
				{
					return;
				}
				_isValidResistances = value;
				PropertySet(this);
			}
		}

		public ScannerResistancesGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
