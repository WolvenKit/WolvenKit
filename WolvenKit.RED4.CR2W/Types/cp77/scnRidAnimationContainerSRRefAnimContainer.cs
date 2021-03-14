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
			get
			{
				if (_animation == null)
				{
					_animation = (scnRidAnimationSRRefId) CR2WTypeManager.Create("scnRidAnimationSRRefId", "animation", cr2w, this);
				}
				return _animation;
			}
			set
			{
				if (_animation == value)
				{
					return;
				}
				_animation = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("context")] 
		public scnRidAnimationContainerSRRefAnimContainerContext Context
		{
			get
			{
				if (_context == null)
				{
					_context = (scnRidAnimationContainerSRRefAnimContainerContext) CR2WTypeManager.Create("scnRidAnimationContainerSRRefAnimContainerContext", "context", cr2w, this);
				}
				return _context;
			}
			set
			{
				if (_context == value)
				{
					return;
				}
				_context = value;
				PropertySet(this);
			}
		}

		public scnRidAnimationContainerSRRefAnimContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
