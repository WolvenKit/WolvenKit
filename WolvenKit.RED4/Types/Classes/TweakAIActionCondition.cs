using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TweakAIActionCondition : TweakAIActionConditionAbstract
	{
		[Ordinal(2)] 
		[RED("record")] 
		public TweakDBID Record
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public TweakAIActionCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
