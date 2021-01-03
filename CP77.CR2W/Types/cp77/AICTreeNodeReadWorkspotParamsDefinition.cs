using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeReadWorkspotParamsDefinition : AICTreeNodeDecoratorDefinition
	{
		[Ordinal(0)]  [RED("animControllerVarName")] public CName AnimControllerVarName { get; set; }
		[Ordinal(1)]  [RED("moveTargetVarName")] public CName MoveTargetVarName { get; set; }
		[Ordinal(2)]  [RED("prevWorkspotNodeVarName")] public CName PrevWorkspotNodeVarName { get; set; }
		[Ordinal(3)]  [RED("splineNodeVarName")] public CName SplineNodeVarName { get; set; }
		[Ordinal(4)]  [RED("splineStartAnimVarName")] public CName SplineStartAnimVarName { get; set; }
		[Ordinal(5)]  [RED("splineStopAnimVarName")] public CName SplineStopAnimVarName { get; set; }
		[Ordinal(6)]  [RED("workspotEntryAnimVar")] public CName WorkspotEntryAnimVar { get; set; }
		[Ordinal(7)]  [RED("workspotNodeVarName")] public CName WorkspotNodeVarName { get; set; }

		public AICTreeNodeReadWorkspotParamsDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
