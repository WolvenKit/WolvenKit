using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TogglePreventionCrowdSpawns : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("toggle")] 
		public CBool Toggle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public TogglePreventionCrowdSpawns()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
