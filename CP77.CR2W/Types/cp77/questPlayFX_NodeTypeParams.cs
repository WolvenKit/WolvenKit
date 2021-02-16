using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questPlayFX_NodeTypeParams : CVariable
	{
		[Ordinal(0)] [RED("play")] public CBool Play { get; set; }
		[Ordinal(1)] [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
		[Ordinal(2)] [RED("isPlayer")] public CBool IsPlayer { get; set; }
		[Ordinal(3)] [RED("effectName")] public CName EffectName { get; set; }
		[Ordinal(4)] [RED("sequenceShift")] public CUInt32 SequenceShift { get; set; }

		public questPlayFX_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
