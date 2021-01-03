using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameMultiPrereqState : gamePrereqState
	{
		[Ordinal(0)]  [RED("nestedStates")] public CArray<CHandle<gamePrereqState>> NestedStates { get; set; }

		public gameMultiPrereqState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
