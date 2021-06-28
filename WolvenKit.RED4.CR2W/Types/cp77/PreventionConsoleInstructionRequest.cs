using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PreventionConsoleInstructionRequest : gameScriptableSystemRequest
	{
		private CEnum<EPreventionSystemInstruction> _instruction;

		[Ordinal(0)] 
		[RED("instruction")] 
		public CEnum<EPreventionSystemInstruction> Instruction
		{
			get => GetProperty(ref _instruction);
			set => SetProperty(ref _instruction, value);
		}

		public PreventionConsoleInstructionRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
