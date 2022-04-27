using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gametargetingSystemHitInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("queryMask")] 
		public CUInt64 QueryMask
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(1)] 
		[RED("entityId")] 
		public entEntityID EntityId
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(2)] 
		[RED("entity")] 
		public CWeakHandle<entEntity> Entity
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		[Ordinal(3)] 
		[RED("component")] 
		public CWeakHandle<entIComponent> Component
		{
			get => GetPropertyValue<CWeakHandle<entIComponent>>();
			set => SetPropertyValue<CWeakHandle<entIComponent>>(value);
		}

		[Ordinal(4)] 
		[RED("aimStartPosition")] 
		public Vector4 AimStartPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(5)] 
		[RED("closestHitPosition")] 
		public Vector4 ClosestHitPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(6)] 
		[RED("isTransparent")] 
		public CBool IsTransparent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gametargetingSystemHitInfo()
		{
			EntityId = new();
			AimStartPosition = new();
			ClosestHitPosition = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
