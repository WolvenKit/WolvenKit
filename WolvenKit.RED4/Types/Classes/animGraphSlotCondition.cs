using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animGraphSlotCondition : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("condition")] 
		public CHandle<animIStaticCondition> Condition
		{
			get => GetPropertyValue<CHandle<animIStaticCondition>>();
			set => SetPropertyValue<CHandle<animIStaticCondition>>(value);
		}

		[Ordinal(1)] 
		[RED("graph")] 
		public CResourceReference<animAnimGraph> Graph
		{
			get => GetPropertyValue<CResourceReference<animAnimGraph>>();
			set => SetPropertyValue<CResourceReference<animAnimGraph>>(value);
		}

		public animGraphSlotCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
