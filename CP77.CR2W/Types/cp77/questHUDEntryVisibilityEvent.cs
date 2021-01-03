using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questHUDEntryVisibilityEvent : CVariable
	{
		[Ordinal(0)]  [RED("dataEntries")] public CArray<questHUDEntryVisibilityData> DataEntries { get; set; }

		public questHUDEntryVisibilityEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
