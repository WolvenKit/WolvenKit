using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameIMovingPlatformMovementInitData : CVariable
	{
		private CEnum<gameMovingPlatformMovementInitializationType> _initType;
		private CFloat _initValue;
		private NodeRef _startNode;
		private NodeRef _endNode;

		[Ordinal(0)] 
		[RED("initType")] 
		public CEnum<gameMovingPlatformMovementInitializationType> InitType
		{
			get
			{
				if (_initType == null)
				{
					_initType = (CEnum<gameMovingPlatformMovementInitializationType>) CR2WTypeManager.Create("gameMovingPlatformMovementInitializationType", "initType", cr2w, this);
				}
				return _initType;
			}
			set
			{
				if (_initType == value)
				{
					return;
				}
				_initType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("initValue")] 
		public CFloat InitValue
		{
			get
			{
				if (_initValue == null)
				{
					_initValue = (CFloat) CR2WTypeManager.Create("Float", "initValue", cr2w, this);
				}
				return _initValue;
			}
			set
			{
				if (_initValue == value)
				{
					return;
				}
				_initValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("startNode")] 
		public NodeRef StartNode
		{
			get
			{
				if (_startNode == null)
				{
					_startNode = (NodeRef) CR2WTypeManager.Create("NodeRef", "startNode", cr2w, this);
				}
				return _startNode;
			}
			set
			{
				if (_startNode == value)
				{
					return;
				}
				_startNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("endNode")] 
		public NodeRef EndNode
		{
			get
			{
				if (_endNode == null)
				{
					_endNode = (NodeRef) CR2WTypeManager.Create("NodeRef", "endNode", cr2w, this);
				}
				return _endNode;
			}
			set
			{
				if (_endNode == value)
				{
					return;
				}
				_endNode = value;
				PropertySet(this);
			}
		}

		public gameIMovingPlatformMovementInitData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
