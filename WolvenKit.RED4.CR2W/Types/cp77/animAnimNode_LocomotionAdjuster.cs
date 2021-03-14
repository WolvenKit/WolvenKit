using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_LocomotionAdjuster : animAnimNode_OnePoseInput
	{
		private animVectorLink _targetPosition;
		private animVectorLink _targetDirection;
		private Vector4 _initialForwardVector;
		private CFloat _blendSpeedPos;
		private CFloat _blendSpeedPosMin;
		private CFloat _blendSpeedRot;
		private CFloat _maxDistance;

		[Ordinal(12)] 
		[RED("targetPosition")] 
		public animVectorLink TargetPosition
		{
			get
			{
				if (_targetPosition == null)
				{
					_targetPosition = (animVectorLink) CR2WTypeManager.Create("animVectorLink", "targetPosition", cr2w, this);
				}
				return _targetPosition;
			}
			set
			{
				if (_targetPosition == value)
				{
					return;
				}
				_targetPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("targetDirection")] 
		public animVectorLink TargetDirection
		{
			get
			{
				if (_targetDirection == null)
				{
					_targetDirection = (animVectorLink) CR2WTypeManager.Create("animVectorLink", "targetDirection", cr2w, this);
				}
				return _targetDirection;
			}
			set
			{
				if (_targetDirection == value)
				{
					return;
				}
				_targetDirection = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("initialForwardVector")] 
		public Vector4 InitialForwardVector
		{
			get
			{
				if (_initialForwardVector == null)
				{
					_initialForwardVector = (Vector4) CR2WTypeManager.Create("Vector4", "initialForwardVector", cr2w, this);
				}
				return _initialForwardVector;
			}
			set
			{
				if (_initialForwardVector == value)
				{
					return;
				}
				_initialForwardVector = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("blendSpeedPos")] 
		public CFloat BlendSpeedPos
		{
			get
			{
				if (_blendSpeedPos == null)
				{
					_blendSpeedPos = (CFloat) CR2WTypeManager.Create("Float", "blendSpeedPos", cr2w, this);
				}
				return _blendSpeedPos;
			}
			set
			{
				if (_blendSpeedPos == value)
				{
					return;
				}
				_blendSpeedPos = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("blendSpeedPosMin")] 
		public CFloat BlendSpeedPosMin
		{
			get
			{
				if (_blendSpeedPosMin == null)
				{
					_blendSpeedPosMin = (CFloat) CR2WTypeManager.Create("Float", "blendSpeedPosMin", cr2w, this);
				}
				return _blendSpeedPosMin;
			}
			set
			{
				if (_blendSpeedPosMin == value)
				{
					return;
				}
				_blendSpeedPosMin = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("blendSpeedRot")] 
		public CFloat BlendSpeedRot
		{
			get
			{
				if (_blendSpeedRot == null)
				{
					_blendSpeedRot = (CFloat) CR2WTypeManager.Create("Float", "blendSpeedRot", cr2w, this);
				}
				return _blendSpeedRot;
			}
			set
			{
				if (_blendSpeedRot == value)
				{
					return;
				}
				_blendSpeedRot = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("maxDistance")] 
		public CFloat MaxDistance
		{
			get
			{
				if (_maxDistance == null)
				{
					_maxDistance = (CFloat) CR2WTypeManager.Create("Float", "maxDistance", cr2w, this);
				}
				return _maxDistance;
			}
			set
			{
				if (_maxDistance == value)
				{
					return;
				}
				_maxDistance = value;
				PropertySet(this);
			}
		}

		public animAnimNode_LocomotionAdjuster(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
