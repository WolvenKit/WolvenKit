using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioBreathingStateMetadata : audioAudioMetadata
	{
		private CName _inhaleSound;
		private CName _exhaleSound;
		private CFloat _paramChangeSpeed;
		private CFloat _targetBpm;
		private CFloat _targetTimeDistortion;
		private CFloat _stateMinimalTime;
		private CFloat _exhaustionChangeSpeed;
		private CFloat _targetExhaustion;
		private CEnum<audiobreathingLoopBehavior> _loopBehavior;
		private CBool _startStateFromBreath;

		[Ordinal(1)] 
		[RED("inhaleSound")] 
		public CName InhaleSound
		{
			get => GetProperty(ref _inhaleSound);
			set => SetProperty(ref _inhaleSound, value);
		}

		[Ordinal(2)] 
		[RED("exhaleSound")] 
		public CName ExhaleSound
		{
			get => GetProperty(ref _exhaleSound);
			set => SetProperty(ref _exhaleSound, value);
		}

		[Ordinal(3)] 
		[RED("paramChangeSpeed")] 
		public CFloat ParamChangeSpeed
		{
			get => GetProperty(ref _paramChangeSpeed);
			set => SetProperty(ref _paramChangeSpeed, value);
		}

		[Ordinal(4)] 
		[RED("targetBpm")] 
		public CFloat TargetBpm
		{
			get => GetProperty(ref _targetBpm);
			set => SetProperty(ref _targetBpm, value);
		}

		[Ordinal(5)] 
		[RED("targetTimeDistortion")] 
		public CFloat TargetTimeDistortion
		{
			get => GetProperty(ref _targetTimeDistortion);
			set => SetProperty(ref _targetTimeDistortion, value);
		}

		[Ordinal(6)] 
		[RED("stateMinimalTime")] 
		public CFloat StateMinimalTime
		{
			get => GetProperty(ref _stateMinimalTime);
			set => SetProperty(ref _stateMinimalTime, value);
		}

		[Ordinal(7)] 
		[RED("exhaustionChangeSpeed")] 
		public CFloat ExhaustionChangeSpeed
		{
			get => GetProperty(ref _exhaustionChangeSpeed);
			set => SetProperty(ref _exhaustionChangeSpeed, value);
		}

		[Ordinal(8)] 
		[RED("targetExhaustion")] 
		public CFloat TargetExhaustion
		{
			get => GetProperty(ref _targetExhaustion);
			set => SetProperty(ref _targetExhaustion, value);
		}

		[Ordinal(9)] 
		[RED("loopBehavior")] 
		public CEnum<audiobreathingLoopBehavior> LoopBehavior
		{
			get => GetProperty(ref _loopBehavior);
			set => SetProperty(ref _loopBehavior, value);
		}

		[Ordinal(10)] 
		[RED("startStateFromBreath")] 
		public CBool StartStateFromBreath
		{
			get => GetProperty(ref _startStateFromBreath);
			set => SetProperty(ref _startStateFromBreath, value);
		}

		public audioBreathingStateMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
