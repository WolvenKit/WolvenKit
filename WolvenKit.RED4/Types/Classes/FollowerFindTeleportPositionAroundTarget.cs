using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FollowerFindTeleportPositionAroundTarget : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("target")] 
		public CHandle<AIArgumentMapping> Target
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(1)] 
		[RED("outPositionArgument")] 
		public CHandle<AIArgumentMapping> OutPositionArgument
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("lastResultTimestamp")] 
		public CFloat LastResultTimestamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public FollowerFindTeleportPositionAroundTarget()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
