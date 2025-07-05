using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PullSquadSyncRequest : AIAIEvent
	{
		[Ordinal(2)] 
		[RED("squadType")] 
		public CEnum<AISquadType> SquadType
		{
			get => GetPropertyValue<CEnum<AISquadType>>();
			set => SetPropertyValue<CEnum<AISquadType>>(value);
		}

		public PullSquadSyncRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
