using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorFindClosestPointOnTrafficPathTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _enterClosest;
		private CHandle<AIArgumentMapping> _avoidedPosition;
		private CHandle<AIArgumentMapping> _avoidedPositionDistance;
		private CHandle<AIArgumentMapping> _usePreviousPosition;
		private CHandle<AIArgumentMapping> _checkRoadIntersection;
		private CHandle<AIArgumentMapping> _positionOnPath;
		private CHandle<AIArgumentMapping> _pathDirection;
		private CHandle<AIArgumentMapping> _joinTrafficSettings;

		[Ordinal(1)] 
		[RED("enterClosest")] 
		public CHandle<AIArgumentMapping> EnterClosest
		{
			get
			{
				if (_enterClosest == null)
				{
					_enterClosest = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "enterClosest", cr2w, this);
				}
				return _enterClosest;
			}
			set
			{
				if (_enterClosest == value)
				{
					return;
				}
				_enterClosest = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("avoidedPosition")] 
		public CHandle<AIArgumentMapping> AvoidedPosition
		{
			get
			{
				if (_avoidedPosition == null)
				{
					_avoidedPosition = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "avoidedPosition", cr2w, this);
				}
				return _avoidedPosition;
			}
			set
			{
				if (_avoidedPosition == value)
				{
					return;
				}
				_avoidedPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("avoidedPositionDistance")] 
		public CHandle<AIArgumentMapping> AvoidedPositionDistance
		{
			get
			{
				if (_avoidedPositionDistance == null)
				{
					_avoidedPositionDistance = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "avoidedPositionDistance", cr2w, this);
				}
				return _avoidedPositionDistance;
			}
			set
			{
				if (_avoidedPositionDistance == value)
				{
					return;
				}
				_avoidedPositionDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("usePreviousPosition")] 
		public CHandle<AIArgumentMapping> UsePreviousPosition
		{
			get
			{
				if (_usePreviousPosition == null)
				{
					_usePreviousPosition = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "usePreviousPosition", cr2w, this);
				}
				return _usePreviousPosition;
			}
			set
			{
				if (_usePreviousPosition == value)
				{
					return;
				}
				_usePreviousPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("checkRoadIntersection")] 
		public CHandle<AIArgumentMapping> CheckRoadIntersection
		{
			get
			{
				if (_checkRoadIntersection == null)
				{
					_checkRoadIntersection = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "checkRoadIntersection", cr2w, this);
				}
				return _checkRoadIntersection;
			}
			set
			{
				if (_checkRoadIntersection == value)
				{
					return;
				}
				_checkRoadIntersection = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("positionOnPath")] 
		public CHandle<AIArgumentMapping> PositionOnPath
		{
			get
			{
				if (_positionOnPath == null)
				{
					_positionOnPath = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "positionOnPath", cr2w, this);
				}
				return _positionOnPath;
			}
			set
			{
				if (_positionOnPath == value)
				{
					return;
				}
				_positionOnPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("pathDirection")] 
		public CHandle<AIArgumentMapping> PathDirection
		{
			get
			{
				if (_pathDirection == null)
				{
					_pathDirection = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "pathDirection", cr2w, this);
				}
				return _pathDirection;
			}
			set
			{
				if (_pathDirection == value)
				{
					return;
				}
				_pathDirection = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("joinTrafficSettings")] 
		public CHandle<AIArgumentMapping> JoinTrafficSettings
		{
			get
			{
				if (_joinTrafficSettings == null)
				{
					_joinTrafficSettings = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "joinTrafficSettings", cr2w, this);
				}
				return _joinTrafficSettings;
			}
			set
			{
				if (_joinTrafficSettings == value)
				{
					return;
				}
				_joinTrafficSettings = value;
				PropertySet(this);
			}
		}

		public AIbehaviorFindClosestPointOnTrafficPathTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
