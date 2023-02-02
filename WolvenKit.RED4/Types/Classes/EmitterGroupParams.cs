using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EmitterGroupParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("group")] 
		public CEnum<EEmitterGroup> Group
		{
			get => GetPropertyValue<CEnum<EEmitterGroup>>();
			set => SetPropertyValue<CEnum<EEmitterGroup>>(value);
		}

		[Ordinal(1)] 
		[RED("emissionScale")] 
		public CFloat EmissionScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("opacityScale")] 
		public CFloat OpacityScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public EmitterGroupParams()
		{
			EmissionScale = 1.000000F;
			OpacityScale = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
