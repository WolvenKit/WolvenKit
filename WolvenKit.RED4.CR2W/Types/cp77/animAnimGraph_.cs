using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimGraph_ : CResource
	{
		private CHandle<animAnimNode_Root> _rootNode;
		private CHandle<animAnimVariableContainer> _variables;
		private CArray<animAnimFeatureEntry> _animFeatures;
		private CFloat _timeDeltaMultiplier;
		private CBool _isPaused;
		private CBool _oneFrameToggle;
		private CBool _hasMixerSlot;
		private CArray<animAnimDatabaseCollectionEntry> _additionalAnimDatabases;
		private CArray<CHandle<animAnimNode_Base>> _nodesToInit;
		private CBool _useLunaticMode;
		private CBool _useAnimCommands;
		private CBool _useAnimCommandsForCrowd;
		private CBool _useAnimStaticCommands;
		private rRef<animRig> _staticCommandsRig;
		private CBool _hackAlwaysSample;

		[Ordinal(1)] 
		[RED("rootNode")] 
		public CHandle<animAnimNode_Root> RootNode
		{
			get
			{
				if (_rootNode == null)
				{
					_rootNode = (CHandle<animAnimNode_Root>) CR2WTypeManager.Create("handle:animAnimNode_Root", "rootNode", cr2w, this);
				}
				return _rootNode;
			}
			set
			{
				if (_rootNode == value)
				{
					return;
				}
				_rootNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("variables")] 
		public CHandle<animAnimVariableContainer> Variables
		{
			get
			{
				if (_variables == null)
				{
					_variables = (CHandle<animAnimVariableContainer>) CR2WTypeManager.Create("handle:animAnimVariableContainer", "variables", cr2w, this);
				}
				return _variables;
			}
			set
			{
				if (_variables == value)
				{
					return;
				}
				_variables = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("animFeatures")] 
		public CArray<animAnimFeatureEntry> AnimFeatures
		{
			get
			{
				if (_animFeatures == null)
				{
					_animFeatures = (CArray<animAnimFeatureEntry>) CR2WTypeManager.Create("array:animAnimFeatureEntry", "animFeatures", cr2w, this);
				}
				return _animFeatures;
			}
			set
			{
				if (_animFeatures == value)
				{
					return;
				}
				_animFeatures = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("timeDeltaMultiplier")] 
		public CFloat TimeDeltaMultiplier
		{
			get
			{
				if (_timeDeltaMultiplier == null)
				{
					_timeDeltaMultiplier = (CFloat) CR2WTypeManager.Create("Float", "timeDeltaMultiplier", cr2w, this);
				}
				return _timeDeltaMultiplier;
			}
			set
			{
				if (_timeDeltaMultiplier == value)
				{
					return;
				}
				_timeDeltaMultiplier = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("isPaused")] 
		public CBool IsPaused
		{
			get
			{
				if (_isPaused == null)
				{
					_isPaused = (CBool) CR2WTypeManager.Create("Bool", "isPaused", cr2w, this);
				}
				return _isPaused;
			}
			set
			{
				if (_isPaused == value)
				{
					return;
				}
				_isPaused = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("oneFrameToggle")] 
		public CBool OneFrameToggle
		{
			get
			{
				if (_oneFrameToggle == null)
				{
					_oneFrameToggle = (CBool) CR2WTypeManager.Create("Bool", "oneFrameToggle", cr2w, this);
				}
				return _oneFrameToggle;
			}
			set
			{
				if (_oneFrameToggle == value)
				{
					return;
				}
				_oneFrameToggle = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("hasMixerSlot")] 
		public CBool HasMixerSlot
		{
			get
			{
				if (_hasMixerSlot == null)
				{
					_hasMixerSlot = (CBool) CR2WTypeManager.Create("Bool", "hasMixerSlot", cr2w, this);
				}
				return _hasMixerSlot;
			}
			set
			{
				if (_hasMixerSlot == value)
				{
					return;
				}
				_hasMixerSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("additionalAnimDatabases")] 
		public CArray<animAnimDatabaseCollectionEntry> AdditionalAnimDatabases
		{
			get
			{
				if (_additionalAnimDatabases == null)
				{
					_additionalAnimDatabases = (CArray<animAnimDatabaseCollectionEntry>) CR2WTypeManager.Create("array:animAnimDatabaseCollectionEntry", "additionalAnimDatabases", cr2w, this);
				}
				return _additionalAnimDatabases;
			}
			set
			{
				if (_additionalAnimDatabases == value)
				{
					return;
				}
				_additionalAnimDatabases = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("nodesToInit")] 
		public CArray<CHandle<animAnimNode_Base>> NodesToInit
		{
			get
			{
				if (_nodesToInit == null)
				{
					_nodesToInit = (CArray<CHandle<animAnimNode_Base>>) CR2WTypeManager.Create("array:handle:animAnimNode_Base", "nodesToInit", cr2w, this);
				}
				return _nodesToInit;
			}
			set
			{
				if (_nodesToInit == value)
				{
					return;
				}
				_nodesToInit = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("useLunaticMode")] 
		public CBool UseLunaticMode
		{
			get
			{
				if (_useLunaticMode == null)
				{
					_useLunaticMode = (CBool) CR2WTypeManager.Create("Bool", "useLunaticMode", cr2w, this);
				}
				return _useLunaticMode;
			}
			set
			{
				if (_useLunaticMode == value)
				{
					return;
				}
				_useLunaticMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("useAnimCommands")] 
		public CBool UseAnimCommands
		{
			get
			{
				if (_useAnimCommands == null)
				{
					_useAnimCommands = (CBool) CR2WTypeManager.Create("Bool", "useAnimCommands", cr2w, this);
				}
				return _useAnimCommands;
			}
			set
			{
				if (_useAnimCommands == value)
				{
					return;
				}
				_useAnimCommands = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("useAnimCommandsForCrowd")] 
		public CBool UseAnimCommandsForCrowd
		{
			get
			{
				if (_useAnimCommandsForCrowd == null)
				{
					_useAnimCommandsForCrowd = (CBool) CR2WTypeManager.Create("Bool", "useAnimCommandsForCrowd", cr2w, this);
				}
				return _useAnimCommandsForCrowd;
			}
			set
			{
				if (_useAnimCommandsForCrowd == value)
				{
					return;
				}
				_useAnimCommandsForCrowd = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("useAnimStaticCommands")] 
		public CBool UseAnimStaticCommands
		{
			get
			{
				if (_useAnimStaticCommands == null)
				{
					_useAnimStaticCommands = (CBool) CR2WTypeManager.Create("Bool", "useAnimStaticCommands", cr2w, this);
				}
				return _useAnimStaticCommands;
			}
			set
			{
				if (_useAnimStaticCommands == value)
				{
					return;
				}
				_useAnimStaticCommands = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("staticCommandsRig")] 
		public rRef<animRig> StaticCommandsRig
		{
			get
			{
				if (_staticCommandsRig == null)
				{
					_staticCommandsRig = (rRef<animRig>) CR2WTypeManager.Create("rRef:animRig", "staticCommandsRig", cr2w, this);
				}
				return _staticCommandsRig;
			}
			set
			{
				if (_staticCommandsRig == value)
				{
					return;
				}
				_staticCommandsRig = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("hackAlwaysSample")] 
		public CBool HackAlwaysSample
		{
			get
			{
				if (_hackAlwaysSample == null)
				{
					_hackAlwaysSample = (CBool) CR2WTypeManager.Create("Bool", "hackAlwaysSample", cr2w, this);
				}
				return _hackAlwaysSample;
			}
			set
			{
				if (_hackAlwaysSample == value)
				{
					return;
				}
				_hackAlwaysSample = value;
				PropertySet(this);
			}
		}

		public animAnimGraph_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
