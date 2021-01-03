using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SetDrivenKey_InternalsSetDrivenKeyEntryProviderInline : animAnimNode_SetDrivenKey_InternalsISetDrivenKeyEntryProvider
	{
		[Ordinal(0)]  [RED("entries")] public CArray<animAnimNode_SetDrivenKey_InternalsEntry> Entries { get; set; }

		public animAnimNode_SetDrivenKey_InternalsSetDrivenKeyEntryProviderInline(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
