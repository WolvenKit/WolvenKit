using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIFlatheadSetSoloModeCommand : AIFollowerCommand
	{
		[Ordinal(5)] 
		[RED("soloModeState")] 
		public CBool SoloModeState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AIFlatheadSetSoloModeCommand()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
