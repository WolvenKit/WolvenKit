using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EffectExecutor_Spread : gameEffectExecutor_Scripted
	{
		[Ordinal(1)] 
		[RED("objectActionRecord")] 
		public CWeakHandle<gamedataObjectAction_Record> ObjectActionRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataObjectAction_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataObjectAction_Record>>(value);
		}

		[Ordinal(2)] 
		[RED("prevEntity")] 
		public CWeakHandle<entEntity> PrevEntity
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		[Ordinal(3)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(4)] 
		[RED("spreadToAllTargetsInTheArea")] 
		public CBool SpreadToAllTargetsInTheArea
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public EffectExecutor_Spread()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
