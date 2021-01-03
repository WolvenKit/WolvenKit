using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SHighlightTarget : CVariable
	{
		[Ordinal(0)]  [RED("highlightType")] public CEnum<EFocusForcedHighlightType> HighlightType { get; set; }
		[Ordinal(1)]  [RED("targetID")] public entEntityID TargetID { get; set; }

		public SHighlightTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
