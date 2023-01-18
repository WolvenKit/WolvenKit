using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UI_PlayerStatsDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("MaxHealth")] 
		public gamebbScriptID_Int32 MaxHealth
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(1)] 
		[RED("CurrentHealth")] 
		public gamebbScriptID_Int32 CurrentHealth
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(2)] 
		[RED("PhysicalResistance")] 
		public gamebbScriptID_Int32 PhysicalResistance
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(3)] 
		[RED("ThermalResistance")] 
		public gamebbScriptID_Int32 ThermalResistance
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(4)] 
		[RED("EnergyResistance")] 
		public gamebbScriptID_Int32 EnergyResistance
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(5)] 
		[RED("ChemicalResistance")] 
		public gamebbScriptID_Int32 ChemicalResistance
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(6)] 
		[RED("Level")] 
		public gamebbScriptID_Int32 Level
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(7)] 
		[RED("CurrentXP")] 
		public gamebbScriptID_Int32 CurrentXP
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(8)] 
		[RED("StreetCredLevel")] 
		public gamebbScriptID_Int32 StreetCredLevel
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(9)] 
		[RED("StreetCredPoints")] 
		public gamebbScriptID_Int32 StreetCredPoints
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(10)] 
		[RED("Attributes")] 
		public gamebbScriptID_Variant Attributes
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(11)] 
		[RED("DevelopmentPoints")] 
		public gamebbScriptID_Variant DevelopmentPoints
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(12)] 
		[RED("Proficiency")] 
		public gamebbScriptID_Variant Proficiency
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(13)] 
		[RED("Perks")] 
		public gamebbScriptID_Variant Perks
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(14)] 
		[RED("ModifiedPerkArea")] 
		public gamebbScriptID_Variant ModifiedPerkArea
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(15)] 
		[RED("weightMax")] 
		public gamebbScriptID_Int32 WeightMax
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(16)] 
		[RED("currentInventoryWeight")] 
		public gamebbScriptID_Float CurrentInventoryWeight
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(17)] 
		[RED("isReplacer")] 
		public gamebbScriptID_Bool IsReplacer
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public UI_PlayerStatsDef()
		{
			MaxHealth = new();
			CurrentHealth = new();
			PhysicalResistance = new();
			ThermalResistance = new();
			EnergyResistance = new();
			ChemicalResistance = new();
			Level = new();
			CurrentXP = new();
			StreetCredLevel = new();
			StreetCredPoints = new();
			Attributes = new();
			DevelopmentPoints = new();
			Proficiency = new();
			Perks = new();
			ModifiedPerkArea = new();
			WeightMax = new();
			CurrentInventoryWeight = new();
			IsReplacer = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
