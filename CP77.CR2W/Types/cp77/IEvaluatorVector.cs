using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class IEvaluatorVector : IEvaluator
	{
		[Ordinal(0)] [RED("freeAxes")] public CEnum<EFreeVectorAxes> FreeAxes { get; set; }
		[Ordinal(1)] [RED("spill")] public CBool Spill { get; set; }

		public IEvaluatorVector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
