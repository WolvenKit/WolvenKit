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
			get => GetProperty(ref _maxHealth);
			set => SetProperty(ref _maxHealth, value);
		}

		[Ordinal(1)] 
		[RED("CurrentHealth")] 
		public gamebbScriptID_Int32 CurrentHealth
		{
			get => GetProperty(ref _currentHealth);
			set => SetProperty(ref _currentHealth, value);
		}

		[Ordinal(2)] 
		[RED("PhysicalResistance")] 
		public gamebbScriptID_Int32 PhysicalResistance
		{
			get => GetProperty(ref _physicalResistance);
			set => SetProperty(ref _physicalResistance, value);
		}

		[Ordinal(3)] 
		[RED("ThermalResistance")] 
		public gamebbScriptID_Int32 ThermalResistance
		{
			get => GetProperty(ref _thermalResistance);
			set => SetProperty(ref _thermalResistance, value);
		}

		[Ordinal(4)] 
		[RED("EnergyResistance")] 
		public gamebbScriptID_Int32 EnergyResistance
		{
			get => GetProperty(ref _energyResistance);
			set => SetProperty(ref _energyResistance, value);
		}

		[Ordinal(5)] 
		[RED("ChemicalResistance")] 
		public gamebbScriptID_Int32 ChemicalResistance
		{
			get => GetProperty(ref _chemicalResistance);
			set => SetProperty(ref _chemicalResistance, value);
		}

		[Ordinal(6)] 
		[RED("Level")] 
		public gamebbScriptID_Int32 Level
		{
			get => GetProperty(ref _level);
			set => SetProperty(ref _level, value);
		}

		[Ordinal(7)] 
		[RED("CurrentXP")] 
		public gamebbScriptID_Int32 CurrentXP
		{
			get => GetProperty(ref _currentXP);
			set => SetProperty(ref _currentXP, value);
		}

		[Ordinal(8)] 
		[RED("StreetCredLevel")] 
		public gamebbScriptID_Int32 StreetCredLevel
		{
			get => GetProperty(ref _streetCredLevel);
			set => SetProperty(ref _streetCredLevel, value);
		}

		[Ordinal(9)] 
		[RED("StreetCredPoints")] 
		public gamebbScriptID_Int32 StreetCredPoints
		{
			get => GetProperty(ref _streetCredPoints);
			set => SetProperty(ref _streetCredPoints, value);
		}

		[Ordinal(10)] 
		[RED("Attributes")] 
		public gamebbScriptID_Variant Attributes
		{
			get => GetProperty(ref _attributes);
			set => SetProperty(ref _attributes, value);
		}

		[Ordinal(11)] 
		[RED("DevelopmentPoints")] 
		public gamebbScriptID_Variant DevelopmentPoints
		{
			get => GetProperty(ref _developmentPoints);
			set => SetProperty(ref _developmentPoints, value);
		}

		[Ordinal(12)] 
		[RED("Proficiency")] 
		public gamebbScriptID_Variant Proficiency
		{
			get => GetProperty(ref _proficiency);
			set => SetProperty(ref _proficiency, value);
		}

		[Ordinal(13)] 
		[RED("Perks")] 
		public gamebbScriptID_Variant Perks
		{
			get => GetProperty(ref _perks);
			set => SetProperty(ref _perks, value);
		}

		[Ordinal(14)] 
		[RED("ModifiedPerkArea")] 
		public gamebbScriptID_Variant ModifiedPerkArea
		{
			get => GetProperty(ref _modifiedPerkArea);
			set => SetProperty(ref _modifiedPerkArea, value);
		}

		[Ordinal(15)] 
		[RED("weightMax")] 
		public gamebbScriptID_Int32 WeightMax
		{
			get => GetProperty(ref _weightMax);
			set => SetProperty(ref _weightMax, value);
		}

		[Ordinal(16)] 
		[RED("currentInventoryWeight")] 
		public gamebbScriptID_Float CurrentInventoryWeight
		{
			get => GetProperty(ref _currentInventoryWeight);
			set => SetProperty(ref _currentInventoryWeight, value);
		}

		[Ordinal(17)] 
		[RED("isReplacer")] 
		public gamebbScriptID_Bool IsReplacer
		{
			get => GetProperty(ref _isReplacer);
			set => SetProperty(ref _isReplacer, value);
		}

		public UI_PlayerStatsDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
