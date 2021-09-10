using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PreventionConsoleInstructionRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("instruction")] 
		public CEnum<EPreventionSystemInstruction> Instruction
		{
			get => GetPropertyValue<CEnum<EPreventionSystemInstruction>>();
			set => SetPropertyValue<CEnum<EPreventionSystemInstruction>>(value);
		}
	}
}
