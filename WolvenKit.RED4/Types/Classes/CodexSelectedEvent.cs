using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CodexSelectedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("group")] 
		public CBool Group
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("entryHash")] 
		public CInt32 EntryHash
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("level")] 
		public CInt32 Level
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("data")] 
		public CWeakHandle<CodexEntryData> Data
		{
			get => GetPropertyValue<CWeakHandle<CodexEntryData>>();
			set => SetPropertyValue<CWeakHandle<CodexEntryData>>(value);
		}

		[Ordinal(4)] 
		[RED("activeDataSync")] 
		public CWeakHandle<CodexListSyncData> ActiveDataSync
		{
			get => GetPropertyValue<CWeakHandle<CodexListSyncData>>();
			set => SetPropertyValue<CWeakHandle<CodexListSyncData>>(value);
		}

		public CodexSelectedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
