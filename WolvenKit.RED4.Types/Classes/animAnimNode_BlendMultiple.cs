using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_BlendMultiple : animAnimNode_Base
	{
		private CArray<CFloat> _inputValues;
		private CArray<CFloat> _sortedInputValues;
		private CFloat _minWeight;
		private CFloat _maxWeight;
		private CBool _radialBlending;
		private CBool _timeWarpingEnabled;
		private CHandle<animISyncMethod> _syncMethod;
		private CHandle<animIMotionTableProvider> _motionProvider;
		private animFloatLink _weightNode;
		private CArray<animPoseLink> _inputNodes;

		[Ordinal(11)] 
		[RED("inputValues")] 
		public CArray<CFloat> InputValues
		{
			get => GetProperty(ref _inputValues);
			set => SetProperty(ref _inputValues, value);
		}

		[Ordinal(12)] 
		[RED("sortedInputValues")] 
		public CArray<CFloat> SortedInputValues
		{
			get => GetProperty(ref _sortedInputValues);
			set => SetProperty(ref _sortedInputValues, value);
		}

		[Ordinal(13)] 
		[RED("minWeight")] 
		public CFloat MinWeight
		{
			get => GetProperty(ref _minWeight);
			set => SetProperty(ref _minWeight, value);
		}

		[Ordinal(14)] 
		[RED("maxWeight")] 
		public CFloat MaxWeight
		{
			get => GetProperty(ref _maxWeight);
			set => SetProperty(ref _maxWeight, value);
		}

		[Ordinal(15)] 
		[RED("radialBlending")] 
		public CBool RadialBlending
		{
			get => GetProperty(ref _radialBlending);
			set => SetProperty(ref _radialBlending, value);
		}

		[Ordinal(16)] 
		[RED("timeWarpingEnabled")] 
		public CBool TimeWarpingEnabled
		{
			get => GetProperty(ref _timeWarpingEnabled);
			set => SetProperty(ref _timeWarpingEnabled, value);
		}

		[Ordinal(17)] 
		[RED("syncMethod")] 
		public CHandle<animISyncMethod> SyncMethod
		{
			get => GetProperty(ref _syncMethod);
			set => SetProperty(ref _syncMethod, value);
		}

		[Ordinal(18)] 
		[RED("motionProvider")] 
		public CHandle<animIMotionTableProvider> MotionProvider
		{
			get => GetProperty(ref _motionProvider);
			set => SetProperty(ref _motionProvider, value);
		}

		[Ordinal(19)] 
		[RED("weightNode")] 
		public animFloatLink WeightNode
		{
			get => GetProperty(ref _weightNode);
			set => SetProperty(ref _weightNode, value);
		}

		[Ordinal(20)] 
		[RED("inputNodes")] 
		public CArray<animPoseLink> InputNodes
		{
			get => GetProperty(ref _inputNodes);
			set => SetProperty(ref _inputNodes, value);
		}
	}
}
