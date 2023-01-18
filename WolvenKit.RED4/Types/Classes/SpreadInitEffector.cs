using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SpreadInitEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("objectActionRecord")] 
		public CWeakHandle<gamedataObjectAction_Record> ObjectActionRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataObjectAction_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataObjectAction_Record>>(value);
		}

		[Ordinal(1)] 
		[RED("effectorRecord")] 
		public CHandle<gamedataSpreadInitEffector_Record> EffectorRecord
		{
			get => GetPropertyValue<CHandle<gamedataSpreadInitEffector_Record>>();
			set => SetPropertyValue<CHandle<gamedataSpreadInitEffector_Record>>(value);
		}

		[Ordinal(2)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		public SpreadInitEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
