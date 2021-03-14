using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_PlayerStatsDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Int32 _maxHealth;
		private gamebbScriptID_Int32 _currentHealth;
		private gamebbScriptID_Int32 _physicalResistance;
		private gamebbScriptID_Int32 _thermalResistance;
		private gamebbScriptID_Int32 _energyResistance;
		private gamebbScriptID_Int32 _chemicalResistance;
		private gamebbScriptID_Int32 _level;
		private gamebbScriptID_Int32 _currentXP;
		private gamebbScriptID_Int32 _streetCredLevel;
		private gamebbScriptID_Int32 _streetCredPoints;
		private gamebbScriptID_Variant _attributes;
		private gamebbScriptID_Variant _developmentPoints;
		private gamebbScriptID_Variant _proficiency;
		private gamebbScriptID_Variant _perks;
		private gamebbScriptID_Variant _modifiedPerkArea;
		private gamebbScriptID_Int32 _weightMax;
		private gamebbScriptID_Float _currentInventoryWeight;
		private gamebbScriptID_Bool _isReplacer;

		[Ordinal(0)] 
		[RED("MaxHealth")] 
		public gamebbScriptID_Int32 MaxHealth
		{
			get
			{
				if (_maxHealth == null)
				{
					_maxHealth = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "MaxHealth", cr2w, this);
				}
				return _maxHealth;
			}
			set
			{
				if (_maxHealth == value)
				{
					return;
				}
				_maxHealth = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("CurrentHealth")] 
		public gamebbScriptID_Int32 CurrentHealth
		{
			get
			{
				if (_currentHealth == null)
				{
					_currentHealth = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "CurrentHealth", cr2w, this);
				}
				return _currentHealth;
			}
			set
			{
				if (_currentHealth == value)
				{
					return;
				}
				_currentHealth = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("PhysicalResistance")] 
		public gamebbScriptID_Int32 PhysicalResistance
		{
			get
			{
				if (_physicalResistance == null)
				{
					_physicalResistance = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "PhysicalResistance", cr2w, this);
				}
				return _physicalResistance;
			}
			set
			{
				if (_physicalResistance == value)
				{
					return;
				}
				_physicalResistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("ThermalResistance")] 
		public gamebbScriptID_Int32 ThermalResistance
		{
			get
			{
				if (_thermalResistance == null)
				{
					_thermalResistance = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "ThermalResistance", cr2w, this);
				}
				return _thermalResistance;
			}
			set
			{
				if (_thermalResistance == value)
				{
					return;
				}
				_thermalResistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("EnergyResistance")] 
		public gamebbScriptID_Int32 EnergyResistance
		{
			get
			{
				if (_energyResistance == null)
				{
					_energyResistance = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "EnergyResistance", cr2w, this);
				}
				return _energyResistance;
			}
			set
			{
				if (_energyResistance == value)
				{
					return;
				}
				_energyResistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("ChemicalResistance")] 
		public gamebbScriptID_Int32 ChemicalResistance
		{
			get
			{
				if (_chemicalResistance == null)
				{
					_chemicalResistance = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "ChemicalResistance", cr2w, this);
				}
				return _chemicalResistance;
			}
			set
			{
				if (_chemicalResistance == value)
				{
					return;
				}
				_chemicalResistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("Level")] 
		public gamebbScriptID_Int32 Level
		{
			get
			{
				if (_level == null)
				{
					_level = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "Level", cr2w, this);
				}
				return _level;
			}
			set
			{
				if (_level == value)
				{
					return;
				}
				_level = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("CurrentXP")] 
		public gamebbScriptID_Int32 CurrentXP
		{
			get
			{
				if (_currentXP == null)
				{
					_currentXP = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "CurrentXP", cr2w, this);
				}
				return _currentXP;
			}
			set
			{
				if (_currentXP == value)
				{
					return;
				}
				_currentXP = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("StreetCredLevel")] 
		public gamebbScriptID_Int32 StreetCredLevel
		{
			get
			{
				if (_streetCredLevel == null)
				{
					_streetCredLevel = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "StreetCredLevel", cr2w, this);
				}
				return _streetCredLevel;
			}
			set
			{
				if (_streetCredLevel == value)
				{
					return;
				}
				_streetCredLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("StreetCredPoints")] 
		public gamebbScriptID_Int32 StreetCredPoints
		{
			get
			{
				if (_streetCredPoints == null)
				{
					_streetCredPoints = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "StreetCredPoints", cr2w, this);
				}
				return _streetCredPoints;
			}
			set
			{
				if (_streetCredPoints == value)
				{
					return;
				}
				_streetCredPoints = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("Attributes")] 
		public gamebbScriptID_Variant Attributes
		{
			get
			{
				if (_attributes == null)
				{
					_attributes = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "Attributes", cr2w, this);
				}
				return _attributes;
			}
			set
			{
				if (_attributes == value)
				{
					return;
				}
				_attributes = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("DevelopmentPoints")] 
		public gamebbScriptID_Variant DevelopmentPoints
		{
			get
			{
				if (_developmentPoints == null)
				{
					_developmentPoints = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "DevelopmentPoints", cr2w, this);
				}
				return _developmentPoints;
			}
			set
			{
				if (_developmentPoints == value)
				{
					return;
				}
				_developmentPoints = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("Proficiency")] 
		public gamebbScriptID_Variant Proficiency
		{
			get
			{
				if (_proficiency == null)
				{
					_proficiency = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "Proficiency", cr2w, this);
				}
				return _proficiency;
			}
			set
			{
				if (_proficiency == value)
				{
					return;
				}
				_proficiency = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("Perks")] 
		public gamebbScriptID_Variant Perks
		{
			get
			{
				if (_perks == null)
				{
					_perks = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "Perks", cr2w, this);
				}
				return _perks;
			}
			set
			{
				if (_perks == value)
				{
					return;
				}
				_perks = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("ModifiedPerkArea")] 
		public gamebbScriptID_Variant ModifiedPerkArea
		{
			get
			{
				if (_modifiedPerkArea == null)
				{
					_modifiedPerkArea = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "ModifiedPerkArea", cr2w, this);
				}
				return _modifiedPerkArea;
			}
			set
			{
				if (_modifiedPerkArea == value)
				{
					return;
				}
				_modifiedPerkArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("weightMax")] 
		public gamebbScriptID_Int32 WeightMax
		{
			get
			{
				if (_weightMax == null)
				{
					_weightMax = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "weightMax", cr2w, this);
				}
				return _weightMax;
			}
			set
			{
				if (_weightMax == value)
				{
					return;
				}
				_weightMax = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("currentInventoryWeight")] 
		public gamebbScriptID_Float CurrentInventoryWeight
		{
			get
			{
				if (_currentInventoryWeight == null)
				{
					_currentInventoryWeight = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "currentInventoryWeight", cr2w, this);
				}
				return _currentInventoryWeight;
			}
			set
			{
				if (_currentInventoryWeight == value)
				{
					return;
				}
				_currentInventoryWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("isReplacer")] 
		public gamebbScriptID_Bool IsReplacer
		{
			get
			{
				if (_isReplacer == null)
				{
					_isReplacer = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "isReplacer", cr2w, this);
				}
				return _isReplacer;
			}
			set
			{
				if (_isReplacer == value)
				{
					return;
				}
				_isReplacer = value;
				PropertySet(this);
			}
		}

		public UI_PlayerStatsDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
