using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorTrackPatrolProgressNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		[Ordinal(0)]  [RED("pathParameters")] public CHandle<AIArgumentMapping> PathParameters { get; set; }
		[Ordinal(1)]  [RED("patrolProgress")] public CHandle<AIArgumentMapping> PatrolProgress { get; set; }
		[Ordinal(2)]  [RED("startFromClosestPoint")] public CHandle<AIArgumentMapping> StartFromClosestPoint { get; set; }

		public AIbehaviorTrackPatrolProgressNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
