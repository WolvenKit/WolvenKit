using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIFlatheadSetSoloModeCommandParams : questScriptedAICommandParams
	{
		[Ordinal(0)] 
		[RED("soloMode")] 
		public CBool SoloMode
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AIFlatheadSetSoloModeCommandParams()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
