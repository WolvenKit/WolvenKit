using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioParamMixerDecoratorMetadata : audioEmitterMetadata
	{
		[Ordinal(0)]  [RED("globalOutput")] public CBool GlobalOutput { get; set; }
		[Ordinal(1)]  [RED("inParams")] public CArray<audioMixParamDescription> InParams { get; set; }
		[Ordinal(2)]  [RED("operation")] public CEnum<audioMixParamsAction> Operation { get; set; }
		[Ordinal(3)]  [RED("outputName")] public CName OutputName { get; set; }

		public audioParamMixerDecoratorMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
