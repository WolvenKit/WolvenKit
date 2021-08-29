using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_CoverState : animAnimFeature
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
	}
}
