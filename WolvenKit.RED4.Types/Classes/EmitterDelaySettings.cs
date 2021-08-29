using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EmitterDelaySettings : RedBaseClass
	{
		private CFloat _emitterDelay;
		private CFloat _emitterDelayLow;
		private CBool _useEmitterDelayRange;
		private CBool _useEmitterDelayOnce;

		[Ordinal(0)] 
		[RED("emitterDelay")] 
		public CFloat EmitterDelay
		{
			get => GetProperty(ref _emitterDelay);
			set => SetProperty(ref _emitterDelay, value);
		}

		[Ordinal(1)] 
		[RED("emitterDelayLow")] 
		public CFloat EmitterDelayLow
		{
			get => GetProperty(ref _emitterDelayLow);
			set => SetProperty(ref _emitterDelayLow, value);
		}

		[Ordinal(2)] 
		[RED("useEmitterDelayRange")] 
		public CBool UseEmitterDelayRange
		{
			get => GetProperty(ref _useEmitterDelayRange);
			set => SetProperty(ref _useEmitterDelayRange, value);
		}

		[Ordinal(3)] 
		[RED("useEmitterDelayOnce")] 
		public CBool UseEmitterDelayOnce
		{
			get => GetProperty(ref _useEmitterDelayOnce);
			set => SetProperty(ref _useEmitterDelayOnce, value);
		}
	}
}
