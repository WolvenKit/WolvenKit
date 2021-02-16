using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GameEffectTargetVisualizationData : IScriptable
	{
		[Ordinal(0)] [RED("bucketName")] public CName BucketName { get; set; }
		[Ordinal(1)] [RED("forceHighlightTargets")] public CArray<entEntityID> ForceHighlightTargets { get; set; }

		public GameEffectTargetVisualizationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
