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
			get
			{
				if (_attackData == null)
				{
					_attackData = (CHandle<gamedamageAttackData>) CR2WTypeManager.Create("handle:gamedamageAttackData", "attackData", cr2w, this);
				}
				return _attackData;
			}
			set
			{
				if (_attackData == value)
				{
					return;
				}
				_attackData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
		{
			get
			{
				if (_target == null)
				{
					_target = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "target", cr2w, this);
				}
				return _target;
			}
			set
			{
				if (_target == value)
				{
					return;
				}
				_target = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("hitPosition")] 
		public Vector4 HitPosition
		{
			get
			{
				if (_hitPosition == null)
				{
					_hitPosition = (Vector4) CR2WTypeManager.Create("Vector4", "hitPosition", cr2w, this);
				}
				return _hitPosition;
			}
			set
			{
				if (_hitPosition == value)
				{
					return;
				}
				_hitPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("hitDirection")] 
		public Vector4 HitDirection
		{
			get
			{
				if (_hitDirection == null)
				{
					_hitDirection = (Vector4) CR2WTypeManager.Create("Vector4", "hitDirection", cr2w, this);
				}
				return _hitDirection;
			}
			set
			{
				if (_hitDirection == value)
				{
					return;
				}
				_hitDirection = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("hitComponent")] 
		public wCHandle<entIPlacedComponent> HitComponent
		{
			get
			{
				if (_hitComponent == null)
				{
					_hitComponent = (wCHandle<entIPlacedComponent>) CR2WTypeManager.Create("whandle:entIPlacedComponent", "hitComponent", cr2w, this);
				}
				return _hitComponent;
			}
			set
			{
				if (_hitComponent == value)
				{
					return;
				}
				_hitComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("hitColliderTag")] 
		public CName HitColliderTag
		{
			get
			{
				if (_hitColliderTag == null)
				{
					_hitColliderTag = (CName) CR2WTypeManager.Create("CName", "hitColliderTag", cr2w, this);
				}
				return _hitColliderTag;
			}
			set
			{
				if (_hitColliderTag == value)
				{
					return;
				}
				_hitColliderTag = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("hitRepresentationResult")] 
		public gameQueryResult HitRepresentationResult
		{
			get
			{
				if (_hitRepresentationResult == null)
				{
					_hitRepresentationResult = (gameQueryResult) CR2WTypeManager.Create("gameQueryResult", "hitRepresentationResult", cr2w, this);
				}
				return _hitRepresentationResult;
			}
			set
			{
				if (_hitRepresentationResult == value)
				{
					return;
				}
				_hitRepresentationResult = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("attackPentration")] 
		public CFloat AttackPentration
		{
			get
			{
				if (_attackPentration == null)
				{
					_attackPentration = (CFloat) CR2WTypeManager.Create("Float", "attackPentration", cr2w, this);
				}
				return _attackPentration;
			}
			set
			{
				if (_attackPentration == value)
				{
					return;
				}
				_attackPentration = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("hasPiercedTechSurface")] 
		public CBool HasPiercedTechSurface
		{
			get
			{
				if (_hasPiercedTechSurface == null)
				{
					_hasPiercedTechSurface = (CBool) CR2WTypeManager.Create("Bool", "hasPiercedTechSurface", cr2w, this);
				}
				return _hasPiercedTechSurface;
			}
			set
			{
				if (_hasPiercedTechSurface == value)
				{
					return;
				}
				_hasPiercedTechSurface = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("attackComputed")] 
		public CHandle<gameAttackComputed> AttackComputed
		{
			get
			{
				if (_attackComputed == null)
				{
					_attackComputed = (CHandle<gameAttackComputed>) CR2WTypeManager.Create("handle:gameAttackComputed", "attackComputed", cr2w, this);
				}
				return _attackComputed;
			}
			set
			{
				if (_attackComputed == value)
				{
					return;
				}
				_attackComputed = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("wasAliveBeforeHit")] 
		public CBool WasAliveBeforeHit
		{
			get
			{
				if (_wasAliveBeforeHit == null)
				{
					_wasAliveBeforeHit = (CBool) CR2WTypeManager.Create("Bool", "wasAliveBeforeHit", cr2w, this);
				}
				return _wasAliveBeforeHit;
			}
			set
			{
				if (_wasAliveBeforeHit == value)
				{
					return;
				}
				_wasAliveBeforeHit = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("projectionPipeline")] 
		public CBool ProjectionPipeline
		{
			get
			{
				if (_projectionPipeline == null)
				{
					_projectionPipeline = (CBool) CR2WTypeManager.Create("Bool", "projectionPipeline", cr2w, this);
				}
				return _projectionPipeline;
			}
			set
			{
				if (_projectionPipeline == value)
				{
					return;
				}
				_projectionPipeline = value;
				PropertySet(this);
			}
		}

		public gameeventsHitEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
