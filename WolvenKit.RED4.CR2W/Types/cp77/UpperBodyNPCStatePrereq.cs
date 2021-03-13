using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UpperBodyNPCStatePrereq : NPCStatePrereq
	{
		[Ordinal(3)] [RED("valueToListen")] public CEnum<gamedataNPCUpperBodyState> ValueToListen { get; set; }

		public UpperBodyNPCStatePrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
