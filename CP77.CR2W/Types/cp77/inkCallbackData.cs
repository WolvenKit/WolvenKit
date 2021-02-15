using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkCallbackData : IScriptable
	{
		[Ordinal(0)] [RED("loadResult")] public CEnum<inkIconResult> LoadResult { get; set; }
		[Ordinal(1)] [RED("targetWidget")] public CHandle<inkImageWidget> TargetWidget { get; set; }
		[Ordinal(2)] [RED("errorMsg")] public CString ErrorMsg { get; set; }
		[Ordinal(3)] [RED("iconSrc")] public TweakDBID IconSrc { get; set; }

		public inkCallbackData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
