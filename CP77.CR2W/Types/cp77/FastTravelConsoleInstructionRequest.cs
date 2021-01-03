using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class FastTravelConsoleInstructionRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("instruction")] public CEnum<EFastTravelSystemInstruction> Instruction { get; set; }
		[Ordinal(1)]  [RED("magicFloat")] public CFloat MagicFloat { get; set; }

		public FastTravelConsoleInstructionRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
