using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MessengerContactSelectedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<MessengerContactType> Type
		{
			get => GetPropertyValue<CEnum<MessengerContactType>>();
			set => SetPropertyValue<CEnum<MessengerContactType>>(value);
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

		public MessengerContactSelectedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
