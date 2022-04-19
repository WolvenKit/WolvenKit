using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamehitRepresentationEventsToggleHitShapeEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("hitShapeName")] 
		public CName HitShapeName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("hierarchical")] 
		public CBool Hierarchical
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gamehitRepresentationEventsToggleHitShapeEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
