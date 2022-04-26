using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CPOMissionDevice : gameObject
	{
		[Ordinal(35)] 
		[RED("compatibleDeviceName")] 
		public CName CompatibleDeviceName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(36)] 
		[RED("blockAfterOperation")] 
		public CBool BlockAfterOperation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(37)] 
		[RED("factToUnblock")] 
		public CName FactToUnblock
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(38)] 
		[RED("isBlocked")] 
		public CBool IsBlocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(39)] 
		[RED("factUnblockCallbackID")] 
		public CUInt32 FactUnblockCallbackID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public CPOMissionDevice()
		{
			BlockAfterOperation = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
