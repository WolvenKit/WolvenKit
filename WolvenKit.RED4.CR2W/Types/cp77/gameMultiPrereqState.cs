using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMultiPrereqState : gamePrereqState
	{
		[Ordinal(0)] [RED("nestedStates")] public CArray<CHandle<gamePrereqState>> NestedStates { get; set; }

		public gameMultiPrereqState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
