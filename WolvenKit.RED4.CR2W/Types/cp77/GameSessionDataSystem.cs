using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameSessionDataSystem : gameScriptableSystem
	{
		[Ordinal(0)] [RED("gameSessionDataModules")] public CArray<CHandle<GameSessionDataModule>> GameSessionDataModules { get; set; }

		public GameSessionDataSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
