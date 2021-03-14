using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questFollowParams : questAICommandParams
	{
		private CHandle<questUniversalRef> _companionRef;
		private CFloat _companionDistance;
		private CFloat _destinationPointTolerance;
		private CBool _stopWhenDestinationReached;
		private CEnum<moveMovementType> _movementType;
		private CBool _matchSpeed;
		private CBool _useTeleport;
		private CBool _repeatCommandOnInterrupt;

		[Ordinal(0)] 
		[RED("companionRef")] 
		public CHandle<questUniversalRef> CompanionRef
		{
			get
			{
				if (_companionRef == null)
				{
					_companionRef = (CHandle<questUniversalRef>) CR2WTypeManager.Create("handle:questUniversalRef", "companionRef", cr2w, this);
				}
				return _companionRef;
			}
			set
			{
				if (_companionRef == value)
				{
					return;
				}
				_companionRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("companionDistance")] 
		public CFloat CompanionDistance
		{
			get
			{
				if (_companionDistance == null)
				{
					_companionDistance = (CFloat) CR2WTypeManager.Create("Float", "companionDistance", cr2w, this);
				}
				return _companionDistance;
			}
			set
			{
				if (_companionDistance == value)
				{
					return;
				}
				_companionDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("destinationPointTolerance")] 
		public CFloat DestinationPointTolerance
		{
			get
			{
				if (_destinationPointTolerance == null)
				{
					_destinationPointTolerance = (CFloat) CR2WTypeManager.Create("Float", "destinationPointTolerance", cr2w, this);
				}
				return _destinationPointTolerance;
			}
			set
			{
				if (_destinationPointTolerance == value)
				{
					return;
				}
				_destinationPointTolerance = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("stopWhenDestinationReached")] 
		public CBool StopWhenDestinationReached
		{
			get
			{
				if (_stopWhenDestinationReached == null)
				{
					_stopWhenDestinationReached = (CBool) CR2WTypeManager.Create("Bool", "stopWhenDestinationReached", cr2w, this);
				}
				return _stopWhenDestinationReached;
			}
			set
			{
				if (_stopWhenDestinationReached == value)
				{
					return;
				}
				_stopWhenDestinationReached = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
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

		[Ordinal(5)] 
		[RED("matchSpeed")] 
		public CBool MatchSpeed
		{
			get
			{
				if (_matchSpeed == null)
				{
					_matchSpeed = (CBool) CR2WTypeManager.Create("Bool", "matchSpeed", cr2w, this);
				}
				return _matchSpeed;
			}
			set
			{
				if (_matchSpeed == value)
				{
					return;
				}
				_matchSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("useTeleport")] 
		public CBool UseTeleport
		{
			get
			{
				if (_useTeleport == null)
				{
					_useTeleport = (CBool) CR2WTypeManager.Create("Bool", "useTeleport", cr2w, this);
				}
				return _useTeleport;
			}
			set
			{
				if (_useTeleport == value)
				{
					return;
				}
				_useTeleport = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("repeatCommandOnInterrupt")] 
		public CBool RepeatCommandOnInterrupt
		{
			get
			{
				if (_repeatCommandOnInterrupt == null)
				{
					_repeatCommandOnInterrupt = (CBool) CR2WTypeManager.Create("Bool", "repeatCommandOnInterrupt", cr2w, this);
				}
				return _repeatCommandOnInterrupt;
			}
			set
			{
				if (_repeatCommandOnInterrupt == value)
				{
					return;
				}
				_repeatCommandOnInterrupt = value;
				PropertySet(this);
			}
		}

		public questFollowParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
