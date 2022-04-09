using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetTargetHealthEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("healthValueToSet")] 
		public CFloat HealthValueToSet
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public SetTargetHealthEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
