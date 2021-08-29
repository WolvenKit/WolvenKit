using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PreventionConsoleInstructionRequest : gameScriptableSystemRequest
	{
		private CEnum<EPreventionSystemInstruction> _instruction;

		[Ordinal(0)] 
		[RED("instruction")] 
		public CEnum<EPreventionSystemInstruction> Instruction
		{
			get => GetProperty(ref _instruction);
			set => SetProperty(ref _instruction, value);
		}
	}
}
