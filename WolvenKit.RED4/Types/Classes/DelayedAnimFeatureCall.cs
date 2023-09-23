using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DelayedAnimFeatureCall : gameDelaySystemScriptedDelayCallbackWrapper
	{
		[Ordinal(0)] 
		[RED("featureName")] 
		public CName FeatureName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("animFeature")] 
		public CHandle<animAnimFeature_EquipUnequipItem> AnimFeature
		{
			get => GetPropertyValue<CHandle<animAnimFeature_EquipUnequipItem>>();
			set => SetPropertyValue<CHandle<animAnimFeature_EquipUnequipItem>>(value);
		}

		[Ordinal(2)] 
		[RED("scriptInterface")] 
		public CHandle<gamestateMachineGameScriptInterface> ScriptInterface
		{
			get => GetPropertyValue<CHandle<gamestateMachineGameScriptInterface>>();
			set => SetPropertyValue<CHandle<gamestateMachineGameScriptInterface>>(value);
		}

		public DelayedAnimFeatureCall()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
