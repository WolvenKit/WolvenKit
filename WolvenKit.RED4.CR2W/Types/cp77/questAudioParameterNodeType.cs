using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questAudioParameterNodeType : questIAudioNodeType
	{
		[Ordinal(0)] [RED("param")] public audioAudParameter Param { get; set; }
		[Ordinal(1)] [RED("isMusic")] public CBool IsMusic { get; set; }
		[Ordinal(2)] [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
		[Ordinal(3)] [RED("isPlayer")] public CBool IsPlayer { get; set; }

		public questAudioParameterNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
