using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animSimpleBounceTransformOutput : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("targetTransform")] 
		public animTransformIndex TargetTransform
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(1)] 
		[RED("parentTransform")] 
		public animTransformIndex ParentTransform
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(2)] 
		[RED("targetTransformChannel")] 
		public CEnum<animTransformChannel> TargetTransformChannel
		{
			get => GetPropertyValue<CEnum<animTransformChannel>>();
			set => SetPropertyValue<CEnum<animTransformChannel>>(value);
		}

		[Ordinal(3)] 
		[RED("multiplier")] 
		public CFloat Multiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("channelEntries")] 
		public CArray<animSimpleBounceTransformOutput_ChannelEntry> ChannelEntries
		{
			get => GetPropertyValue<CArray<animSimpleBounceTransformOutput_ChannelEntry>>();
			set => SetPropertyValue<CArray<animSimpleBounceTransformOutput_ChannelEntry>>(value);
		}

		public animSimpleBounceTransformOutput()
		{
			TargetTransform = new();
			ParentTransform = new();
			Multiplier = 1.000000F;
			ChannelEntries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
