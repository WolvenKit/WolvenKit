using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ImpactReactionTask : AIHitReactionTask
	{
		[Ordinal(4)] 
		[RED("tweakDBPackage")] 
		public TweakDBID TweakDBPackage
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public ImpactReactionTask()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
