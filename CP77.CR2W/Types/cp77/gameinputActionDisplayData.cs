using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameinputActionDisplayData : CVariable
	{
		[Ordinal(0)]  [RED("inputDisplayKeyboard")] public CString InputDisplayKeyboard { get; set; }
		[Ordinal(1)]  [RED("inputDisplayPad")] public CString InputDisplayPad { get; set; }
		[Ordinal(2)]  [RED("isHold")] public CBool IsHold { get; set; }
		[Ordinal(3)]  [RED("name")] public CName Name { get; set; }

		public gameinputActionDisplayData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
