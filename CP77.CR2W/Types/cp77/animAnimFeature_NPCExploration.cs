using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_NPCExploration : animAnimFeature
	{
		[Ordinal(0)]  [RED("explorationType")] public CInt32 ExplorationType { get; set; }
		[Ordinal(1)]  [RED("isEvenLoop")] public CBool IsEvenLoop { get; set; }
		[Ordinal(2)]  [RED("movementType")] public CInt32 MovementType { get; set; }
		[Ordinal(3)]  [RED("state")] public CInt32 State { get; set; }

		public animAnimFeature_NPCExploration(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
