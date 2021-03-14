using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AISearchingLookat : AIGenericStaticLookatTask
	{
		private CHandle<AIArgumentMapping> _minAngleDifferenceMapping;
		private CFloat _minAngleDifference;
		private CHandle<AIArgumentMapping> _maxLookAroundAngleMapping;
		private CFloat _maxLookAroundAngle;
		private Vector4 _currentTarget;
		private Vector4 _lastTarget;
		private CFloat _targetSwitchTimeStamp;
		private CFloat _targetSwitchCooldown;
		private CInt32 _sideHorizontal;
		private CInt32 _sideVertical;

		[Ordinal(4)] 
		[RED("minAngleDifferenceMapping")] 
		public CHandle<AIArgumentMapping> MinAngleDifferenceMapping
		{
			get
			{
				if (_minAngleDifferenceMapping == null)
				{
					_minAngleDifferenceMapping = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "minAngleDifferenceMapping", cr2w, this);
				}
				return _minAngleDifferenceMapping;
			}
			set
			{
				if (_minAngleDifferenceMapping == value)
				{
					return;
				}
				_minAngleDifferenceMapping = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("minAngleDifference")] 
		public CFloat MinAngleDifference
		{
			get
			{
				if (_minAngleDifference == null)
				{
					_minAngleDifference = (CFloat) CR2WTypeManager.Create("Float", "minAngleDifference", cr2w, this);
				}
				return _minAngleDifference;
			}
			set
			{
				if (_minAngleDifference == value)
				{
					return;
				}
				_minAngleDifference = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("maxLookAroundAngleMapping")] 
		public CHandle<AIArgumentMapping> MaxLookAroundAngleMapping
		{
			get
			{
				if (_maxLookAroundAngleMapping == null)
				{
					_maxLookAroundAngleMapping = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "maxLookAroundAngleMapping", cr2w, this);
				}
				return _maxLookAroundAngleMapping;
			}
			set
			{
				if (_maxLookAroundAngleMapping == value)
				{
					return;
				}
				_maxLookAroundAngleMapping = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("maxLookAroundAngle")] 
		public CFloat MaxLookAroundAngle
		{
			get
			{
				if (_maxLookAroundAngle == null)
				{
					_maxLookAroundAngle = (CFloat) CR2WTypeManager.Create("Float", "maxLookAroundAngle", cr2w, this);
				}
				return _maxLookAroundAngle;
			}
			set
			{
				if (_maxLookAroundAngle == value)
				{
					return;
				}
				_maxLookAroundAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("currentTarget")] 
		public Vector4 CurrentTarget
		{
			get
			{
				if (_currentTarget == null)
				{
					_currentTarget = (Vector4) CR2WTypeManager.Create("Vector4", "currentTarget", cr2w, this);
				}
				return _currentTarget;
			}
			set
			{
				if (_currentTarget == value)
				{
					return;
				}
				_currentTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("lastTarget")] 
		public Vector4 LastTarget
		{
			get
			{
				if (_lastTarget == null)
				{
					_lastTarget = (Vector4) CR2WTypeManager.Create("Vector4", "lastTarget", cr2w, this);
				}
				return _lastTarget;
			}
			set
			{
				if (_lastTarget == value)
				{
					return;
				}
				_lastTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("targetSwitchTimeStamp")] 
		public CFloat TargetSwitchTimeStamp
		{
			get
			{
				if (_targetSwitchTimeStamp == null)
				{
					_targetSwitchTimeStamp = (CFloat) CR2WTypeManager.Create("Float", "targetSwitchTimeStamp", cr2w, this);
				}
				return _targetSwitchTimeStamp;
			}
			set
			{
				if (_targetSwitchTimeStamp == value)
				{
					return;
				}
				_targetSwitchTimeStamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("targetSwitchCooldown")] 
		public CFloat TargetSwitchCooldown
		{
			get
			{
				if (_targetSwitchCooldown == null)
				{
					_targetSwitchCooldown = (CFloat) CR2WTypeManager.Create("Float", "targetSwitchCooldown", cr2w, this);
				}
				return _targetSwitchCooldown;
			}
			set
			{
				if (_targetSwitchCooldown == value)
				{
					return;
				}
				_targetSwitchCooldown = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("sideHorizontal")] 
		public CInt32 SideHorizontal
		{
			get
			{
				if (_sideHorizontal == null)
				{
					_sideHorizontal = (CInt32) CR2WTypeManager.Create("Int32", "sideHorizontal", cr2w, this);
				}
				return _sideHorizontal;
			}
			set
			{
				if (_sideHorizontal == value)
				{
					return;
				}
				_sideHorizontal = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("sideVertical")] 
		public CInt32 SideVertical
		{
			get
			{
				if (_sideVertical == null)
				{
					_sideVertical = (CInt32) CR2WTypeManager.Create("Int32", "sideVertical", cr2w, this);
				}
				return _sideVertical;
			}
			set
			{
				if (_sideVertical == value)
				{
					return;
				}
				_sideVertical = value;
				PropertySet(this);
			}
		}

		public AISearchingLookat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
