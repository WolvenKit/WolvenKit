using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorDriveFollowTargetTreeNodeDefinition : AIbehaviorDriveTreeNodeDefinition
	{
		private CHandle<AIArgumentMapping> _useKinematic;
		private CHandle<AIArgumentMapping> _needDriver;
		private CHandle<AIArgumentMapping> _target;
		private CHandle<AIArgumentMapping> _secureTimeOut;
		private CHandle<AIArgumentMapping> _distanceMin;
		private CHandle<AIArgumentMapping> _distanceMax;
		private CHandle<AIArgumentMapping> _isPlayer;
		private CHandle<AIArgumentMapping> _stopHasReachedTarget;
		private CHandle<AIArgumentMapping> _useTraffic;
		private CHandle<AIArgumentMapping> _allowStubMovement;

		[Ordinal(1)] 
		[RED("useKinematic")] 
		public CHandle<AIArgumentMapping> UseKinematic
		{
			get
			{
				if (_useKinematic == null)
				{
					_useKinematic = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "useKinematic", cr2w, this);
				}
				return _useKinematic;
			}
			set
			{
				if (_useKinematic == value)
				{
					return;
				}
				_useKinematic = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("needDriver")] 
		public CHandle<AIArgumentMapping> NeedDriver
		{
			get
			{
				if (_needDriver == null)
				{
					_needDriver = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "needDriver", cr2w, this);
				}
				return _needDriver;
			}
			set
			{
				if (_needDriver == value)
				{
					return;
				}
				_needDriver = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("target")] 
		public CHandle<AIArgumentMapping> Target
		{
			get
			{
				if (_target == null)
				{
					_target = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "target", cr2w, this);
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

		[Ordinal(4)] 
		[RED("secureTimeOut")] 
		public CHandle<AIArgumentMapping> SecureTimeOut
		{
			get
			{
				if (_secureTimeOut == null)
				{
					_secureTimeOut = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "secureTimeOut", cr2w, this);
				}
				return _secureTimeOut;
			}
			set
			{
				if (_secureTimeOut == value)
				{
					return;
				}
				_secureTimeOut = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("distanceMin")] 
		public CHandle<AIArgumentMapping> DistanceMin
		{
			get
			{
				if (_distanceMin == null)
				{
					_distanceMin = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "distanceMin", cr2w, this);
				}
				return _distanceMin;
			}
			set
			{
				if (_distanceMin == value)
				{
					return;
				}
				_distanceMin = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("distanceMax")] 
		public CHandle<AIArgumentMapping> DistanceMax
		{
			get
			{
				if (_distanceMax == null)
				{
					_distanceMax = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "distanceMax", cr2w, this);
				}
				return _distanceMax;
			}
			set
			{
				if (_distanceMax == value)
				{
					return;
				}
				_distanceMax = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("isPlayer")] 
		public CHandle<AIArgumentMapping> IsPlayer
		{
			get
			{
				if (_isPlayer == null)
				{
					_isPlayer = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "isPlayer", cr2w, this);
				}
				return _isPlayer;
			}
			set
			{
				if (_isPlayer == value)
				{
					return;
				}
				_isPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("stopHasReachedTarget")] 
		public CHandle<AIArgumentMapping> StopHasReachedTarget
		{
			get
			{
				if (_stopHasReachedTarget == null)
				{
					_stopHasReachedTarget = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "stopHasReachedTarget", cr2w, this);
				}
				return _stopHasReachedTarget;
			}
			set
			{
				if (_stopHasReachedTarget == value)
				{
					return;
				}
				_stopHasReachedTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("useTraffic")] 
		public CHandle<AIArgumentMapping> UseTraffic
		{
			get
			{
				if (_useTraffic == null)
				{
					_useTraffic = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "useTraffic", cr2w, this);
				}
				return _useTraffic;
			}
			set
			{
				if (_useTraffic == value)
				{
					return;
				}
				_useTraffic = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("allowStubMovement")] 
		public CHandle<AIArgumentMapping> AllowStubMovement
		{
			get
			{
				if (_allowStubMovement == null)
				{
					_allowStubMovement = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "allowStubMovement", cr2w, this);
				}
				return _allowStubMovement;
			}
			set
			{
				if (_allowStubMovement == value)
				{
					return;
				}
				_allowStubMovement = value;
				PropertySet(this);
			}
		}

		public AIbehaviorDriveFollowTargetTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
