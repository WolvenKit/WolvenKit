using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloatTrackDirectConnConstraint_ : animAnimNode_OnePoseInput
	{
		private animNamedTrackIndex _floatTrackIndex;
		private animTransformIndex _transformIndex;
		private CEnum<animTransformChannel> _channel;
		private CFloat _mulFactor;
		private CFloat _weight;
		private animFloatLink _weightNode;
		private animFloatLink _mulFactorNode;

		[Ordinal(12)] 
		[RED("floatTrackIndex")] 
		public animNamedTrackIndex FloatTrackIndex
		{
			get => GetProperty(ref _floatTrackIndex);
			set => SetProperty(ref _floatTrackIndex, value);
		}

		[Ordinal(13)] 
		[RED("transformIndex")] 
		public animTransformIndex TransformIndex
		{
			get => GetProperty(ref _transformIndex);
			set => SetProperty(ref _transformIndex, value);
		}

		[Ordinal(14)] 
		[RED("channel")] 
		public CEnum<animTransformChannel> Channel
		{
			get => GetProperty(ref _channel);
			set => SetProperty(ref _channel, value);
		}

		[Ordinal(15)] 
		[RED("mulFactor")] 
		public CFloat MulFactor
		{
			get => GetProperty(ref _mulFactor);
			set => SetProperty(ref _mulFactor, value);
		}

		[Ordinal(16)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetProperty(ref _weight);
			set => SetProperty(ref _weight, value);
		}

		[Ordinal(17)] 
		[RED("weightNode")] 
		public animFloatLink WeightNode
		{
			get => GetProperty(ref _weightNode);
			set => SetProperty(ref _weightNode, value);
		}

		[Ordinal(18)] 
		[RED("mulFactorNode")] 
		public animFloatLink MulFactorNode
		{
			get => GetProperty(ref _mulFactorNode);
			set => SetProperty(ref _mulFactorNode, value);
		}

		public animAnimNode_FloatTrackDirectConnConstraint_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
