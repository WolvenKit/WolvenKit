using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIInterruptionSignal : CVariable
	{
		[Ordinal(0)]  [RED("importance")] public CEnum<AIEInterruptionImportance> Importance { get; set; }
		[Ordinal(1)]  [RED("signal")] public CName Signal { get; set; }

		public AIInterruptionSignal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
