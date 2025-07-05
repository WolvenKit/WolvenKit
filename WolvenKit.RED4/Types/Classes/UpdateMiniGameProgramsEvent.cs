using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UpdateMiniGameProgramsEvent : redEvent
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

		public UpdateMiniGameProgramsEvent()
		{
			Program = new gameuiMinigameProgramData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
