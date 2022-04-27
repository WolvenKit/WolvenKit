using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ShardSelectedEvent : redEvent
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
		public CWeakHandle<ShardEntryData> Data
		{
			get => GetPropertyValue<CWeakHandle<ShardEntryData>>();
			set => SetPropertyValue<CWeakHandle<ShardEntryData>>(value);
		}

		public ShardSelectedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
