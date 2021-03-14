using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameRootTransformAnimatorComponent : entIMoverComponent
	{
		private CArray<gameTransformAnimationDefinition> _animations;

		[Ordinal(3)] 
		[RED("animations")] 
		public CArray<gameTransformAnimationDefinition> Animations
		{
			get
			{
				if (_animations == null)
				{
					_animations = (CArray<gameTransformAnimationDefinition>) CR2WTypeManager.Create("array:gameTransformAnimationDefinition", "animations", cr2w, this);
				}
				return _animations;
			}
			set
			{
				if (_animations == value)
				{
					return;
				}
				_animations = value;
				PropertySet(this);
			}
		}

		public gameRootTransformAnimatorComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
