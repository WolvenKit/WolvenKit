using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BountyUI : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("issuedBy")] 
		public CString IssuedBy
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("moneyReward")] 
		public CInt32 MoneyReward
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("streetCredReward")] 
		public CInt32 StreetCredReward
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("transgressions")] 
		public CArray<CString> Transgressions
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(4)] 
		[RED("hasAccess")] 
		public CBool HasAccess
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("level")] 
		public CInt32 Level
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public BountyUI()
		{
			Transgressions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
