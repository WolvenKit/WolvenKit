using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class NetworkMinigameData : CVariable
	{
		[Ordinal(0)] [RED("gridData")] public CArray<CellData> GridData { get; set; }
		[Ordinal(1)] [RED("playerBufferSize")] public CInt32 PlayerBufferSize { get; set; }
		[Ordinal(2)] [RED("basicAccess")] public ProgramData BasicAccess { get; set; }
		[Ordinal(3)] [RED("playerPrograms")] public CArray<ProgramData> PlayerPrograms { get; set; }
		[Ordinal(4)] [RED("enemyBufferSize")] public CInt32 EnemyBufferSize { get; set; }
		[Ordinal(5)] [RED("enemyLockNetwork")] public ProgramData EnemyLockNetwork { get; set; }
		[Ordinal(6)] [RED("enemyPrograms")] public CArray<ProgramData> EnemyPrograms { get; set; }

		public NetworkMinigameData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
