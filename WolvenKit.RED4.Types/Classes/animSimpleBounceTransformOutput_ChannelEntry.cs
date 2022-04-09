using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animSimpleBounceTransformOutput_ChannelEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("transformChannel")] 
		public CEnum<animTransformChannel> TransformChannel
		{
			get => GetPropertyValue<CEnum<animTransformChannel>>();
			set => SetPropertyValue<CEnum<animTransformChannel>>(value);
		}

		[Ordinal(1)] 
		[RED("multiplier")] 
		public CFloat Multiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animSimpleBounceTransformOutput_ChannelEntry()
		{
			Multiplier = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
