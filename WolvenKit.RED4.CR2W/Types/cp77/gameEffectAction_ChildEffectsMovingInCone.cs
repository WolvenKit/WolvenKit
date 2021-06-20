using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectAction_ChildEffectsMovingInCone : gameEffectPostAction
	{
		private CUInt32 _effectsCount;
		private CName _effectTagInThisFile;
		private CFloat _coneAngle;
		private CFloat _minEffectDuration;
		private CFloat _maxEffectDuration;
		private CBool _twoDimensional;
		private CBool _smoothInterpolations;

		[Ordinal(0)] 
		[RED("effectsCount")] 
		public CUInt32 EffectsCount
		{
			get => GetProperty(ref _effectsCount);
			set => SetProperty(ref _effectsCount, value);
		}

		[Ordinal(1)] 
		[RED("effectTagInThisFile")] 
		public CName EffectTagInThisFile
		{
			get => GetProperty(ref _effectTagInThisFile);
			set => SetProperty(ref _effectTagInThisFile, value);
		}

		[Ordinal(2)] 
		[RED("coneAngle")] 
		public CFloat ConeAngle
		{
			get => GetProperty(ref _coneAngle);
			set => SetProperty(ref _coneAngle, value);
		}

		[Ordinal(3)] 
		[RED("minEffectDuration")] 
		public CFloat MinEffectDuration
		{
			get => GetProperty(ref _minEffectDuration);
			set => SetProperty(ref _minEffectDuration, value);
		}

		[Ordinal(4)] 
		[RED("maxEffectDuration")] 
		public CFloat MaxEffectDuration
		{
			get => GetProperty(ref _maxEffectDuration);
			set => SetProperty(ref _maxEffectDuration, value);
		}

		[Ordinal(5)] 
		[RED("twoDimensional")] 
		public CBool TwoDimensional
		{
			get => GetProperty(ref _twoDimensional);
			set => SetProperty(ref _twoDimensional, value);
		}

		[Ordinal(6)] 
		[RED("smoothInterpolations")] 
		public CBool SmoothInterpolations
		{
			get => GetProperty(ref _smoothInterpolations);
			set => SetProperty(ref _smoothInterpolations, value);
		}

		public gameEffectAction_ChildEffectsMovingInCone(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
