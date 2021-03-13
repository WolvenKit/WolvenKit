using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questEntityManagerManageBinkComponent_NodeTypeParams : CVariable
	{
		[Ordinal(0)] [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
		[Ordinal(1)] [RED("videoPath")] public CString VideoPath { get; set; }
		[Ordinal(2)] [RED("action")] public CEnum<gameBinkVideoAction> Action { get; set; }

		public questEntityManagerManageBinkComponent_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
