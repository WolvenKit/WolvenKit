using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questRandomizerNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(0)]  [RED("mode")] public CEnum<questRandomizerMode> Mode { get; set; }
		[Ordinal(1)]  [RED("outputWeights")] public CArray<CUInt8> OutputWeights { get; set; }

		public questRandomizerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
