using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TargetIndicatorEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("targetID")] 
		public entEntityID TargetID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("indicator")] 
		public CWeakHandle<inkWidget> Indicator
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		public TargetIndicatorEntry()
		{
			TargetID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
