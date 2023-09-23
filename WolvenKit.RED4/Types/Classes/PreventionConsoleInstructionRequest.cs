using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PreventionConsoleInstructionRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("instruction")] 
		public CEnum<EPreventionSystemInstruction> Instruction
		{
			get => GetPropertyValue<CEnum<EPreventionSystemInstruction>>();
			set => SetPropertyValue<CEnum<EPreventionSystemInstruction>>(value);
		}

		[Ordinal(1)] 
		[RED("heatStage")] 
		public CEnum<EPreventionHeatStage> HeatStage
		{
			get => GetPropertyValue<CEnum<EPreventionHeatStage>>();
			set => SetPropertyValue<CEnum<EPreventionHeatStage>>(value);
		}

		public PreventionConsoleInstructionRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
