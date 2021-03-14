using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnRandomizerNode : scnSceneGraphNode
	{
		[Ordinal(3)] [RED("mode")] public CEnum<scnRandomizerMode> Mode { get; set; }
		[Ordinal(4)] [RED("numOutSockets")] public CUInt32 NumOutSockets { get; set; }
		[Ordinal(5)] [RED("weights", 32)] public CArrayFixedSize<CUInt8> Weights { get; set; }

		public scnRandomizerNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
