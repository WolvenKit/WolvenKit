using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamesmartGunUIParameters : IScriptable
	{
		private CArray<gamesmartGunUITargetParameters> _targets;
		private gamesmartGunUISightParameters _sight;
		private Vector2 _crosshairPos;
		private CBool _hasRequiredCyberware;
		private CFloat _timeToRemoveOccludedTarget;
		private CFloat _timeToLock;
		private CFloat _timeToUnlock;

		[Ordinal(0)] 
		[RED("targets")] 
		public CArray<gamesmartGunUITargetParameters> Targets
		{
			get
			{
				if (_targets == null)
				{
					_targets = (CArray<gamesmartGunUITargetParameters>) CR2WTypeManager.Create("array:gamesmartGunUITargetParameters", "targets", cr2w, this);
				}
				return _targets;
			}
			set
			{
				if (_targets == value)
				{
					return;
				}
				_targets = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("sight")] 
		public gamesmartGunUISightParameters Sight
		{
			get
			{
				if (_sight == null)
				{
					_sight = (gamesmartGunUISightParameters) CR2WTypeManager.Create("gamesmartGunUISightParameters", "sight", cr2w, this);
				}
				return _sight;
			}
			set
			{
				if (_sight == value)
				{
					return;
				}
				_sight = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("crosshairPos")] 
		public Vector2 CrosshairPos
		{
			get
			{
				if (_crosshairPos == null)
				{
					_crosshairPos = (Vector2) CR2WTypeManager.Create("Vector2", "crosshairPos", cr2w, this);
				}
				return _crosshairPos;
			}
			set
			{
				if (_crosshairPos == value)
				{
					return;
				}
				_crosshairPos = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("hasRequiredCyberware")] 
		public CBool HasRequiredCyberware
		{
			get
			{
				if (_hasRequiredCyberware == null)
				{
					_hasRequiredCyberware = (CBool) CR2WTypeManager.Create("Bool", "hasRequiredCyberware", cr2w, this);
				}
				return _hasRequiredCyberware;
			}
			set
			{
				if (_hasRequiredCyberware == value)
				{
					return;
				}
				_hasRequiredCyberware = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("timeToRemoveOccludedTarget")] 
		public CFloat TimeToRemoveOccludedTarget
		{
			get
			{
				if (_timeToRemoveOccludedTarget == null)
				{
					_timeToRemoveOccludedTarget = (CFloat) CR2WTypeManager.Create("Float", "timeToRemoveOccludedTarget", cr2w, this);
				}
				return _timeToRemoveOccludedTarget;
			}
			set
			{
				if (_timeToRemoveOccludedTarget == value)
				{
					return;
				}
				_timeToRemoveOccludedTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("timeToLock")] 
		public CFloat TimeToLock
		{
			get
			{
				if (_timeToLock == null)
				{
					_timeToLock = (CFloat) CR2WTypeManager.Create("Float", "timeToLock", cr2w, this);
				}
				return _timeToLock;
			}
			set
			{
				if (_timeToLock == value)
				{
					return;
				}
				_timeToLock = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("timeToUnlock")] 
		public CFloat TimeToUnlock
		{
			get
			{
				if (_timeToUnlock == null)
				{
					_timeToUnlock = (CFloat) CR2WTypeManager.Create("Float", "timeToUnlock", cr2w, this);
				}
				return _timeToUnlock;
			}
			set
			{
				if (_timeToUnlock == value)
				{
					return;
				}
				_timeToUnlock = value;
				PropertySet(this);
			}
		}

		public gamesmartGunUIParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
