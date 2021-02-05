using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_NPCExploration : animAnimFeature
	{
		[Ordinal(0)]  [RED("explorationType")] public CInt32 ExplorationType { get; set; }
		[Ordinal(1)]  [RED("state")] public CInt32 State { get; set; }
		[Ordinal(2)]  [RED("movementType")] public CInt32 MovementType { get; set; }
		[Ordinal(3)]  [RED("isEvenLoop")] public CBool IsEvenLoop { get; set; }

		public animAnimFeature_NPCExploration(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
