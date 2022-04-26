using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SquadMemberBaseComponent : gameSquadMemberComponent
	{
		[Ordinal(4)] 
		[RED("baseSquadRecord")] 
		public CWeakHandle<gamedataAISquadParams_Record> BaseSquadRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataAISquadParams_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataAISquadParams_Record>>(value);
		}

		public SquadMemberBaseComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
