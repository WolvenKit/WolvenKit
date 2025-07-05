using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AICTreeNodeTimeoutDefinition : AICTreeExtendableNodeDefinition
	{
		[Ordinal(1)] 
		[RED("timeout")] 
		public CFloat Timeout
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AICTreeNodeTimeoutDefinition()
		{
			Timeout = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
