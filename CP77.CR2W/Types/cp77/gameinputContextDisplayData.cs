using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameinputContextDisplayData : CVariable
	{
		[Ordinal(0)]  [RED("actions")] public CArray<gameinputActionDisplayData> Actions { get; set; }
		[Ordinal(1)]  [RED("name")] public CName Name { get; set; }

		public gameinputContextDisplayData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
