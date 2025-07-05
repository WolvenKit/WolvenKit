using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PerksItemHoldStart : redEvent
	{
		[Ordinal(0)] 
		[RED("widget")] 
		public CWeakHandle<inkWidget> Widget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(1)] 
		[RED("actionName")] 
		public CHandle<inkActionName> ActionName
		{
			get => GetPropertyValue<CHandle<inkActionName>>();
			set => SetPropertyValue<CHandle<inkActionName>>(value);
		}

		[Ordinal(2)] 
		[RED("perkData")] 
		public CHandle<BasePerkDisplayData> PerkData
		{
			get => GetPropertyValue<CHandle<BasePerkDisplayData>>();
			set => SetPropertyValue<CHandle<BasePerkDisplayData>>(value);
		}

		public PerksItemHoldStart()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
