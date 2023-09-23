using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TweakAIAction : TweakAIActionAbstract
	{
		[Ordinal(37)] 
		[RED("record")] 
		public TweakDBID Record
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public TweakAIAction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
