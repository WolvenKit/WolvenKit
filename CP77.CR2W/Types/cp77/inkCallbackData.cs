using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkCallbackData : IScriptable
	{
		[Ordinal(0)]  [RED("errorMsg")] public CString ErrorMsg { get; set; }
		[Ordinal(1)]  [RED("iconSrc")] public TweakDBID IconSrc { get; set; }
		[Ordinal(2)]  [RED("loadResult")] public CEnum<inkIconResult> LoadResult { get; set; }
		[Ordinal(3)]  [RED("targetWidget")] public CHandle<inkImageWidget> TargetWidget { get; set; }

		public inkCallbackData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
