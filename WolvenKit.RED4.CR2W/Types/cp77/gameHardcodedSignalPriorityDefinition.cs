using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameHardcodedSignalPriorityDefinition : gameSignalPriorityDefinition
	{
		[Ordinal(1)] [RED("signals")] public CArray<CName> Signals { get; set; }

		public gameHardcodedSignalPriorityDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
