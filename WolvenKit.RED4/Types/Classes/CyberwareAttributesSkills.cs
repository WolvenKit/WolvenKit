using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CyberwareAttributesSkills : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("attributes")] 
		public CyberwareAttributes_ContainersStruct Attributes
		{
			get => GetPropertyValue<CyberwareAttributes_ContainersStruct>();
			set => SetPropertyValue<CyberwareAttributes_ContainersStruct>(value);
		}

		[Ordinal(3)] 
		[RED("resistances")] 
		public CyberwareAttributes_ResistancesStruct Resistances
		{
			get => GetPropertyValue<CyberwareAttributes_ResistancesStruct>();
			set => SetPropertyValue<CyberwareAttributes_ResistancesStruct>(value);
		}

		[Ordinal(4)] 
		[RED("levelUpPoints")] 
		public inkTextWidgetReference LevelUpPoints
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("uiBlackboard")] 
		public CWeakHandle<gameIBlackboard> UiBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(6)] 
		[RED("playerPuppet")] 
		public CWeakHandle<PlayerPuppet> PlayerPuppet
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(7)] 
		[RED("devPoints")] 
		public CInt32 DevPoints
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(8)] 
		[RED("OnAttributesChangeCallback")] 
		public CHandle<redCallbackObject> OnAttributesChangeCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(9)] 
		[RED("OnDevelopmentPointsChangeCallback")] 
		public CHandle<redCallbackObject> OnDevelopmentPointsChangeCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(10)] 
		[RED("OnProficiencyChangeCallback")] 
		public CHandle<redCallbackObject> OnProficiencyChangeCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(11)] 
		[RED("OnMaxHealthChangedCallback")] 
		public CHandle<redCallbackObject> OnMaxHealthChangedCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(12)] 
		[RED("OnPhysicalResistanceChangedCallback")] 
		public CHandle<redCallbackObject> OnPhysicalResistanceChangedCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(13)] 
		[RED("OnThermalResistanceChangedCallback")] 
		public CHandle<redCallbackObject> OnThermalResistanceChangedCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(14)] 
		[RED("OnEnergyResistanceChangedCallback")] 
		public CHandle<redCallbackObject> OnEnergyResistanceChangedCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(15)] 
		[RED("OnChemicalResistanceChangedCallback")] 
		public CHandle<redCallbackObject> OnChemicalResistanceChangedCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public CyberwareAttributesSkills()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
