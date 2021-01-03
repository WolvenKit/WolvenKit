using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ScreenMessageSelector : inkTweakDBIDSelector
	{
		[Ordinal(0)]  [RED("customNumber")] public CInt32 CustomNumber { get; set; }
		[Ordinal(1)]  [RED("replaceTextWithCustomNumber")] public CBool ReplaceTextWithCustomNumber { get; set; }

		public ScreenMessageSelector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
