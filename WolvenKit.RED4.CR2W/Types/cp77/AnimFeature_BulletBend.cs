using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_BulletBend : animAnimFeature
	{
		private CFloat _animProgression;
		private CFloat _randomAdditive;
		private CBool _isResetting;

		[Ordinal(0)] 
		[RED("animProgression")] 
		public CFloat AnimProgression
		{
			get => GetProperty(ref _animProgression);
			set => SetProperty(ref _animProgression, value);
		}

		[Ordinal(1)] 
		[RED("randomAdditive")] 
		public CFloat RandomAdditive
		{
			get => GetProperty(ref _randomAdditive);
			set => SetProperty(ref _randomAdditive, value);
		}

		[Ordinal(2)] 
		[RED("isResetting")] 
		public CBool IsResetting
		{
			get => GetProperty(ref _isResetting);
			set => SetProperty(ref _isResetting, value);
		}

		public AnimFeature_BulletBend(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
