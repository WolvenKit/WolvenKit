using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class EvaluateVisionModeRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("mode")] public CEnum<gameVisionModeType> Mode { get; set; }

		public EvaluateVisionModeRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
