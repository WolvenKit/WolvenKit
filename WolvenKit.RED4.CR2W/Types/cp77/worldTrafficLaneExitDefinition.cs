using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficLaneExitDefinition : CVariable
	{
		private NodeRef _outLaneRef;
		private Vector4 _exitPosition;
		private CFloat _exitProbability;
		private CBool _endConnection;
		private CBool _thisLaneReversed;
		private CBool _outLaneReversed;

		[Ordinal(0)] 
		[RED("outLaneRef")] 
		public NodeRef OutLaneRef
		{
			get
			{
				if (_outLaneRef == null)
				{
					_outLaneRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "outLaneRef", cr2w, this);
				}
				return _outLaneRef;
			}
			set
			{
				if (_outLaneRef == value)
				{
					return;
				}
				_outLaneRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("exitPosition")] 
		public Vector4 ExitPosition
		{
			get
			{
				if (_exitPosition == null)
				{
					_exitPosition = (Vector4) CR2WTypeManager.Create("Vector4", "exitPosition", cr2w, this);
				}
				return _exitPosition;
			}
			set
			{
				if (_exitPosition == value)
				{
					return;
				}
				_exitPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("exitProbability")] 
		public CFloat ExitProbability
		{
			get
			{
				if (_exitProbability == null)
				{
					_exitProbability = (CFloat) CR2WTypeManager.Create("Float", "exitProbability", cr2w, this);
				}
				return _exitProbability;
			}
			set
			{
				if (_exitProbability == value)
				{
					return;
				}
				_exitProbability = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("endConnection")] 
		public CBool EndConnection
		{
			get
			{
				if (_endConnection == null)
				{
					_endConnection = (CBool) CR2WTypeManager.Create("Bool", "endConnection", cr2w, this);
				}
				return _endConnection;
			}
			set
			{
				if (_endConnection == value)
				{
					return;
				}
				_endConnection = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("thisLaneReversed")] 
		public CBool ThisLaneReversed
		{
			get
			{
				if (_thisLaneReversed == null)
				{
					_thisLaneReversed = (CBool) CR2WTypeManager.Create("Bool", "thisLaneReversed", cr2w, this);
				}
				return _thisLaneReversed;
			}
			set
			{
				if (_thisLaneReversed == value)
				{
					return;
				}
				_thisLaneReversed = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("outLaneReversed")] 
		public CBool OutLaneReversed
		{
			get
			{
				if (_outLaneReversed == null)
				{
					_outLaneReversed = (CBool) CR2WTypeManager.Create("Bool", "outLaneReversed", cr2w, this);
				}
				return _outLaneReversed;
			}
			set
			{
				if (_outLaneReversed == value)
				{
					return;
				}
				_outLaneReversed = value;
				PropertySet(this);
			}
		}

		public worldTrafficLaneExitDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
