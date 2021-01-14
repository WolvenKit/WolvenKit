using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DebuggerProperties : CVariable
	{
		[Ordinal(0)]  [RED("debugName")] public CName DebugName { get; set; }
		[Ordinal(1)]  [RED("exclusiveMode")] public CBool ExclusiveMode { get; set; }
		[Ordinal(2)]  [RED("factActivated")] public CName FactActivated { get; set; }
		[Ordinal(3)]  [RED("layerIDs")] public CArray<CUInt32> LayerIDs { get; set; }

		public DebuggerProperties(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
