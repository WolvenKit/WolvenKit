using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class EmitterGroupParams : CVariable
	{
		[Ordinal(0)] [RED("group")] public CEnum<EEmitterGroup> Group { get; set; }
		[Ordinal(1)] [RED("emissionScale")] public CFloat EmissionScale { get; set; }
		[Ordinal(2)] [RED("opacityScale")] public CFloat OpacityScale { get; set; }

		public EmitterGroupParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
