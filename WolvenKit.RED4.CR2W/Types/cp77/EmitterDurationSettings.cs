using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EmitterDurationSettings : CVariable
	{
		private CFloat _emitterDuration;
		private CFloat _emitterDurationLow;
		private CBool _useEmitterDurationRange;

		[Ordinal(0)] 
		[RED("emitterDuration")] 
		public CFloat EmitterDuration
		{
			get => GetProperty(ref _emitterDuration);
			set => SetProperty(ref _emitterDuration, value);
		}

		[Ordinal(1)] 
		[RED("emitterDurationLow")] 
		public CFloat EmitterDurationLow
		{
			get => GetProperty(ref _emitterDurationLow);
			set => SetProperty(ref _emitterDurationLow, value);
		}

		[Ordinal(2)] 
		[RED("useEmitterDurationRange")] 
		public CBool UseEmitterDurationRange
		{
			get => GetProperty(ref _useEmitterDurationRange);
			set => SetProperty(ref _useEmitterDurationRange, value);
		}

		public EmitterDurationSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
