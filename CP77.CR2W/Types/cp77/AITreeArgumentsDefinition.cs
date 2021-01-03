using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AITreeArgumentsDefinition : CVariable
	{
		[Ordinal(0)]  [RED("args")] public CArray<CHandle<AIArgumentDefinition>> Args { get; set; }

		public AITreeArgumentsDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
