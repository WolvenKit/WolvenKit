using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameFootstepComponent : entIComponent
	{
		[Ordinal(3)] [RED("tweakDBID")] public TweakDBID TweakDBID { get; set; }
		[Ordinal(4)] [RED("leftFootSlot")] public CName LeftFootSlot { get; set; }
		[Ordinal(5)] [RED("rightFootSlot")] public CName RightFootSlot { get; set; }

		public gameFootstepComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
