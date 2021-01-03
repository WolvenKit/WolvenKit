using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameJournalPath : IScriptable
	{
		[Ordinal(0)]  [RED("className")] public CName ClassName { get; set; }
		[Ordinal(1)]  [RED("fileEntryIndex")] public CInt32 FileEntryIndex { get; set; }
		[Ordinal(2)]  [RED("realPath")] public CString RealPath { get; set; }

		public gameJournalPath(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
