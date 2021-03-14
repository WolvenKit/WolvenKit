using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimationElement : CVariable
	{
		private CName _animation;
		private inkanimPlaybackOptions _animOptions;

		[Ordinal(0)] 
		[RED("animation")] 
		public CName Animation
		{
			get
			{
				if (_animation == null)
				{
					_animation = (CName) CR2WTypeManager.Create("CName", "animation", cr2w, this);
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
		[RED("animOptions")] 
		public inkanimPlaybackOptions AnimOptions
		{
			get
			{
				if (_animOptions == null)
				{
					_animOptions = (inkanimPlaybackOptions) CR2WTypeManager.Create("inkanimPlaybackOptions", "animOptions", cr2w, this);
				}
				return _animOptions;
			}
			set
			{
				if (_animOptions == value)
				{
					return;
				}
				_animOptions = value;
				PropertySet(this);
			}
		}

		public AnimationElement(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
