using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StoreMiniGameProgramEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("program")] 
		public gameuiMinigameProgramData Program
		{
			get => GetPropertyValue<gameuiMinigameProgramData>();
			set => SetPropertyValue<gameuiMinigameProgramData>(value);
		}

		[Ordinal(1)] 
		[RED("add")] 
		public CBool Add
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public StoreMiniGameProgramEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
