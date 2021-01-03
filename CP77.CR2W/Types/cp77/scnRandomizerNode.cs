using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnRandomizerNode : scnSceneGraphNode
	{
		[Ordinal(0)]  [RED("mode")] public CEnum<scnRandomizerMode> Mode { get; set; }
		[Ordinal(1)]  [RED("numOutSockets")] public CUInt32 NumOutSockets { get; set; }
		[Ordinal(2)]  [RED("weights")] public [32]Uint8 Weights { get; set; }

		public scnRandomizerNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
