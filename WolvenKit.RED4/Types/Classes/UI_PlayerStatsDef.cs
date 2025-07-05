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
		[RED("RequiredXP")] 
		public gamebbScriptID_Int32 RequiredXP
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(9)] 
		[RED("StreetCredLevel")] 
		public gamebbScriptID_Int32 StreetCredLevel
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(10)] 
		[RED("StreetCredPoints")] 
		public gamebbScriptID_Int32 StreetCredPoints
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(11)] 
		[RED("Attributes")] 
		public gamebbScriptID_Variant Attributes
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(12)] 
		[RED("DevelopmentPoints")] 
		public gamebbScriptID_Variant DevelopmentPoints
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(13)] 
		[RED("Proficiency")] 
		public gamebbScriptID_Variant Proficiency
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(14)] 
		[RED("Perks")] 
		public gamebbScriptID_Variant Perks
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(15)] 
		[RED("ModifiedPerkArea")] 
		public gamebbScriptID_Variant ModifiedPerkArea
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(16)] 
		[RED("weightMax")] 
		public gamebbScriptID_Int32 WeightMax
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(17)] 
		[RED("currentInventoryWeight")] 
		public gamebbScriptID_Float CurrentInventoryWeight
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(18)] 
		[RED("isReplacer")] 
		public gamebbScriptID_Bool IsReplacer
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public UI_PlayerStatsDef()
		{
			MaxHealth = new gamebbScriptID_Int32();
			CurrentHealth = new gamebbScriptID_Int32();
			PhysicalResistance = new gamebbScriptID_Int32();
			ThermalResistance = new gamebbScriptID_Int32();
			EnergyResistance = new gamebbScriptID_Int32();
			ChemicalResistance = new gamebbScriptID_Int32();
			Level = new gamebbScriptID_Int32();
			CurrentXP = new gamebbScriptID_Int32();
			RequiredXP = new gamebbScriptID_Int32();
			StreetCredLevel = new gamebbScriptID_Int32();
			StreetCredPoints = new gamebbScriptID_Int32();
			Attributes = new gamebbScriptID_Variant();
			DevelopmentPoints = new gamebbScriptID_Variant();
			Proficiency = new gamebbScriptID_Variant();
			Perks = new gamebbScriptID_Variant();
			ModifiedPerkArea = new gamebbScriptID_Variant();
			WeightMax = new gamebbScriptID_Int32();
			CurrentInventoryWeight = new gamebbScriptID_Float();
			IsReplacer = new gamebbScriptID_Bool();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
