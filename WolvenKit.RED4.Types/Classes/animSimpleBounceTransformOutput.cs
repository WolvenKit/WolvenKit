using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animSimpleBounceTransformOutput : RedBaseClass
	{
		private animTransformIndex _targetTransform;
		private animTransformIndex _parentTransform;
		private CEnum<animTransformChannel> _targetTransformChannel;
		private CFloat _multiplier;
		private CArray<animSimpleBounceTransformOutput_ChannelEntry> _channelEntries;

		[Ordinal(0)] 
		[RED("targetTransform")] 
		public animTransformIndex TargetTransform
		{
			get => GetProperty(ref _targetTransform);
			set => SetProperty(ref _targetTransform, value);
		}

		[Ordinal(1)] 
		[RED("parentTransform")] 
		public animTransformIndex ParentTransform
		{
			get => GetProperty(ref _parentTransform);
			set => SetProperty(ref _parentTransform, value);
		}

		[Ordinal(2)] 
		[RED("targetTransformChannel")] 
		public CEnum<animTransformChannel> TargetTransformChannel
		{
			get => GetProperty(ref _targetTransformChannel);
			set => SetProperty(ref _targetTransformChannel, value);
		}

		[Ordinal(3)] 
		[RED("multiplier")] 
		public CFloat Multiplier
		{
			get => GetProperty(ref _multiplier);
			set => SetProperty(ref _multiplier, value);
		}

		[Ordinal(4)] 
		[RED("channelEntries")] 
		public CArray<animSimpleBounceTransformOutput_ChannelEntry> ChannelEntries
		{
			get => GetProperty(ref _channelEntries);
			set => SetProperty(ref _channelEntries, value);
		}

		public animSimpleBounceTransformOutput()
		{
			_multiplier = 1.000000F;
		}
	}
}
