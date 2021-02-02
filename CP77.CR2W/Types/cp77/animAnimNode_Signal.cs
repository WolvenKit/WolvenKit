using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_Signal : animAnimNode_FloatValue
	{
		[Ordinal(0)]  [RED("blendIn")] public CFloat BlendIn { get; set; }
		[Ordinal(1)]  [RED("blendOut")] public CFloat BlendOut { get; set; }
		[Ordinal(2)]  [RED("startEvent")] public CName StartEvent { get; set; }
		[Ordinal(3)]  [RED("endEvent")] public CName EndEvent { get; set; }
		[Ordinal(4)]  [RED("defaultState")] public CBool DefaultState { get; set; }
		[Ordinal(5)]  [RED("cooldown")] public CFloat Cooldown { get; set; }

		public animAnimNode_Signal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
