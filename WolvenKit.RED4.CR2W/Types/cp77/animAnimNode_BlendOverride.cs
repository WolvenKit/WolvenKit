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
			get
			{
				if (_inputNode == null)
				{
					_inputNode = (animPoseLink) CR2WTypeManager.Create("animPoseLink", "inputNode", cr2w, this);
				}
				return _inputNode;
			}
			set
			{
				if (_inputNode == value)
				{
					return;
				}
				_inputNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("overrideInputNode")] 
		public animPoseLink OverrideInputNode
		{
			get
			{
				if (_overrideInputNode == null)
				{
					_overrideInputNode = (animPoseLink) CR2WTypeManager.Create("animPoseLink", "overrideInputNode", cr2w, this);
				}
				return _overrideInputNode;
			}
			set
			{
				if (_overrideInputNode == value)
				{
					return;
				}
				_overrideInputNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("weightNode")] 
		public animFloatLink WeightNode
		{
			get
			{
				if (_weightNode == null)
				{
					_weightNode = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "weightNode", cr2w, this);
				}
				return _weightNode;
			}
			set
			{
				if (_weightNode == value)
				{
					return;
				}
				_weightNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("bones")] 
		public CArray<animOverrideBlendBoneInfo> Bones
		{
			get
			{
				if (_bones == null)
				{
					_bones = (CArray<animOverrideBlendBoneInfo>) CR2WTypeManager.Create("array:animOverrideBlendBoneInfo", "bones", cr2w, this);
				}
				return _bones;
			}
			set
			{
				if (_bones == value)
				{
					return;
				}
				_bones = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("blendAllTracks")] 
		public CBool BlendAllTracks
		{
			get
			{
				if (_blendAllTracks == null)
				{
					_blendAllTracks = (CBool) CR2WTypeManager.Create("Bool", "blendAllTracks", cr2w, this);
				}
				return _blendAllTracks;
			}
			set
			{
				if (_blendAllTracks == value)
				{
					return;
				}
				_blendAllTracks = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("blendTrackMode")] 
		public CEnum<animEBlendTracksMode> BlendTrackMode
		{
			get
			{
				if (_blendTrackMode == null)
				{
					_blendTrackMode = (CEnum<animEBlendTracksMode>) CR2WTypeManager.Create("animEBlendTracksMode", "blendTrackMode", cr2w, this);
				}
				return _blendTrackMode;
			}
			set
			{
				if (_blendTrackMode == value)
				{
					return;
				}
				_blendTrackMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("tracks")] 
		public CArray<animOverrideBlendTrackInfo> Tracks
		{
			get
			{
				if (_tracks == null)
				{
					_tracks = (CArray<animOverrideBlendTrackInfo>) CR2WTypeManager.Create("array:animOverrideBlendTrackInfo", "tracks", cr2w, this);
				}
				return _tracks;
			}
			set
			{
				if (_tracks == value)
				{
					return;
				}
				_tracks = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("getDeltaMotionFromOverride")] 
		public CBool GetDeltaMotionFromOverride
		{
			get
			{
				if (_getDeltaMotionFromOverride == null)
				{
					_getDeltaMotionFromOverride = (CBool) CR2WTypeManager.Create("Bool", "getDeltaMotionFromOverride", cr2w, this);
				}
				return _getDeltaMotionFromOverride;
			}
			set
			{
				if (_getDeltaMotionFromOverride == value)
				{
					return;
				}
				_getDeltaMotionFromOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("timeWarpingEnabled")] 
		public CBool TimeWarpingEnabled
		{
			get
			{
				if (_timeWarpingEnabled == null)
				{
					_timeWarpingEnabled = (CBool) CR2WTypeManager.Create("Bool", "timeWarpingEnabled", cr2w, this);
				}
				return _timeWarpingEnabled;
			}
			set
			{
				if (_timeWarpingEnabled == value)
				{
					return;
				}
				_timeWarpingEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("syncMethod")] 
		public CHandle<animISyncMethod> SyncMethod
		{
			get
			{
				if (_syncMethod == null)
				{
					_syncMethod = (CHandle<animISyncMethod>) CR2WTypeManager.Create("handle:animISyncMethod", "syncMethod", cr2w, this);
				}
				return _syncMethod;
			}
			set
			{
				if (_syncMethod == value)
				{
					return;
				}
				_syncMethod = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("blendMethod")] 
		public CHandle<animIPoseBlendMethod> BlendMethod
		{
			get
			{
				if (_blendMethod == null)
				{
					_blendMethod = (CHandle<animIPoseBlendMethod>) CR2WTypeManager.Create("handle:animIPoseBlendMethod", "blendMethod", cr2w, this);
				}
				return _blendMethod;
			}
			set
			{
				if (_blendMethod == value)
				{
					return;
				}
				_blendMethod = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("postProcess")] 
		public CHandle<animIAnimNode_PostProcess> PostProcess
		{
			get
			{
				if (_postProcess == null)
				{
					_postProcess = (CHandle<animIAnimNode_PostProcess>) CR2WTypeManager.Create("handle:animIAnimNode_PostProcess", "postProcess", cr2w, this);
				}
				return _postProcess;
			}
			set
			{
				if (_postProcess == value)
				{
					return;
				}
				_postProcess = value;
				PropertySet(this);
			}
		}

		public animAnimNode_BlendOverride(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
