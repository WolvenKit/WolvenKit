using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StimuliSquadActionEvent : senseBaseStimuliEvent
	{
		[Ordinal(2)] 
		[RED("squadActionName")] 
		public CName SquadActionName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("squadVerb")] 
		public CEnum<EAISquadVerb> SquadVerb
		{
			get => GetPropertyValue<CEnum<EAISquadVerb>>();
			set => SetPropertyValue<CEnum<EAISquadVerb>>(value);
		}

		public StimuliSquadActionEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
