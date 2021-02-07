using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questCheckpointNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(0)]  [RED("debugString")] public CString DebugString { get; set; }
		[Ordinal(1)]  [RED("saveLock")] public CBool SaveLock { get; set; }
		[Ordinal(2)]  [RED("ignoreSaveLocks")] public CBool IgnoreSaveLocks { get; set; }
		[Ordinal(3)]  [RED("pointOfNoReturn")] public CBool PointOfNoReturn { get; set; }
		[Ordinal(4)]  [RED("endGameSave")] public CBool EndGameSave { get; set; }
		[Ordinal(5)]  [RED("additionalEndGameRewardsTweak")] public CArray<TweakDBID> AdditionalEndGameRewardsTweak { get; set; }

		public questCheckpointNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
