using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SlidingLadderControllerPS : BaseAnimatedDeviceControllerPS
	{
		private CBool _isShootable;
		private CFloat _animationTime;

		[Ordinal(108)] 
		[RED("isShootable")] 
		public CBool IsShootable
		{
			get => GetProperty(ref _isShootable);
			set => SetProperty(ref _isShootable, value);
		}

		[Ordinal(109)] 
		[RED("animationTime")] 
		public CFloat AnimationTime
		{
			get => GetProperty(ref _animationTime);
			set => SetProperty(ref _animationTime, value);
		}

		public SlidingLadderControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
