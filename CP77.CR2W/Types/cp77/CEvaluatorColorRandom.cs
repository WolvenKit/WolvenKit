using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CEvaluatorColorRandom : IEvaluatorColor
	{
		[Ordinal(0)]  [RED("max")] public CColor Max { get; set; }
		[Ordinal(1)]  [RED("min")] public CColor Min { get; set; }
		[Ordinal(2)]  [RED("randomPerChannel")] public CBool RandomPerChannel { get; set; }

		public CEvaluatorColorRandom(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
