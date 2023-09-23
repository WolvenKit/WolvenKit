using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RipperdocMeterArmorApplyEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("ArmorData")] 
		public CHandle<RipperdocArmorData> ArmorData
		{
			get => GetPropertyValue<CHandle<RipperdocArmorData>>();
			set => SetPropertyValue<CHandle<RipperdocArmorData>>(value);
		}

		[Ordinal(1)] 
		[RED("IsPurchase")] 
		public CBool IsPurchase
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public RipperdocMeterArmorApplyEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
