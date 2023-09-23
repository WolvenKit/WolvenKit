using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SpreadAreaEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("maxTargetNum")] 
		public CInt32 MaxTargetNum
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("range")] 
		public CFloat Range
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("objectActionsRecord")] 
		public CArray<CWeakHandle<gamedataObjectAction_Record>> ObjectActionsRecord
		{
			get => GetPropertyValue<CArray<CWeakHandle<gamedataObjectAction_Record>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gamedataObjectAction_Record>>>(value);
		}

		[Ordinal(3)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		public SpreadAreaEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
