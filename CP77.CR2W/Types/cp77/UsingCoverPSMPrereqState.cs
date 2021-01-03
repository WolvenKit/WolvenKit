using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class UsingCoverPSMPrereqState : PlayerStateMachinePrereqState
	{
		[Ordinal(0)]  [RED("bValue")] public CBool BValue { get; set; }

		public UsingCoverPSMPrereqState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
