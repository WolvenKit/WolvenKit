using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckStanceState : AINPCStanceStateCheck
	{
		[Ordinal(0)] [RED("state")] public CEnum<gamedataNPCStanceState> State { get; set; }

		public CheckStanceState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
