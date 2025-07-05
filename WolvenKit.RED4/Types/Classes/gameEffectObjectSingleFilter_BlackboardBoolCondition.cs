using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectObjectSingleFilter_BlackboardBoolCondition : gameEffectObjectSingleFilter
	{
		[Ordinal(0)] 
		[RED("parameter")] 
		public gameEffectInputParameter_Bool Parameter
		{
			get => GetPropertyValue<gameEffectInputParameter_Bool>();
			set => SetPropertyValue<gameEffectInputParameter_Bool>(value);
		}

		[Ordinal(1)] 
		[RED("filter")] 
		public CHandle<gameEffectObjectSingleFilter> Filter
		{
			get => GetPropertyValue<CHandle<gameEffectObjectSingleFilter>>();
			set => SetPropertyValue<CHandle<gameEffectObjectSingleFilter>>(value);
		}

		public gameEffectObjectSingleFilter_BlackboardBoolCondition()
		{
			Parameter = new gameEffectInputParameter_Bool();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
