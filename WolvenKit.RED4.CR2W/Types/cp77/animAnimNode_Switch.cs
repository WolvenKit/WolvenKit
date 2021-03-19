using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_Switch : animAnimNode_MotionTableSwitch
	{
		private CUInt32 _numInputs;
		private CFloat _blendTime;
		private CBool _timeWarpingEnabled;
		private CHandle<animISyncMethod> _syncMethod;
		private CHandle<animIMotionTableProvider> _motionProvider;
		private animFloatLink _weightNode;
		private CArray<animPoseLink> _inputNodes;
		private CName _pushDataByTag;
		private CBool _canRequestInertialization;

		[Ordinal(11)] 
		[RED("numInputs")] 
		public CUInt32 NumInputs
		{
			get => GetProperty(ref _numInputs);
			set => SetProperty(ref _numInputs, value);
		}

		[Ordinal(12)] 
		[RED("blendTime")] 
		public CFloat BlendTime
		{
			get => GetProperty(ref _blendTime);
			set => SetProperty(ref _blendTime, value);
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
		[RED("motionProvider")] 
		public CHandle<animIMotionTableProvider> MotionProvider
		{
			get => GetProperty(ref _motionProvider);
			set => SetProperty(ref _motionProvider, value);
		}

		[Ordinal(16)] 
		[RED("weightNode")] 
		public animFloatLink WeightNode
		{
			get => GetProperty(ref _weightNode);
			set => SetProperty(ref _weightNode, value);
		}

		[Ordinal(17)] 
		[RED("inputNodes")] 
		public CArray<animPoseLink> InputNodes
		{
			get => GetProperty(ref _inputNodes);
			set => SetProperty(ref _inputNodes, value);
		}

		[Ordinal(18)] 
		[RED("pushDataByTag")] 
		public CName PushDataByTag
		{
			get => GetProperty(ref _pushDataByTag);
			set => SetProperty(ref _pushDataByTag, value);
		}

		[Ordinal(19)] 
		[RED("canRequestInertialization")] 
		public CBool CanRequestInertialization
		{
			get => GetProperty(ref _canRequestInertialization);
			set => SetProperty(ref _canRequestInertialization, value);
		}

		public animAnimNode_Switch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
