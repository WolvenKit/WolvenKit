using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ShowSingleMappinEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public ShowSingleMappinEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
