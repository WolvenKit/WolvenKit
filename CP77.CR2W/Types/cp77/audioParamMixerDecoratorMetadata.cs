using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioParamMixerDecoratorMetadata : audioEmitterMetadata
	{
		[Ordinal(1)] [RED("inParams")] public CArray<audioMixParamDescription> InParams { get; set; }
		[Ordinal(2)] [RED("outputName")] public CName OutputName { get; set; }
		[Ordinal(3)] [RED("operation")] public CEnum<audioMixParamsAction> Operation { get; set; }
		[Ordinal(4)] [RED("globalOutput")] public CBool GlobalOutput { get; set; }

		public audioParamMixerDecoratorMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
