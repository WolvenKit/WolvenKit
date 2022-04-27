using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_SetDrivenKey_InternalsSetDrivenKeyEntryProviderInline : animAnimNode_SetDrivenKey_InternalsISetDrivenKeyEntryProvider
	{
		[Ordinal(0)] 
		[RED("entries")] 
		public CArray<animAnimNode_SetDrivenKey_InternalsEntry> Entries
		{
			get => GetPropertyValue<CArray<animAnimNode_SetDrivenKey_InternalsEntry>>();
			set => SetPropertyValue<CArray<animAnimNode_SetDrivenKey_InternalsEntry>>(value);
		}

		public animAnimNode_SetDrivenKey_InternalsSetDrivenKeyEntryProviderInline()
		{
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
