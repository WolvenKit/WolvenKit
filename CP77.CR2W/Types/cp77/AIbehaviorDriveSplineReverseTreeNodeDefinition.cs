using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorDriveSplineReverseTreeNodeDefinition : AIbehaviorDriveTreeNodeDefinition
	{
		[Ordinal(0)]  [RED("spline")] public CHandle<AIArgumentMapping> Spline { get; set; }

		public AIbehaviorDriveSplineReverseTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
