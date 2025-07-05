using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EmitterGroupAreaParams : RedBaseClass
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
		public CLegacySingleChannelCurve<CFloat> EmissionScale
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(2)] 
		[RED("opacityScale")] 
		public CLegacySingleChannelCurve<CFloat> OpacityScale
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		public EmitterGroupAreaParams()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
