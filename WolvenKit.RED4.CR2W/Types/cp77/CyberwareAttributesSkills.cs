using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CyberwareAttributesSkills : gameuiWidgetGameController
	{
		private CyberwareAttributes_ContainersStruct _attributes;
		private CyberwareAttributes_ResistancesStruct _resistances;
		private inkTextWidgetReference _levelUpPoints;
		private wCHandle<gameIBlackboard> _uiBlackboard;
		private wCHandle<PlayerPuppet> _playerPuppet;
		private CInt32 _devPoints;
		private CHandle<redCallbackObject> _onAttributesChangeCallback;
		private CHandle<redCallbackObject> _onDevelopmentPointsChangeCallback;
		private CHandle<redCallbackObject> _onProficiencyChangeCallback;
		private CHandle<redCallbackObject> _onMaxHealthChangedCallback;
		private CHandle<redCallbackObject> _onPhysicalResistanceChangedCallback;
		private CHandle<redCallbackObject> _onThermalResistanceChangedCallback;
		private CHandle<redCallbackObject> _onEnergyResistanceChangedCallback;
		private CHandle<redCallbackObject> _onChemicalResistanceChangedCallback;

		[Ordinal(2)] 
		[RED("attributes")] 
		public CyberwareAttributes_ContainersStruct Attributes
		{
			get => GetProperty(ref _attributes);
			set => SetProperty(ref _attributes, value);
		}

		[Ordinal(3)] 
		[RED("resistances")] 
		public CyberwareAttributes_ResistancesStruct Resistances
		{
			get => GetProperty(ref _resistances);
			set => SetProperty(ref _resistances, value);
		}

		[Ordinal(4)] 
		[RED("levelUpPoints")] 
		public inkTextWidgetReference LevelUpPoints
		{
			get => GetProperty(ref _levelUpPoints);
			set => SetProperty(ref _levelUpPoints, value);
		}

		[Ordinal(5)] 
		[RED("uiBlackboard")] 
		public wCHandle<gameIBlackboard> UiBlackboard
		{
			get => GetProperty(ref _uiBlackboard);
			set => SetProperty(ref _uiBlackboard, value);
		}

		[Ordinal(6)] 
		[RED("playerPuppet")] 
		public wCHandle<PlayerPuppet> PlayerPuppet
		{
			get => GetProperty(ref _playerPuppet);
			set => SetProperty(ref _playerPuppet, value);
		}

		[Ordinal(7)] 
		[RED("devPoints")] 
		public CInt32 DevPoints
		{
			get => GetProperty(ref _devPoints);
			set => SetProperty(ref _devPoints, value);
		}

		[Ordinal(8)] 
		[RED("OnAttributesChangeCallback")] 
		public CHandle<redCallbackObject> OnAttributesChangeCallback
		{
			get => GetProperty(ref _onAttributesChangeCallback);
			set => SetProperty(ref _onAttributesChangeCallback, value);
		}

		[Ordinal(9)] 
		[RED("OnDevelopmentPointsChangeCallback")] 
		public CHandle<redCallbackObject> OnDevelopmentPointsChangeCallback
		{
			get => GetProperty(ref _onDevelopmentPointsChangeCallback);
			set => SetProperty(ref _onDevelopmentPointsChangeCallback, value);
		}

		[Ordinal(10)] 
		[RED("OnProficiencyChangeCallback")] 
		public CHandle<redCallbackObject> OnProficiencyChangeCallback
		{
			get => GetProperty(ref _onProficiencyChangeCallback);
			set => SetProperty(ref _onProficiencyChangeCallback, value);
		}

		[Ordinal(11)] 
		[RED("OnMaxHealthChangedCallback")] 
		public CHandle<redCallbackObject> OnMaxHealthChangedCallback
		{
			get => GetProperty(ref _onMaxHealthChangedCallback);
			set => SetProperty(ref _onMaxHealthChangedCallback, value);
		}

		[Ordinal(12)] 
		[RED("OnPhysicalResistanceChangedCallback")] 
		public CHandle<redCallbackObject> OnPhysicalResistanceChangedCallback
		{
			get => GetProperty(ref _onPhysicalResistanceChangedCallback);
			set => SetProperty(ref _onPhysicalResistanceChangedCallback, value);
		}

		[Ordinal(13)] 
		[RED("OnThermalResistanceChangedCallback")] 
		public CHandle<redCallbackObject> OnThermalResistanceChangedCallback
		{
			get => GetProperty(ref _onThermalResistanceChangedCallback);
			set => SetProperty(ref _onThermalResistanceChangedCallback, value);
		}

		[Ordinal(14)] 
		[RED("OnEnergyResistanceChangedCallback")] 
		public CHandle<redCallbackObject> OnEnergyResistanceChangedCallback
		{
			get => GetProperty(ref _onEnergyResistanceChangedCallback);
			set => SetProperty(ref _onEnergyResistanceChangedCallback, value);
		}

		[Ordinal(15)] 
		[RED("OnChemicalResistanceChangedCallback")] 
		public CHandle<redCallbackObject> OnChemicalResistanceChangedCallback
		{
			get => GetProperty(ref _onChemicalResistanceChangedCallback);
			set => SetProperty(ref _onChemicalResistanceChangedCallback, value);
		}

		public CyberwareAttributesSkills(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
