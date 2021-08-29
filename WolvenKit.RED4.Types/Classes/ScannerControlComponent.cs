using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerControlComponent : gameScriptableComponent
	{
		private CEnum<MechanicalScanType> _currentScanType;
		private CHandle<gameEffectInstance> _currentScanEffect;
		private CName _currentScanAnimation;
		private CName _scannerTriggerComponentName;
		private CHandle<entIComponent> _scannerTriggerComponent;
		private CHandle<gameStaticTriggerAreaComponent> _a;
		private CBool _isScanningPlayer;

		[Ordinal(5)] 
		[RED("currentScanType")] 
		public CEnum<MechanicalScanType> CurrentScanType
		{
			get => GetProperty(ref _currentScanType);
			set => SetProperty(ref _currentScanType, value);
		}

		[Ordinal(6)] 
		[RED("currentScanEffect")] 
		public CHandle<gameEffectInstance> CurrentScanEffect
		{
			get => GetProperty(ref _currentScanEffect);
			set => SetProperty(ref _currentScanEffect, value);
		}

		[Ordinal(7)] 
		[RED("currentScanAnimation")] 
		public CName CurrentScanAnimation
		{
			get => GetProperty(ref _currentScanAnimation);
			set => SetProperty(ref _currentScanAnimation, value);
		}

		[Ordinal(8)] 
		[RED("scannerTriggerComponentName")] 
		public CName ScannerTriggerComponentName
		{
			get => GetProperty(ref _scannerTriggerComponentName);
			set => SetProperty(ref _scannerTriggerComponentName, value);
		}

		[Ordinal(9)] 
		[RED("scannerTriggerComponent")] 
		public CHandle<entIComponent> ScannerTriggerComponent
		{
			get => GetProperty(ref _scannerTriggerComponent);
			set => SetProperty(ref _scannerTriggerComponent, value);
		}

		[Ordinal(10)] 
		[RED("a")] 
		public CHandle<gameStaticTriggerAreaComponent> A
		{
			get => GetProperty(ref _a);
			set => SetProperty(ref _a, value);
		}

		[Ordinal(11)] 
		[RED("isScanningPlayer")] 
		public CBool IsScanningPlayer
		{
			get => GetProperty(ref _isScanningPlayer);
			set => SetProperty(ref _isScanningPlayer, value);
		}
	}
}
