using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsHitEvent : redEvent
	{
		private CHandle<gamedamageAttackData> _attackData;
		private wCHandle<gameObject> _target;
		private Vector4 _hitPosition;
		private Vector4 _hitDirection;
		private wCHandle<entIPlacedComponent> _hitComponent;
		private CName _hitColliderTag;
		private gameQueryResult _hitRepresentationResult;
		private CFloat _attackPentration;
		private CBool _hasPiercedTechSurface;
		private CHandle<gameAttackComputed> _attackComputed;
		private CBool _wasAliveBeforeHit;
		private CBool _projectionPipeline;

		[Ordinal(0)] 
		[RED("attackData")] 
		public CHandle<gamedamageAttackData> AttackData
		{
			get => GetProperty(ref _attackData);
			set => SetProperty(ref _attackData, value);
		}

		[Ordinal(1)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(2)] 
		[RED("hitPosition")] 
		public Vector4 HitPosition
		{
			get => GetProperty(ref _hitPosition);
			set => SetProperty(ref _hitPosition, value);
		}

		[Ordinal(3)] 
		[RED("hitDirection")] 
		public Vector4 HitDirection
		{
			get => GetProperty(ref _hitDirection);
			set => SetProperty(ref _hitDirection, value);
		}

		[Ordinal(4)] 
		[RED("hitComponent")] 
		public wCHandle<entIPlacedComponent> HitComponent
		{
			get => GetProperty(ref _hitComponent);
			set => SetProperty(ref _hitComponent, value);
		}

		[Ordinal(5)] 
		[RED("hitColliderTag")] 
		public CName HitColliderTag
		{
			get => GetProperty(ref _hitColliderTag);
			set => SetProperty(ref _hitColliderTag, value);
		}

		[Ordinal(6)] 
		[RED("hitRepresentationResult")] 
		public gameQueryResult HitRepresentationResult
		{
			get => GetProperty(ref _hitRepresentationResult);
			set => SetProperty(ref _hitRepresentationResult, value);
		}

		[Ordinal(7)] 
		[RED("attackPentration")] 
		public CFloat AttackPentration
		{
			get => GetProperty(ref _attackPentration);
			set => SetProperty(ref _attackPentration, value);
		}

		[Ordinal(8)] 
		[RED("hasPiercedTechSurface")] 
		public CBool HasPiercedTechSurface
		{
			get => GetProperty(ref _hasPiercedTechSurface);
			set => SetProperty(ref _hasPiercedTechSurface, value);
		}

		[Ordinal(9)] 
		[RED("attackComputed")] 
		public CHandle<gameAttackComputed> AttackComputed
		{
			get => GetProperty(ref _attackComputed);
			set => SetProperty(ref _attackComputed, value);
		}

		[Ordinal(10)] 
		[RED("wasAliveBeforeHit")] 
		public CBool WasAliveBeforeHit
		{
			get => GetProperty(ref _wasAliveBeforeHit);
			set => SetProperty(ref _wasAliveBeforeHit, value);
		}

		[Ordinal(11)] 
		[RED("projectionPipeline")] 
		public CBool ProjectionPipeline
		{
			get => GetProperty(ref _projectionPipeline);
			set => SetProperty(ref _projectionPipeline, value);
		}

		public gameeventsHitEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
