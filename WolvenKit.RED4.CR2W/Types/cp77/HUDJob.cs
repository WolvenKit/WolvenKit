using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HUDJob : CVariable
	{
		private wCHandle<gameHudActor> _actor;
		private CHandle<HUDInstruction> _instruction;

		[Ordinal(0)] 
		[RED("actor")] 
		public wCHandle<gameHudActor> Actor
		{
			get
			{
				if (_actor == null)
				{
					_actor = (wCHandle<gameHudActor>) CR2WTypeManager.Create("whandle:gameHudActor", "actor", cr2w, this);
				}
				return _actor;
			}
			set
			{
				if (_actor == value)
				{
					return;
				}
				_actor = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("instruction")] 
		public CHandle<HUDInstruction> Instruction
		{
			get
			{
				if (_instruction == null)
				{
					_instruction = (CHandle<HUDInstruction>) CR2WTypeManager.Create("handle:HUDInstruction", "instruction", cr2w, this);
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

		public HUDJob(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
