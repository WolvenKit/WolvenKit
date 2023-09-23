using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CPOMissionDataState : IScriptable
	{
		[Ordinal(0)] 
		[RED("CPOMissionDataDamagesPreset")] 
		public CName CPOMissionDataDamagesPreset
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("compatibleDeviceName")] 
		public CName CompatibleDeviceName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("ownerDecidesOnTransfer")] 
		public CBool OwnerDecidesOnTransfer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("isChoiceToken")] 
		public CBool IsChoiceToken
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("choiceTokenTimeout")] 
		public CUInt32 ChoiceTokenTimeout
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(5)] 
		[RED("delayedGiveChoiceTokenEventId")] 
		public gameDelayID DelayedGiveChoiceTokenEventId
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(6)] 
		[RED("dataDamageTextLayerId")] 
		public CUInt32 DataDamageTextLayerId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public CPOMissionDataState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
