using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_BlendAdditive : animAnimNode_Base
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
			get
			{
				if (_biasValue == null)
				{
					_biasValue = (CFloat) CR2WTypeManager.Create("Float", "biasValue", cr2w, this);
				}
				return _biasValue;
			}
			set
			{
				if (_biasValue == value)
				{
					return;
				}
				_biasValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("scaleValue")] 
		public CFloat ScaleValue
		{
			get
			{
				if (_scaleValue == null)
				{
					_scaleValue = (CFloat) CR2WTypeManager.Create("Float", "scaleValue", cr2w, this);
				}
				return _scaleValue;
			}
			set
			{
				if (_scaleValue == value)
				{
					return;
				}
				_scaleValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("additiveType")] 
		public CEnum<animEAnimGraphAdditiveType> AdditiveType
		{
			get
			{
				if (_additiveType == null)
				{
					_additiveType = (CEnum<animEAnimGraphAdditiveType>) CR2WTypeManager.Create("animEAnimGraphAdditiveType", "additiveType", cr2w, this);
				}
				return _additiveType;
			}
			set
			{
				if (_additiveType == value)
				{
					return;
				}
				_additiveType = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
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

		[Ordinal(15)] 
		[RED("blendTracks")] 
		public CEnum<animEBlendTracksMode> BlendTracks
		{
			get
			{
				if (_blendTracks == null)
				{
					_blendTracks = (CEnum<animEBlendTracksMode>) CR2WTypeManager.Create("animEBlendTracksMode", "blendTracks", cr2w, this);
				}
				return _blendTracks;
			}
			set
			{
				if (_blendTracks == value)
				{
					return;
				}
				_blendTracks = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
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

		[Ordinal(17)] 
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

		[Ordinal(18)] 
		[RED("addedInputNode")] 
		public animPoseLink AddedInputNode
		{
			get
			{
				if (_addedInputNode == null)
				{
					_addedInputNode = (animPoseLink) CR2WTypeManager.Create("animPoseLink", "addedInputNode", cr2w, this);
				}
				return _addedInputNode;
			}
			set
			{
				if (_addedInputNode == value)
				{
					return;
				}
				_addedInputNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
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

		[Ordinal(20)] 
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

		[Ordinal(21)] 
		[RED("weightPreviousFrameFloatTrack")] 
		public animNamedTrackIndex WeightPreviousFrameFloatTrack
		{
			get
			{
				if (_weightPreviousFrameFloatTrack == null)
				{
					_weightPreviousFrameFloatTrack = (animNamedTrackIndex) CR2WTypeManager.Create("animNamedTrackIndex", "weightPreviousFrameFloatTrack", cr2w, this);
				}
				return _weightPreviousFrameFloatTrack;
			}
			set
			{
				if (_weightPreviousFrameFloatTrack == value)
				{
					return;
				}
				_weightPreviousFrameFloatTrack = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("weightPreviousFrameFloatTrackDefaultValue")] 
		public CFloat WeightPreviousFrameFloatTrackDefaultValue
		{
			get
			{
				if (_weightPreviousFrameFloatTrackDefaultValue == null)
				{
					_weightPreviousFrameFloatTrackDefaultValue = (CFloat) CR2WTypeManager.Create("Float", "weightPreviousFrameFloatTrackDefaultValue", cr2w, this);
				}
				return _weightPreviousFrameFloatTrackDefaultValue;
			}
			set
			{
				if (_weightPreviousFrameFloatTrackDefaultValue == value)
				{
					return;
				}
				_weightPreviousFrameFloatTrackDefaultValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("maskName")] 
		public CName MaskName
		{
			get
			{
				if (_maskName == null)
				{
					_maskName = (CName) CR2WTypeManager.Create("CName", "maskName", cr2w, this);
				}
				return _maskName;
			}
			set
			{
				if (_maskName == value)
				{
					return;
				}
				_maskName = value;
				PropertySet(this);
			}
		}

		public animAnimNode_BlendAdditive(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
