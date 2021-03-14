using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FastTravelConsoleInstructionRequest : gameScriptableSystemRequest
	{
		private CEnum<EFastTravelSystemInstruction> _instruction;
		private CFloat _magicFloat;

		[Ordinal(0)] 
		[RED("instruction")] 
		public CEnum<EFastTravelSystemInstruction> Instruction
		{
			get
			{
				if (_instruction == null)
				{
					_instruction = (CEnum<EFastTravelSystemInstruction>) CR2WTypeManager.Create("EFastTravelSystemInstruction", "instruction", cr2w, this);
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

		[Ordinal(1)] 
		[RED("magicFloat")] 
		public CFloat MagicFloat
		{
			get
			{
				if (_magicFloat == null)
				{
					_magicFloat = (CFloat) CR2WTypeManager.Create("Float", "magicFloat", cr2w, this);
				}
				return _magicFloat;
			}
			set
			{
				if (_magicFloat == value)
				{
					return;
				}
				_magicFloat = value;
				PropertySet(this);
			}
		}

		public FastTravelConsoleInstructionRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
