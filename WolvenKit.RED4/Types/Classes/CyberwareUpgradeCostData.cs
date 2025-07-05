using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CyberwareUpgradeCostData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("materialRecordID")] 
		public TweakDBID MaterialRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("materialCount")] 
		public CInt32 MaterialCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("moneyRequired")] 
		public CInt32 MoneyRequired
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public CyberwareUpgradeCostData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
