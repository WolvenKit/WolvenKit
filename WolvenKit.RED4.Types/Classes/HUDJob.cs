using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HUDJob : RedBaseClass
	{
		private CWeakHandle<gameHudActor> _actor;
		private CHandle<HUDInstruction> _instruction;

		[Ordinal(0)] 
		[RED("actor")] 
		public CWeakHandle<gameHudActor> Actor
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
	}
}
