using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StimTargetsEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("targets")] 
		public CArray<StimTargetData> Targets
		{
			get => GetPropertyValue<CArray<StimTargetData>>();
			set => SetPropertyValue<CArray<StimTargetData>>(value);
		}

		[Ordinal(1)] 
		[RED("restore")] 
		public CBool Restore
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public StimTargetsEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
