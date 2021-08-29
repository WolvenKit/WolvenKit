using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_SetDrivenKey_InternalsSetDrivenKeyEntryProviderInline : animAnimNode_SetDrivenKey_InternalsISetDrivenKeyEntryProvider
	{
		private CArray<animAnimNode_SetDrivenKey_InternalsEntry> _entries;

		[Ordinal(0)] 
		[RED("entries")] 
		public CArray<animAnimNode_SetDrivenKey_InternalsEntry> Entries
		{
			get => GetProperty(ref _entries);
			set => SetProperty(ref _entries, value);
		}
	}
}
