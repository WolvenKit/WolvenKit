using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TransparencyAnimationButtonView : BaseButtonView
	{
		[Ordinal(2)] [RED("AnimationTime")] public CFloat AnimationTime { get; set; }
		[Ordinal(3)] [RED("HoverTransparency")] public CFloat HoverTransparency { get; set; }
		[Ordinal(4)] [RED("PressTransparency")] public CFloat PressTransparency { get; set; }
		[Ordinal(5)] [RED("DefaultTransparency")] public CFloat DefaultTransparency { get; set; }
		[Ordinal(6)] [RED("DisabledTransparency")] public CFloat DisabledTransparency { get; set; }
		[Ordinal(7)] [RED("AnimationProxies")] public CArray<CHandle<inkanimProxy>> AnimationProxies { get; set; }
		[Ordinal(8)] [RED("Targets")] public CArray<inkWidgetReference> Targets { get; set; }

		public TransparencyAnimationButtonView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
