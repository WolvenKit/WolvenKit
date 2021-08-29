using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animSimpleBounceTransformOutput_ChannelEntry : RedBaseClass
	{
		private CEnum<animTransformChannel> _transformChannel;
		private CFloat _multiplier;

		[Ordinal(0)] 
		[RED("transformChannel")] 
		public CEnum<animTransformChannel> TransformChannel
		{
			get => GetProperty(ref _transformChannel);
			set => SetProperty(ref _transformChannel, value);
		}

		[Ordinal(1)] 
		[RED("multiplier")] 
		public CFloat Multiplier
		{
			get => GetProperty(ref _multiplier);
			set => SetProperty(ref _multiplier, value);
		}
	}
}
