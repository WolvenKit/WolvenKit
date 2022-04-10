using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SpreadEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("objectActionRecord")] 
		public CWeakHandle<gamedataObjectAction_Record> ObjectActionRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataObjectAction_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataObjectAction_Record>>(value);
		}

		[Ordinal(1)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(2)] 
		[RED("effectorRecord")] 
		public CHandle<gamedataSpreadEffector_Record> EffectorRecord
		{
			get => GetPropertyValue<CHandle<gamedataSpreadEffector_Record>>();
			set => SetPropertyValue<CHandle<gamedataSpreadEffector_Record>>(value);
		}

		[Ordinal(3)] 
		[RED("spreadToAllTargetsInTheArea")] 
		public CBool SpreadToAllTargetsInTheArea
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SpreadEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
