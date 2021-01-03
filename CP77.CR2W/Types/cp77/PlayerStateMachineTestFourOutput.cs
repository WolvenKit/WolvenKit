using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PlayerStateMachineTestFourOutput : IScriptable
	{
		[Ordinal(0)]  [RED("counter")] public CInt32 Counter { get; set; }

		public PlayerStateMachineTestFourOutput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
