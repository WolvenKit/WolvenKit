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
			get
			{
				if (_system == null)
				{
					_system = (CHandle<SecuritySystemControllerPS>) CR2WTypeManager.Create("handle:SecuritySystemControllerPS", "system", cr2w, this);
				}
				return _system;
			}
			set
			{
				if (_system == value)
				{
					return;
				}
				_system = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("time")] 
		public CFloat Time
		{
			get
			{
				if (_time == null)
				{
					_time = (CFloat) CR2WTypeManager.Create("Float", "time", cr2w, this);
				}
				return _time;
			}
			set
			{
				if (_time == value)
				{
					return;
				}
				_time = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("instructionAttached")] 
		public CBool InstructionAttached
		{
			get
			{
				if (_instructionAttached == null)
				{
					_instructionAttached = (CBool) CR2WTypeManager.Create("Bool", "instructionAttached", cr2w, this);
				}
				return _instructionAttached;
			}
			set
			{
				if (_instructionAttached == value)
				{
					return;
				}
				_instructionAttached = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("inputAttached")] 
		public CBool InputAttached
		{
			get
			{
				if (_inputAttached == null)
				{
					_inputAttached = (CBool) CR2WTypeManager.Create("Bool", "inputAttached", cr2w, this);
				}
				return _inputAttached;
			}
			set
			{
				if (_inputAttached == value)
				{
					return;
				}
				_inputAttached = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("callstack")] 
		public CName Callstack
		{
			get
			{
				if (_callstack == null)
				{
					_callstack = (CName) CR2WTypeManager.Create("CName", "callstack", cr2w, this);
				}
				return _callstack;
			}
			set
			{
				if (_callstack == value)
				{
					return;
				}
				_callstack = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("instruction")] 
		public CEnum<EReprimandInstructions> Instruction
		{
			get
			{
				if (_instruction == null)
				{
					_instruction = (CEnum<EReprimandInstructions>) CR2WTypeManager.Create("EReprimandInstructions", "instruction", cr2w, this);
				}
				return _instruction;
			}
			set
			{
				if (_instruction == value)
				{
					return;
				}
				_instruction = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("recentInput")] 
		public CHandle<SecuritySystemInput> RecentInput
		{
			get
			{
				if (_recentInput == null)
				{
					_recentInput = (CHandle<SecuritySystemInput>) CR2WTypeManager.Create("handle:SecuritySystemInput", "recentInput", cr2w, this);
				}
				return _recentInput;
			}
			set
			{
				if (_recentInput == value)
				{
					return;
				}
				_recentInput = value;
				PropertySet(this);
			}
		}

		public UpdateDebuggerRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
