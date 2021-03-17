using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SetDrivenKey_InternalsSetDrivenKeyEntryProviderInline : animAnimNode_SetDrivenKey_InternalsISetDrivenKeyEntryProvider
	{
		private CArray<animAnimNode_SetDrivenKey_InternalsEntry> _entries;

		[Ordinal(0)] 
		[RED("entries")] 
		public CArray<animAnimNode_SetDrivenKey_InternalsEntry> Entries
		{
			get => GetProperty(ref _entries);
			set => SetProperty(ref _entries, value);
		}

		public animAnimNode_SetDrivenKey_InternalsSetDrivenKeyEntryProviderInline(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
