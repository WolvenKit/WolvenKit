using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AISquadIsTracked : AIAIEvent
	{
		[Ordinal(2)] 
		[RED("isSquadTracked")] 
		public CBool IsSquadTracked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AISquadIsTracked()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
