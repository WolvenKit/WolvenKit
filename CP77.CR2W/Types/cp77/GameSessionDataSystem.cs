using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GameSessionDataSystem : gameScriptableSystem
	{
		[Ordinal(0)] [RED("gameSessionDataModules")] public CArray<CHandle<GameSessionDataModule>> GameSessionDataModules { get; set; }

		public GameSessionDataSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
