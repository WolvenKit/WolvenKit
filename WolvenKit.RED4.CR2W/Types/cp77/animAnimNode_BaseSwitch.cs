using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_BaseSwitch : animAnimNode_Base
	{
		private CFloat _blendTime;
		private CBool _timeWarpingEnabled;
		private CHandle<animISyncMethod> _syncMethod;
		private CArray<animPoseLink> _inputNodes;
		private CBool _canRequestInertialization;

		[Ordinal(11)] 
		[RED("blendTime")] 
		public CFloat BlendTime
		{
			get => GetProperty(ref _blendTime);
			set => SetProperty(ref _blendTime, value);
		}

		[Ordinal(12)] 
		[RED("timeWarpingEnabled")] 
		public CBool TimeWarpingEnabled
		{
			get => GetProperty(ref _timeWarpingEnabled);
			set => SetProperty(ref _timeWarpingEnabled, value);
		}

		[Ordinal(13)] 
		[RED("syncMethod")] 
		public CHandle<animISyncMethod> SyncMethod
		{
			get => GetProperty(ref _syncMethod);
			set => SetProperty(ref _syncMethod, value);
		}

		[Ordinal(14)] 
		[RED("inputNodes")] 
		public CArray<animPoseLink> InputNodes
		{
			get => GetProperty(ref _inputNodes);
			set => SetProperty(ref _inputNodes, value);
		}

		[Ordinal(15)] 
		[RED("canRequestInertialization")] 
		public CBool CanRequestInertialization
		{
			get => GetProperty(ref _canRequestInertialization);
			set => SetProperty(ref _canRequestInertialization, value);
		}

		public animAnimNode_BaseSwitch(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
