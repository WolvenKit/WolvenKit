using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UsingCoverPSMPrereqState : PlayerStateMachinePrereqState
	{
		[Ordinal(3)] [RED("bValue")] public CBool BValue { get; set; }

		public UsingCoverPSMPrereqState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
