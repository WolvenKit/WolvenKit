using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimatorComponent : entIPlacedComponent
	{
		[Ordinal(0)]  [RED("animations")] public CArray<gameTransformAnimationDefinition> Animations { get; set; }

		public gameTransformAnimatorComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
