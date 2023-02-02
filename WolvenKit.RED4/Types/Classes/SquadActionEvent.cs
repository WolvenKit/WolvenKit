using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SquadActionEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("squadActionName")] 
		public CName SquadActionName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("squadVerb")] 
		public CEnum<EAISquadVerb> SquadVerb
		{
			get => GetPropertyValue<CEnum<EAISquadVerb>>();
			set => SetPropertyValue<CEnum<EAISquadVerb>>(value);
		}

		public SquadActionEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
