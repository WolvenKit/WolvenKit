using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorPickSearchDestinationTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _destinationPosition;
		private CHandle<AIArgumentMapping> _desiredDistance;
		private CHandle<AIArgumentMapping> _maxDistance;
		private CHandle<AIArgumentMapping> _clearedAreaRadius;
		private CHandle<AIArgumentMapping> _clearedAreaDistance;
		private CHandle<AIArgumentMapping> _clearedAreaAngle;
		private CHandle<AIArgumentMapping> _ignoreRestrictMovementArea;

		[Ordinal(1)] 
		[RED("destinationPosition")] 
		public CHandle<AIArgumentMapping> DestinationPosition
		{
			get
			{
				if (_destinationPosition == null)
				{
					_destinationPosition = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "destinationPosition", cr2w, this);
				}
				return _destinationPosition;
			}
			set
			{
				if (_destinationPosition == value)
				{
					return;
				}
				_destinationPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("desiredDistance")] 
		public CHandle<AIArgumentMapping> DesiredDistance
		{
			get
			{
				if (_desiredDistance == null)
				{
					_desiredDistance = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "desiredDistance", cr2w, this);
				}
				return _desiredDistance;
			}
			set
			{
				if (_desiredDistance == value)
				{
					return;
				}
				_desiredDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("maxDistance")] 
		public CHandle<AIArgumentMapping> MaxDistance
		{
			get
			{
				if (_maxDistance == null)
				{
					_maxDistance = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "maxDistance", cr2w, this);
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

		[Ordinal(4)] 
		[RED("clearedAreaRadius")] 
		public CHandle<AIArgumentMapping> ClearedAreaRadius
		{
			get
			{
				if (_clearedAreaRadius == null)
				{
					_clearedAreaRadius = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "clearedAreaRadius", cr2w, this);
				}
				return _clearedAreaRadius;
			}
			set
			{
				if (_clearedAreaRadius == value)
				{
					return;
				}
				_clearedAreaRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("clearedAreaDistance")] 
		public CHandle<AIArgumentMapping> ClearedAreaDistance
		{
			get
			{
				if (_clearedAreaDistance == null)
				{
					_clearedAreaDistance = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "clearedAreaDistance", cr2w, this);
				}
				return _clearedAreaDistance;
			}
			set
			{
				if (_clearedAreaDistance == value)
				{
					return;
				}
				_clearedAreaDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("clearedAreaAngle")] 
		public CHandle<AIArgumentMapping> ClearedAreaAngle
		{
			get
			{
				if (_clearedAreaAngle == null)
				{
					_clearedAreaAngle = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "clearedAreaAngle", cr2w, this);
				}
				return _clearedAreaAngle;
			}
			set
			{
				if (_clearedAreaAngle == value)
				{
					return;
				}
				_clearedAreaAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("ignoreRestrictMovementArea")] 
		public CHandle<AIArgumentMapping> IgnoreRestrictMovementArea
		{
			get
			{
				if (_ignoreRestrictMovementArea == null)
				{
					_ignoreRestrictMovementArea = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "ignoreRestrictMovementArea", cr2w, this);
				}
				return _ignoreRestrictMovementArea;
			}
			set
			{
				if (_ignoreRestrictMovementArea == value)
				{
					return;
				}
				_ignoreRestrictMovementArea = value;
				PropertySet(this);
			}
		}

		public AIbehaviorPickSearchDestinationTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
