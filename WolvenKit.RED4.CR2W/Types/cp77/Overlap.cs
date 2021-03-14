using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Overlap : CVariable
	{
		private CInt32 _instructionNumber;
		private CInt32 _otherInstruction;
		private CBool _atStart;
		private CInt32 _rarity;

		[Ordinal(0)] 
		[RED("instructionNumber")] 
		public CInt32 InstructionNumber
		{
			get
			{
				if (_instructionNumber == null)
				{
					_instructionNumber = (CInt32) CR2WTypeManager.Create("Int32", "instructionNumber", cr2w, this);
				}
				return _instructionNumber;
			}
			set
			{
				if (_instructionNumber == value)
				{
					return;
				}
				_instructionNumber = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("otherInstruction")] 
		public CInt32 OtherInstruction
		{
			get
			{
				if (_otherInstruction == null)
				{
					_otherInstruction = (CInt32) CR2WTypeManager.Create("Int32", "otherInstruction", cr2w, this);
				}
				return _otherInstruction;
			}
			set
			{
				if (_otherInstruction == value)
				{
					return;
				}
				_otherInstruction = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("atStart")] 
		public CBool AtStart
		{
			get
			{
				if (_atStart == null)
				{
					_atStart = (CBool) CR2WTypeManager.Create("Bool", "atStart", cr2w, this);
				}
				return _atStart;
			}
			set
			{
				if (_atStart == value)
				{
					return;
				}
				_atStart = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("rarity")] 
		public CInt32 Rarity
		{
			get
			{
				if (_rarity == null)
				{
					_rarity = (CInt32) CR2WTypeManager.Create("Int32", "rarity", cr2w, this);
				}
				return _rarity;
			}
			set
			{
				if (_rarity == value)
				{
					return;
				}
				_rarity = value;
				PropertySet(this);
			}
		}

		public Overlap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
