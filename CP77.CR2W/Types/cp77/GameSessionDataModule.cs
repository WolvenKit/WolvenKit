using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class GameSessionDataModule : IScriptable
	{
		[Ordinal(0)]  [RED("moduleType")] public CEnum<EGameSessionDataType> ModuleType { get; set; }

		public GameSessionDataModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
