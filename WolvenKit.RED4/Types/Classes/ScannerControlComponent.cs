using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScannerControlComponent : gameScriptableComponent
	{
		[Ordinal(5)] 
		[RED("currentScanType")] 
		public CEnum<MechanicalScanType> CurrentScanType
		{
			get => GetPropertyValue<CEnum<MechanicalScanType>>();
			set => SetPropertyValue<CEnum<MechanicalScanType>>(value);
		}

		[Ordinal(6)] 
		[RED("currentScanEffect")] 
		public CHandle<gameEffectInstance> CurrentScanEffect
		{
			get => GetPropertyValue<CHandle<gameEffectInstance>>();
			set => SetPropertyValue<CHandle<gameEffectInstance>>(value);
		}

		[Ordinal(7)] 
		[RED("currentScanAnimation")] 
		public CName CurrentScanAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("scannerTriggerComponentName")] 
		public CName ScannerTriggerComponentName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("scannerTriggerComponent")] 
		public CHandle<entIComponent> ScannerTriggerComponent
		{
			get => GetPropertyValue<CHandle<entIComponent>>();
			set => SetPropertyValue<CHandle<entIComponent>>(value);
		}

		[Ordinal(10)] 
		[RED("a")] 
		public CHandle<gameStaticTriggerAreaComponent> A
		{
			get => GetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>();
			set => SetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>(value);
		}

		[Ordinal(11)] 
		[RED("isScanningPlayer")] 
		public CBool IsScanningPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ScannerControlComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
