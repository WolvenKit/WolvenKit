using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnRidAnimationContainerSRRefAnimContainer : CVariable
	{
		private scnRidAnimationSRRefId _animation;
		private scnRidAnimationContainerSRRefAnimContainerContext _context;

		[Ordinal(0)] 
		[RED("animation")] 
		public scnRidAnimationSRRefId Animation
		{
			get => GetProperty(ref _animation);
			set => SetProperty(ref _animation, value);
		}

		[Ordinal(1)] 
		[RED("context")] 
		public scnRidAnimationContainerSRRefAnimContainerContext Context
		{
			get => GetProperty(ref _context);
			set => SetProperty(ref _context, value);
		}

		public scnRidAnimationContainerSRRefAnimContainer(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
