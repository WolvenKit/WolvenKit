using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UpdateDebuggerRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("system")] 
		public CHandle<SecuritySystemControllerPS> System
		{
			get => GetPropertyValue<CHandle<SecuritySystemControllerPS>>();
			set => SetPropertyValue<CHandle<SecuritySystemControllerPS>>(value);
		}

		[Ordinal(1)] 
		[RED("time")] 
		public CFloat Time
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("instructionAttached")] 
		public CBool InstructionAttached
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("inputAttached")] 
		public CBool InputAttached
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("callstack")] 
		public CName Callstack
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("instruction")] 
		public CEnum<EReprimandInstructions> Instruction
		{
			get => GetPropertyValue<CEnum<EReprimandInstructions>>();
			set => SetPropertyValue<CEnum<EReprimandInstructions>>(value);
		}

		[Ordinal(6)] 
		[RED("recentInput")] 
		public CHandle<SecuritySystemInput> RecentInput
		{
			get => GetPropertyValue<CHandle<SecuritySystemInput>>();
			set => SetPropertyValue<CHandle<SecuritySystemInput>>(value);
		}

		public UpdateDebuggerRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
