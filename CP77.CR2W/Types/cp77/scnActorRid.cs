using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnActorRid : CVariable
	{
		[Ordinal(0)]  [RED("tag")] public scnRidTag Tag { get; set; }
		[Ordinal(1)]  [RED("animations")] public CArray<scnAnimationRid> Animations { get; set; }
		[Ordinal(2)]  [RED("facialAnimations")] public CArray<scnAnimationRid> FacialAnimations { get; set; }
		[Ordinal(3)]  [RED("cyberwareAnimations")] public CArray<scnAnimationRid> CyberwareAnimations { get; set; }

		public scnActorRid(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
