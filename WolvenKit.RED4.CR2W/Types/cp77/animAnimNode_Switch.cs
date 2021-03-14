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
			get
			{
				if (_numInputs == null)
				{
					_numInputs = (CUInt32) CR2WTypeManager.Create("Uint32", "numInputs", cr2w, this);
				}
				return _numInputs;
			}
			set
			{
				if (_numInputs == value)
				{
					return;
				}
				_numInputs = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("blendTime")] 
		public CFloat BlendTime
		{
			get
			{
				if (_blendTime == null)
				{
					_blendTime = (CFloat) CR2WTypeManager.Create("Float", "blendTime", cr2w, this);
				}
				return _blendTime;
			}
			set
			{
				if (_blendTime == value)
				{
					return;
				}
				_blendTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
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

		[Ordinal(14)] 
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

		[Ordinal(15)] 
		[RED("motionProvider")] 
		public CHandle<animIMotionTableProvider> MotionProvider
		{
			get
			{
				if (_motionProvider == null)
				{
					_motionProvider = (CHandle<animIMotionTableProvider>) CR2WTypeManager.Create("handle:animIMotionTableProvider", "motionProvider", cr2w, this);
				}
				return _motionProvider;
			}
			set
			{
				if (_motionProvider == value)
				{
					return;
				}
				_motionProvider = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
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

		[Ordinal(17)] 
		[RED("inputNodes")] 
		public CArray<animPoseLink> InputNodes
		{
			get
			{
				if (_inputNodes == null)
				{
					_inputNodes = (CArray<animPoseLink>) CR2WTypeManager.Create("array:animPoseLink", "inputNodes", cr2w, this);
				}
				return _inputNodes;
			}
			set
			{
				if (_inputNodes == value)
				{
					return;
				}
				_inputNodes = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("pushDataByTag")] 
		public CName PushDataByTag
		{
			get
			{
				if (_pushDataByTag == null)
				{
					_pushDataByTag = (CName) CR2WTypeManager.Create("CName", "pushDataByTag", cr2w, this);
				}
				return _pushDataByTag;
			}
			set
			{
				if (_pushDataByTag == value)
				{
					return;
				}
				_pushDataByTag = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("canRequestInertialization")] 
		public CBool CanRequestInertialization
		{
			get
			{
				if (_canRequestInertialization == null)
				{
					_canRequestInertialization = (CBool) CR2WTypeManager.Create("Bool", "canRequestInertialization", cr2w, this);
				}
				return _canRequestInertialization;
			}
			set
			{
				if (_canRequestInertialization == value)
				{
					return;
				}
				_canRequestInertialization = value;
				PropertySet(this);
			}
		}

		public animAnimNode_Switch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
