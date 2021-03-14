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
			get
			{
				if (_instruction == null)
				{
					_instruction = (CEnum<EPreventionSystemInstruction>) CR2WTypeManager.Create("EPreventionSystemInstruction", "instruction", cr2w, this);
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

		public PreventionConsoleInstructionRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
