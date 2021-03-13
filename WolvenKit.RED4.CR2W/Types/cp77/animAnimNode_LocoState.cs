using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_LocoState : animAnimNode_State
	{
		[Ordinal(17)] [RED("type")] public CEnum<animLocoStateType> Type { get; set; }
		[Ordinal(18)] [RED("locoTag")] public CName LocoTag { get; set; }

		public animAnimNode_LocoState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
