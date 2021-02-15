using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ToggleVisibilityInAnimSystemRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("entityID")] public entEntityID EntityID { get; set; }
		[Ordinal(1)] [RED("isVisible")] public CBool IsVisible { get; set; }
		[Ordinal(2)] [RED("sourceName")] public CName SourceName { get; set; }
		[Ordinal(3)] [RED("transitionTime")] public CFloat TransitionTime { get; set; }
		[Ordinal(4)] [RED("forcedVisibleOnlyInFrustum")] public CBool ForcedVisibleOnlyInFrustum { get; set; }

		public ToggleVisibilityInAnimSystemRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
