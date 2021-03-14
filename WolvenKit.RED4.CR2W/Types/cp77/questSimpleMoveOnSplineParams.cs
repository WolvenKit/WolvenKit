using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSimpleMoveOnSplineParams : CVariable
	{
		private CEnum<moveMovementType> _movementType;
		private CHandle<questUniversalRef> _facingTargetRef;
		private CBool _rotateEntityTowardsFacingTarget;
		private CBool _snapToTerrain;
		private CBool _useOffMeshLinkReservation;

		[Ordinal(0)] 
		[RED("movementType")] 
		public CEnum<moveMovementType> MovementType
		{
			get
			{
				if (_movementType == null)
				{
					_movementType = (CEnum<moveMovementType>) CR2WTypeManager.Create("moveMovementType", "movementType", cr2w, this);
				}
				return _movementType;
			}
			set
			{
				if (_movementType == value)
				{
					return;
				}
				_movementType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("facingTargetRef")] 
		public CHandle<questUniversalRef> FacingTargetRef
		{
			get
			{
				if (_facingTargetRef == null)
				{
					_facingTargetRef = (CHandle<questUniversalRef>) CR2WTypeManager.Create("handle:questUniversalRef", "facingTargetRef", cr2w, this);
				}
				return _facingTargetRef;
			}
			set
			{
				if (_facingTargetRef == value)
				{
					return;
				}
				_facingTargetRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("rotateEntityTowardsFacingTarget")] 
		public CBool RotateEntityTowardsFacingTarget
		{
			get
			{
				if (_rotateEntityTowardsFacingTarget == null)
				{
					_rotateEntityTowardsFacingTarget = (CBool) CR2WTypeManager.Create("Bool", "rotateEntityTowardsFacingTarget", cr2w, this);
				}
				return _rotateEntityTowardsFacingTarget;
			}
			set
			{
				if (_rotateEntityTowardsFacingTarget == value)
				{
					return;
				}
				_rotateEntityTowardsFacingTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("snapToTerrain")] 
		public CBool SnapToTerrain
		{
			get
			{
				if (_snapToTerrain == null)
				{
					_snapToTerrain = (CBool) CR2WTypeManager.Create("Bool", "snapToTerrain", cr2w, this);
				}
				return _snapToTerrain;
			}
			set
			{
				if (_snapToTerrain == value)
				{
					return;
				}
				_snapToTerrain = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("useOffMeshLinkReservation")] 
		public CBool UseOffMeshLinkReservation
		{
			get
			{
				if (_useOffMeshLinkReservation == null)
				{
					_useOffMeshLinkReservation = (CBool) CR2WTypeManager.Create("Bool", "useOffMeshLinkReservation", cr2w, this);
				}
				return _useOffMeshLinkReservation;
			}
			set
			{
				if (_useOffMeshLinkReservation == value)
				{
					return;
				}
				_useOffMeshLinkReservation = value;
				PropertySet(this);
			}
		}

		public questSimpleMoveOnSplineParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
