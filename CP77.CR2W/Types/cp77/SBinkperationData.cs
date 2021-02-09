using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SBinkperationData : CVariable
	{
		[Ordinal(0)]  [RED("componentName")] public CName ComponentName { get; set; }
		[Ordinal(1)]  [RED("binkPath")] public redResourceReferenceScriptToken BinkPath { get; set; }
		[Ordinal(2)]  [RED("loop")] public CBool Loop { get; set; }
		[Ordinal(3)]  [RED("operationType")] public CEnum<EBinkOperationType> OperationType { get; set; }

		public SBinkperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
