using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCheckpointNodeDefinition : questSignalStoppingNodeDefinition
	{
		[Ordinal(2)] [RED("saveLock")] public CBool SaveLock { get; set; }
		[Ordinal(3)] [RED("ignoreSaveLocks")] public CBool IgnoreSaveLocks { get; set; }
		[Ordinal(4)] [RED("pointOfNoReturn")] public CBool PointOfNoReturn { get; set; }
		[Ordinal(5)] [RED("endGameSave")] public CBool EndGameSave { get; set; }
		[Ordinal(6)] [RED("additionalEndGameRewardsTweak")] public CArray<TweakDBID> AdditionalEndGameRewardsTweak { get; set; }
		[Ordinal(7)] [RED("debugString")] public CString DebugString { get; set; }

		public questCheckpointNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
