using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questRandomizerNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(2)] [RED("mode")] public CEnum<questRandomizerMode> Mode { get; set; }
		[Ordinal(3)] [RED("outputWeights")] public CArray<CUInt8> OutputWeights { get; set; }

		public questRandomizerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
