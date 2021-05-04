using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UpdateDebuggerRequest : gameScriptableSystemRequest
	{
		private CHandle<SecuritySystemControllerPS> _system;
		private CFloat _time;
		private CBool _instructionAttached;
		private CBool _inputAttached;
		private CName _callstack;
		private CEnum<EReprimandInstructions> _instruction;
		private CHandle<SecuritySystemInput> _recentInput;

		[Ordinal(0)] 
		[RED("system")] 
		public CHandle<SecuritySystemControllerPS> System
		{
			get => GetProperty(ref _system);
			set => SetProperty(ref _system, value);
		}

		[Ordinal(1)] 
		[RED("time")] 
		public CFloat Time
		{
			get => GetProperty(ref _time);
			set => SetProperty(ref _time, value);
		}

		[Ordinal(2)] 
		[RED("instructionAttached")] 
		public CBool InstructionAttached
		{
			get => GetProperty(ref _instructionAttached);
			set => SetProperty(ref _instructionAttached, value);
		}

		[Ordinal(3)] 
		[RED("inputAttached")] 
		public CBool InputAttached
		{
			get => GetProperty(ref _inputAttached);
			set => SetProperty(ref _inputAttached, value);
		}

		[Ordinal(4)] 
		[RED("callstack")] 
		public CName Callstack
		{
			get => GetProperty(ref _callstack);
			set => SetProperty(ref _callstack, value);
		}

		[Ordinal(5)] 
		[RED("instruction")] 
		public CEnum<EReprimandInstructions> Instruction
		{
			get => GetProperty(ref _instruction);
			set => SetProperty(ref _instruction, value);
		}

		[Ordinal(6)] 
		[RED("recentInput")] 
		public CHandle<SecuritySystemInput> RecentInput
		{
			get => GetProperty(ref _recentInput);
			set => SetProperty(ref _recentInput, value);
		}

		public UpdateDebuggerRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
