using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_LocoState : animAnimNode_State
	{
		[Ordinal(0)]  [RED("locoTag")] public CName LocoTag { get; set; }
		[Ordinal(1)]  [RED("type")] public CEnum<animLocoStateType> Type { get; set; }

		public animAnimNode_LocoState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
