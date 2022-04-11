using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PatrolSpotAction : TweakAIActionSmartComposite
	{
		[Ordinal(46)] 
		[RED("patrolAction")] 
		public CHandle<AIArgumentMapping> PatrolAction
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public PatrolSpotAction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
