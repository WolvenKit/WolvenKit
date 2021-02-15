using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ScannerNPCHeaderGameController : BaseChunkGameController
	{
		[Ordinal(5)] [RED("nameText")] public inkTextWidgetReference NameText { get; set; }
		[Ordinal(6)] [RED("skullIndicator")] public inkWidgetReference SkullIndicator { get; set; }
		[Ordinal(7)] [RED("archetypeIcon")] public inkImageWidgetReference ArchetypeIcon { get; set; }
		[Ordinal(8)] [RED("levelCallbackID")] public CUInt32 LevelCallbackID { get; set; }
		[Ordinal(9)] [RED("nameCallbackID")] public CUInt32 NameCallbackID { get; set; }
		[Ordinal(10)] [RED("attitudeCallbackID")] public CUInt32 AttitudeCallbackID { get; set; }
		[Ordinal(11)] [RED("archtypeCallbackID")] public CUInt32 ArchtypeCallbackID { get; set; }
		[Ordinal(12)] [RED("isValidName")] public CBool IsValidName { get; set; }
		[Ordinal(13)] [RED("isValidRarity")] public CBool IsValidRarity { get; set; }
		[Ordinal(14)] [RED("isValidArchetype")] public CBool IsValidArchetype { get; set; }

		public ScannerNPCHeaderGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
