using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_CoverState : animAnimFeature
	{
		private CBool _inCover;
		private CBool _debugVar;

		[Ordinal(0)] 
		[RED("inCover")] 
		public CBool InCover
		{
			get => GetProperty(ref _inCover);
			set => SetProperty(ref _inCover, value);
		}

		[Ordinal(1)] 
		[RED("debugVar")] 
		public CBool DebugVar
		{
			get => GetProperty(ref _debugVar);
			set => SetProperty(ref _debugVar, value);
		}

		public AnimFeature_CoverState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
