using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class HitHistory : IScriptable
	{
		[Ordinal(0)]  [RED("hitHistory")] public CArray<HitHistoryItem> M_HitHistory { get; set; }
		[Ordinal(1)]  [RED("maxEntries")] public CInt32 MaxEntries { get; set; }

		public HitHistory(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
