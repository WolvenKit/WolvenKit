using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SquadActionSignal : gameTaggedSignalUserData
	{
		[Ordinal(1)] 
		[RED("squadActionName")] 
		public CName SquadActionName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("squadVerb")] 
		public CEnum<EAISquadVerb> SquadVerb
		{
			get => GetPropertyValue<CEnum<EAISquadVerb>>();
			set => SetPropertyValue<CEnum<EAISquadVerb>>(value);
		}

		public SquadActionSignal()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
