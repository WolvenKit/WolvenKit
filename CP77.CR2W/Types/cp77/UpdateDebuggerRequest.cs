using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class UpdateDebuggerRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("callstack")] public CName Callstack { get; set; }
		[Ordinal(1)]  [RED("inputAttached")] public CBool InputAttached { get; set; }
		[Ordinal(2)]  [RED("instruction")] public CEnum<EReprimandInstructions> Instruction { get; set; }
		[Ordinal(3)]  [RED("instructionAttached")] public CBool InstructionAttached { get; set; }
		[Ordinal(4)]  [RED("recentInput")] public CHandle<SecuritySystemInput> RecentInput { get; set; }
		[Ordinal(5)]  [RED("system")] public CHandle<SecuritySystemControllerPS> System { get; set; }
		[Ordinal(6)]  [RED("time")] public CFloat Time { get; set; }

		public UpdateDebuggerRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
