using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entVoicesetInputToBlock : CVariable
	{
		[Ordinal(0)] [RED("input")] public CName Input { get; set; }
		[Ordinal(1)] [RED("blockSpecificVariation")] public CBool BlockSpecificVariation { get; set; }
		[Ordinal(2)] [RED("variationNumber")] public CUInt32 VariationNumber { get; set; }

		public entVoicesetInputToBlock(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
