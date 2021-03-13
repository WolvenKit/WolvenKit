using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameRootTransformAnimatorComponent : entIMoverComponent
	{
		[Ordinal(3)] [RED("animations")] public CArray<gameTransformAnimationDefinition> Animations { get; set; }

		public gameRootTransformAnimatorComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
