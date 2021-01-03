using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class NetworkMinigameData : CVariable
	{
		[Ordinal(0)]  [RED("basicAccess")] public ProgramData BasicAccess { get; set; }
		[Ordinal(1)]  [RED("enemyBufferSize")] public CInt32 EnemyBufferSize { get; set; }
		[Ordinal(2)]  [RED("enemyLockNetwork")] public ProgramData EnemyLockNetwork { get; set; }
		[Ordinal(3)]  [RED("enemyPrograms")] public CArray<ProgramData> EnemyPrograms { get; set; }
		[Ordinal(4)]  [RED("gridData")] public CArray<CellData> GridData { get; set; }
		[Ordinal(5)]  [RED("playerBufferSize")] public CInt32 PlayerBufferSize { get; set; }
		[Ordinal(6)]  [RED("playerPrograms")] public CArray<ProgramData> PlayerPrograms { get; set; }

		public NetworkMinigameData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
