using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HUDJob : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("actor")] 
		public CWeakHandle<gameHudActor> Actor
		{
			get => GetPropertyValue<CWeakHandle<gameHudActor>>();
			set => SetPropertyValue<CWeakHandle<gameHudActor>>(value);
		}

		[Ordinal(1)] 
		[RED("instruction")] 
		public CHandle<HUDInstruction> Instruction
		{
			get => GetPropertyValue<CHandle<HUDInstruction>>();
			set => SetPropertyValue<CHandle<HUDInstruction>>(value);
		}

		public HUDJob()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
