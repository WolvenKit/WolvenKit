using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldPatrolSplinePointDefinition : ISerializable
	{
		private CEnum<worldPatrolSplinePointTypes> _pointType;
		private NodeRef _node;
		private gameEntityReference _target;

		[Ordinal(0)] 
		[RED("pointType")] 
		public CEnum<worldPatrolSplinePointTypes> PointType
		{
			get
			{
				if (_pointType == null)
				{
					_pointType = (CEnum<worldPatrolSplinePointTypes>) CR2WTypeManager.Create("worldPatrolSplinePointTypes", "pointType", cr2w, this);
				}
				return _pointType;
			}
			set
			{
				if (_pointType == value)
				{
					return;
				}
				_pointType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("node")] 
		public NodeRef Node
		{
			get
			{
				if (_node == null)
				{
					_node = (NodeRef) CR2WTypeManager.Create("NodeRef", "node", cr2w, this);
				}
				return _node;
			}
			set
			{
				if (_node == value)
				{
					return;
				}
				_node = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("target")] 
		public gameEntityReference Target
		{
			get
			{
				if (_target == null)
				{
					_target = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "target", cr2w, this);
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

		public worldPatrolSplinePointDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
