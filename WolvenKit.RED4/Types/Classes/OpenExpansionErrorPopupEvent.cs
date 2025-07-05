using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OpenExpansionErrorPopupEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("title")] 
		public CName Title
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("description")] 
		public CName Description
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("errorCode")] 
		public CUInt32 ErrorCode
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public OpenExpansionErrorPopupEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
