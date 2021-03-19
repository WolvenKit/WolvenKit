using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendEmitterDelaySettings : CVariable
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

		public rendEmitterDelaySettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
