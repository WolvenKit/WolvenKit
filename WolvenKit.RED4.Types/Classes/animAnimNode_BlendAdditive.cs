using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_BlendAdditive : animAnimNode_Base
	{
		private CFloat _biasValue;
		private CFloat _scaleValue;
		private CEnum<animEAnimGraphAdditiveType> _additiveType;
		private CBool _timeWarpingEnabled;
		private CEnum<animEBlendTracksMode> _blendTracks;
		private CHandle<animISyncMethod> _syncMethod;
		private animPoseLink _inputNode;
		private animPoseLink _addedInputNode;
		private animFloatLink _weightNode;
		private CHandle<animIAnimNode_PostProcess> _postProcess;
		private animNamedTrackIndex _weightPreviousFrameFloatTrack;
		private CFloat _weightPreviousFrameFloatTrackDefaultValue;
		private CName _maskName;

		[Ordinal(11)] 
		[RED("biasValue")] 
		public CFloat BiasValue
		{
			get => GetProperty(ref _biasValue);
			set => SetProperty(ref _biasValue, value);
		}

		[Ordinal(12)] 
		[RED("scaleValue")] 
		public CFloat ScaleValue
		{
			get => GetProperty(ref _scaleValue);
			set => SetProperty(ref _scaleValue, value);
		}

		[Ordinal(13)] 
		[RED("additiveType")] 
		public CEnum<animEAnimGraphAdditiveType> AdditiveType
		{
			get => GetProperty(ref _additiveType);
			set => SetProperty(ref _additiveType, value);
		}

		[Ordinal(14)] 
		[RED("timeWarpingEnabled")] 
		public CBool TimeWarpingEnabled
		{
			get => GetProperty(ref _timeWarpingEnabled);
			set => SetProperty(ref _timeWarpingEnabled, value);
		}

		[Ordinal(15)] 
		[RED("blendTracks")] 
		public CEnum<animEBlendTracksMode> BlendTracks
		{
			get => GetProperty(ref _blendTracks);
			set => SetProperty(ref _blendTracks, value);
		}

		[Ordinal(16)] 
		[RED("syncMethod")] 
		public CHandle<animISyncMethod> SyncMethod
		{
			get => GetProperty(ref _syncMethod);
			set => SetProperty(ref _syncMethod, value);
		}

		[Ordinal(17)] 
		[RED("inputNode")] 
		public animPoseLink InputNode
		{
			get => GetProperty(ref _inputNode);
			set => SetProperty(ref _inputNode, value);
		}

		[Ordinal(18)] 
		[RED("addedInputNode")] 
		public animPoseLink AddedInputNode
		{
			get => GetProperty(ref _addedInputNode);
			set => SetProperty(ref _addedInputNode, value);
		}

		[Ordinal(19)] 
		[RED("weightNode")] 
		public animFloatLink WeightNode
		{
			get => GetProperty(ref _weightNode);
			set => SetProperty(ref _weightNode, value);
		}

		[Ordinal(20)] 
		[RED("postProcess")] 
		public CHandle<animIAnimNode_PostProcess> PostProcess
		{
			get => GetProperty(ref _postProcess);
			set => SetProperty(ref _postProcess, value);
		}

		[Ordinal(21)] 
		[RED("weightPreviousFrameFloatTrack")] 
		public animNamedTrackIndex WeightPreviousFrameFloatTrack
		{
			get => GetProperty(ref _weightPreviousFrameFloatTrack);
			set => SetProperty(ref _weightPreviousFrameFloatTrack, value);
		}

		[Ordinal(22)] 
		[RED("weightPreviousFrameFloatTrackDefaultValue")] 
		public CFloat WeightPreviousFrameFloatTrackDefaultValue
		{
			get => GetProperty(ref _weightPreviousFrameFloatTrackDefaultValue);
			set => SetProperty(ref _weightPreviousFrameFloatTrackDefaultValue, value);
		}

		[Ordinal(23)] 
		[RED("maskName")] 
		public CName MaskName
		{
			get => GetProperty(ref _maskName);
			set => SetProperty(ref _maskName, value);
		}

		public animAnimNode_BlendAdditive()
		{
			_scaleValue = 1.000000F;
			_blendTracks = new() { Value = Enums.animEBlendTracksMode.AGBT_Add };
		}
	}
}
