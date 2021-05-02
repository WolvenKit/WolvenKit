using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gametargetingSystemHitInfo : CVariable
	{
		private CUInt64 _queryMask;
		private entEntityID _entityId;
		private wCHandle<entEntity> _entity;
		private wCHandle<entIComponent> _component;
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
		public wCHandle<entEntity> Entity
		{
			get => GetProperty(ref _entity);
			set => SetProperty(ref _entity, value);
		}

		[Ordinal(3)] 
		[RED("component")] 
		public wCHandle<entIComponent> Component
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

		public gametargetingSystemHitInfo(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
