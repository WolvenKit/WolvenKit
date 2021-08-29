using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_Blend2 : animAnimNode_Base
	{
		private CFloat _minInputValue;
		private CFloat _maxInputValue;
		private CBool _timeWarpingEnabled;
		private CHandle<animISyncMethod> _syncMethod;
		private animPoseLink _firstInputNode;
		private animPoseLink _secondInputNode;
		private animFloatLink _weightNode;

		[Ordinal(11)] 
		[RED("minInputValue")] 
		public CFloat MinInputValue
		{
			get => GetProperty(ref _minInputValue);
			set => SetProperty(ref _minInputValue, value);
		}

		[Ordinal(12)] 
		[RED("maxInputValue")] 
		public CFloat MaxInputValue
		{
			get => GetProperty(ref _maxInputValue);
			set => SetProperty(ref _maxInputValue, value);
		}

		[Ordinal(13)] 
		[RED("timeWarpingEnabled")] 
		public CBool TimeWarpingEnabled
		{
			get => GetProperty(ref _timeWarpingEnabled);
			set => SetProperty(ref _timeWarpingEnabled, value);
		}

		[Ordinal(14)] 
		[RED("syncMethod")] 
		public CHandle<animISyncMethod> SyncMethod
		{
			get => GetProperty(ref _syncMethod);
			set => SetProperty(ref _syncMethod, value);
		}

		[Ordinal(15)] 
		[RED("firstInputNode")] 
		public animPoseLink FirstInputNode
		{
			get => GetProperty(ref _firstInputNode);
			set => SetProperty(ref _firstInputNode, value);
		}

		[Ordinal(16)] 
		[RED("secondInputNode")] 
		public animPoseLink SecondInputNode
		{
			get => GetProperty(ref _secondInputNode);
			set => SetProperty(ref _secondInputNode, value);
		}

		[Ordinal(17)] 
		[RED("weightNode")] 
		public animFloatLink WeightNode
		{
			get => GetProperty(ref _weightNode);
			set => SetProperty(ref _weightNode, value);
		}
	}
}
