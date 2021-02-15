using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioAudioSceneVariableWriteActionData : CVariable
	{
		[Ordinal(0)] [RED("name")] public CName Name { get; set; }
		[Ordinal(1)] [RED("operation")] public CEnum<audioNumberOperation> Operation { get; set; }
		[Ordinal(2)] [RED("value")] public CInt32 Value { get; set; }

		public audioAudioSceneVariableWriteActionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
