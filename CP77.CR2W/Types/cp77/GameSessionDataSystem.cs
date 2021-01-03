using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class GameSessionDataSystem : gameScriptableSystem
	{
		[Ordinal(0)]  [RED("gameSessionDataModules")] public CArray<CHandle<GameSessionDataModule>> GameSessionDataModules { get; set; }

		public GameSessionDataSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
