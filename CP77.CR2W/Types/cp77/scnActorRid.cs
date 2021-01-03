using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnActorRid : CVariable
	{
		[Ordinal(0)]  [RED("animations")] public CArray<scnAnimationRid> Animations { get; set; }
		[Ordinal(1)]  [RED("cyberwareAnimations")] public CArray<scnAnimationRid> CyberwareAnimations { get; set; }
		[Ordinal(2)]  [RED("facialAnimations")] public CArray<scnAnimationRid> FacialAnimations { get; set; }
		[Ordinal(3)]  [RED("tag")] public scnRidTag Tag { get; set; }

		public scnActorRid(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
