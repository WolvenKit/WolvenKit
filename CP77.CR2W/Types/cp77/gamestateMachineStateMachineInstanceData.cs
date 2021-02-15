using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineStateMachineInstanceData : CVariable
	{
		[Ordinal(0)] [RED("referenceName")] public CName ReferenceName { get; set; }
		[Ordinal(1)] [RED("priority")] public CUInt32 Priority { get; set; }
		[Ordinal(2)] [RED("initData")] public CHandle<IScriptable> InitData { get; set; }

		public gamestateMachineStateMachineInstanceData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
