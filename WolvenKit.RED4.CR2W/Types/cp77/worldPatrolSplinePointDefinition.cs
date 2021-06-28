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
			get => GetProperty(ref _pointType);
			set => SetProperty(ref _pointType, value);
		}

		[Ordinal(1)] 
		[RED("node")] 
		public NodeRef Node
		{
			get => GetProperty(ref _node);
			set => SetProperty(ref _node, value);
		}

		[Ordinal(2)] 
		[RED("target")] 
		public gameEntityReference Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		public worldPatrolSplinePointDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
