using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeReadWorkspotParamsDefinition : AICTreeNodeDecoratorDefinition
	{
		[Ordinal(1)] [RED("workspotNodeVarName")] public CName WorkspotNodeVarName { get; set; }
		[Ordinal(2)] [RED("prevWorkspotNodeVarName")] public CName PrevWorkspotNodeVarName { get; set; }
		[Ordinal(3)] [RED("splineNodeVarName")] public CName SplineNodeVarName { get; set; }
		[Ordinal(4)] [RED("workspotEntryAnimVar")] public CName WorkspotEntryAnimVar { get; set; }
		[Ordinal(5)] [RED("animControllerVarName")] public CName AnimControllerVarName { get; set; }
		[Ordinal(6)] [RED("splineStartAnimVarName")] public CName SplineStartAnimVarName { get; set; }
		[Ordinal(7)] [RED("splineStopAnimVarName")] public CName SplineStopAnimVarName { get; set; }
		[Ordinal(8)] [RED("moveTargetVarName")] public CName MoveTargetVarName { get; set; }

		public AICTreeNodeReadWorkspotParamsDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
