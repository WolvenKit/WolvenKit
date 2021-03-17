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
			get => GetProperty(ref _actor);
			set => SetProperty(ref _actor, value);
		}

		[Ordinal(1)] 
		[RED("instruction")] 
		public CHandle<HUDInstruction> Instruction
		{
			get => GetProperty(ref _instruction);
			set => SetProperty(ref _instruction, value);
		}

		public HUDJob(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
