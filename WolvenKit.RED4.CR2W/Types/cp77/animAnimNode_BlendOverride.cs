using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_BlendOverride : animAnimNode_Base
	{
		private animPoseLink _inputNode;
		private animPoseLink _overrideInputNode;
		private animFloatLink _weightNode;
		private CArray<animOverrideBlendBoneInfo> _bones;
		private CBool _blendAllTracks;
		private CEnum<animEBlendTracksMode> _blendTrackMode;
		private CArray<animOverrideBlendTrackInfo> _tracks;
		private CBool _getDeltaMotionFromOverride;
		private CBool _timeWarpingEnabled;
		private CHandle<animISyncMethod> _syncMethod;
		private CHandle<animIPoseBlendMethod> _blendMethod;
		private CHandle<animIAnimNode_PostProcess> _postProcess;

		[Ordinal(11)] 
		[RED("inputNode")] 
		public animPoseLink InputNode
		{
			get => GetProperty(ref _inputNode);
			set => SetProperty(ref _inputNode, value);
		}

		[Ordinal(12)] 
		[RED("overrideInputNode")] 
		public animPoseLink OverrideInputNode
		{
			get => GetProperty(ref _overrideInputNode);
			set => SetProperty(ref _overrideInputNode, value);
		}

		[Ordinal(13)] 
		[RED("weightNode")] 
		public animFloatLink WeightNode
		{
			get => GetProperty(ref _weightNode);
			set => SetProperty(ref _weightNode, value);
		}

		[Ordinal(14)] 
		[RED("bones")] 
		public CArray<animOverrideBlendBoneInfo> Bones
		{
			get => GetProperty(ref _bones);
			set => SetProperty(ref _bones, value);
		}

		[Ordinal(15)] 
		[RED("blendAllTracks")] 
		public CBool BlendAllTracks
		{
			get => GetProperty(ref _blendAllTracks);
			set => SetProperty(ref _blendAllTracks, value);
		}

		[Ordinal(16)] 
		[RED("blendTrackMode")] 
		public CEnum<animEBlendTracksMode> BlendTrackMode
		{
			get => GetProperty(ref _blendTrackMode);
			set => SetProperty(ref _blendTrackMode, value);
		}

		[Ordinal(17)] 
		[RED("tracks")] 
		public CArray<animOverrideBlendTrackInfo> Tracks
		{
			get => GetProperty(ref _tracks);
			set => SetProperty(ref _tracks, value);
		}

		[Ordinal(18)] 
		[RED("getDeltaMotionFromOverride")] 
		public CBool GetDeltaMotionFromOverride
		{
			get => GetProperty(ref _getDeltaMotionFromOverride);
			set => SetProperty(ref _getDeltaMotionFromOverride, value);
		}

		[Ordinal(19)] 
		[RED("timeWarpingEnabled")] 
		public CBool TimeWarpingEnabled
		{
			get => GetProperty(ref _timeWarpingEnabled);
			set => SetProperty(ref _timeWarpingEnabled, value);
		}

		[Ordinal(20)] 
		[RED("syncMethod")] 
		public CHandle<animISyncMethod> SyncMethod
		{
			get => GetProperty(ref _syncMethod);
			set => SetProperty(ref _syncMethod, value);
		}

		[Ordinal(21)] 
		[RED("blendMethod")] 
		public CHandle<animIPoseBlendMethod> BlendMethod
		{
			get => GetProperty(ref _blendMethod);
			set => SetProperty(ref _blendMethod, value);
		}

		[Ordinal(22)] 
		[RED("postProcess")] 
		public CHandle<animIAnimNode_PostProcess> PostProcess
		{
			get => GetProperty(ref _postProcess);
			set => SetProperty(ref _postProcess, value);
		}

		public animAnimNode_BlendOverride(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
