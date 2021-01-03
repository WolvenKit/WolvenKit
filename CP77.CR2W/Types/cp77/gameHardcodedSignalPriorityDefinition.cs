using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameHardcodedSignalPriorityDefinition : gameSignalPriorityDefinition
	{
		[Ordinal(0)]  [RED("signals")] public CArray<CName> Signals { get; set; }

		public gameHardcodedSignalPriorityDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
