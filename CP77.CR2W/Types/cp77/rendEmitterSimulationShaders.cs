using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class rendEmitterSimulationShaders : CVariable
	{
		[Ordinal(0)] [RED("simCS", 2)] public CArrayFixedSize<DataBuffer> SimCS { get; set; }

		public rendEmitterSimulationShaders(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
