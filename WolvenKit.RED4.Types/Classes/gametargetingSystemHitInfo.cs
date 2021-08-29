using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gametargetingSystemHitInfo : RedBaseClass
	{
		private CUInt64 _queryMask;
		private entEntityID _entityId;
		private CWeakHandle<entEntity> _entity;
		private CWeakHandle<entIComponent> _component;
		private Vector4 _aimStartPosition;
		private Vector4 _closestHitPosition;
		private CBool _isTransparent;

		[Ordinal(0)] 
		[RED("queryMask")] 
		public CUInt64 QueryMask
		{
			get => GetProperty(ref _queryMask);
			set => SetProperty(ref _queryMask, value);
		}

		[Ordinal(1)] 
		[RED("entityId")] 
		public entEntityID EntityId
		{
			get => GetProperty(ref _entityId);
			set => SetProperty(ref _entityId, value);
		}

		[Ordinal(2)] 
		[RED("entity")] 
		public CWeakHandle<entEntity> Entity
		{
			get => GetProperty(ref _entity);
			set => SetProperty(ref _entity, value);
		}

		[Ordinal(3)] 
		[RED("component")] 
		public CWeakHandle<entIComponent> Component
		{
			get => GetProperty(ref _component);
			set => SetProperty(ref _component, value);
		}

		[Ordinal(4)] 
		[RED("aimStartPosition")] 
		public Vector4 AimStartPosition
		{
			get => GetProperty(ref _aimStartPosition);
			set => SetProperty(ref _aimStartPosition, value);
		}

		[Ordinal(5)] 
		[RED("closestHitPosition")] 
		public Vector4 ClosestHitPosition
		{
			get => GetProperty(ref _closestHitPosition);
			set => SetProperty(ref _closestHitPosition, value);
		}

		[Ordinal(6)] 
		[RED("isTransparent")] 
		public CBool IsTransparent
		{
			get => GetProperty(ref _isTransparent);
			set => SetProperty(ref _isTransparent, value);
		}
	}
}
