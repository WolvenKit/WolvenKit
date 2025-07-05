using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ExpansionErrorPopuppData : inkGameNotificationData
	{
		[Ordinal(7)] 
		[RED("title")] 
		public CName Title
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("description")] 
		public CName Description
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("errorCode")] 
		public CUInt32 ErrorCode
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public ExpansionErrorPopuppData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
