using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_TransformToTrack : animAnimNode_OnePoseInput
	{
		private CInt32 _floatTrack;
		private animNamedTrackIndex _floatTrackIndex;
		private CInt16 _outputTransform;
		private animTransformIndex _transformIndex;
		private CEnum<animTransformChannel> _channel;
		private CFloat _mulFactor;
		private CFloat _weight;
		private animFloatLink _weightNode;
		private animFloatLink _mulFactorNode;

		[Ordinal(12)] 
		[RED("floatTrack")] 
		public CInt32 FloatTrack
		{
			get => GetProperty(ref _floatTrack);
			set => SetProperty(ref _floatTrack, value);
		}

		[Ordinal(13)] 
		[RED("floatTrackIndex")] 
		public animNamedTrackIndex FloatTrackIndex
		{
			get => GetProperty(ref _floatTrackIndex);
			set => SetProperty(ref _floatTrackIndex, value);
		}

		[Ordinal(14)] 
		[RED("outputTransform")] 
		public CInt16 OutputTransform
		{
			get => GetProperty(ref _outputTransform);
			set => SetProperty(ref _outputTransform, value);
		}

		[Ordinal(15)] 
		[RED("transformIndex")] 
		public animTransformIndex TransformIndex
		{
			get => GetProperty(ref _transformIndex);
			set => SetProperty(ref _transformIndex, value);
		}

		[Ordinal(16)] 
		[RED("channel")] 
		public CEnum<animTransformChannel> Channel
		{
			get => GetProperty(ref _channel);
			set => SetProperty(ref _channel, value);
		}

		[Ordinal(17)] 
		[RED("mulFactor")] 
		public CFloat MulFactor
		{
			get => GetProperty(ref _mulFactor);
			set => SetProperty(ref _mulFactor, value);
		}

		[Ordinal(18)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetProperty(ref _weight);
			set => SetProperty(ref _weight, value);
		}

		[Ordinal(19)] 
		[RED("weightNode")] 
		public animFloatLink WeightNode
		{
			get => GetProperty(ref _weightNode);
			set => SetProperty(ref _weightNode, value);
		}

		[Ordinal(20)] 
		[RED("mulFactorNode")] 
		public animFloatLink MulFactorNode
		{
			get => GetProperty(ref _mulFactorNode);
			set => SetProperty(ref _mulFactorNode, value);
		}
	}
}
