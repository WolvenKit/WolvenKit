using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnRidAnimationContainerSRRef : CVariable
	{
		private CArray<scnRidAnimationContainerSRRefAnimContainer> _animations;

		[Ordinal(0)] 
		[RED("animations")] 
		public CArray<scnRidAnimationContainerSRRefAnimContainer> Animations
		{
			get
			{
				if (_animations == null)
				{
					_animations = (CArray<scnRidAnimationContainerSRRefAnimContainer>) CR2WTypeManager.Create("array:scnRidAnimationContainerSRRefAnimContainer", "animations", cr2w, this);
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

		public scnRidAnimationContainerSRRef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
