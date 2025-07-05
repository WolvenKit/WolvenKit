using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameTelemetryLevelGained : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("playerPuppet")] 
		public CWeakHandle<gameObject> PlayerPuppet
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("proficiencyType")] 
		public CEnum<gamedataProficiencyType> ProficiencyType
		{
			get => GetPropertyValue<CEnum<gamedataProficiencyType>>();
			set => SetPropertyValue<CEnum<gamedataProficiencyType>>(value);
		}

		[Ordinal(2)] 
		[RED("proficiencyValue")] 
		public CInt32 ProficiencyValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("perkPointsAwarded")] 
		public CInt32 PerkPointsAwarded
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(4)] 
		[RED("attributePointsAwarded")] 
		public CInt32 AttributePointsAwarded
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(5)] 
		[RED("isDebugEvt")] 
		public CBool IsDebugEvt
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameTelemetryLevelGained()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
