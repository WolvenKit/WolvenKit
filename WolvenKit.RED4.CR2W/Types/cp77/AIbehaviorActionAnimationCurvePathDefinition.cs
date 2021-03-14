using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionAnimationCurvePathDefinition : AIbehaviorActionTreeNodeDefinition
	{
		private CHandle<AIArgumentMapping> _nodeReference;
		private CHandle<AIArgumentMapping> _controllersSetupName;
		private CHandle<AIArgumentMapping> _useStart;
		private CHandle<AIArgumentMapping> _useStop;
		private CHandle<AIArgumentMapping> _blendTime;
		private CHandle<AIArgumentMapping> _globalInBlendTime;
		private CHandle<AIArgumentMapping> _globalOutBlendTime;
		private CHandle<AIArgumentMapping> _turnCharacterToMatchVelocity;
		private CHandle<AIArgumentMapping> _customStartAnimationName;
		private CHandle<AIArgumentMapping> _customMainAnimationName;
		private CHandle<AIArgumentMapping> _customStopAnimationName;
		private CHandle<AIArgumentMapping> _startSnapToTerrain;
		private CHandle<AIArgumentMapping> _mainSnapToTerrain;
		private CHandle<AIArgumentMapping> _stopSnapToTerrain;
		private CHandle<AIArgumentMapping> _startSnapToTerrainBlendTime;
		private CHandle<AIArgumentMapping> _stopSnapToTerrainBlendTime;

		[Ordinal(1)] 
		[RED("nodeReference")] 
		public CHandle<AIArgumentMapping> NodeReference
		{
			get
			{
				if (_nodeReference == null)
				{
					_nodeReference = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "nodeReference", cr2w, this);
				}
				return _nodeReference;
			}
			set
			{
				if (_nodeReference == value)
				{
					return;
				}
				_nodeReference = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("controllersSetupName")] 
		public CHandle<AIArgumentMapping> ControllersSetupName
		{
			get
			{
				if (_controllersSetupName == null)
				{
					_controllersSetupName = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "controllersSetupName", cr2w, this);
				}
				return _controllersSetupName;
			}
			set
			{
				if (_controllersSetupName == value)
				{
					return;
				}
				_controllersSetupName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("useStart")] 
		public CHandle<AIArgumentMapping> UseStart
		{
			get
			{
				if (_useStart == null)
				{
					_useStart = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "useStart", cr2w, this);
				}
				return _useStart;
			}
			set
			{
				if (_useStart == value)
				{
					return;
				}
				_useStart = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("useStop")] 
		public CHandle<AIArgumentMapping> UseStop
		{
			get
			{
				if (_useStop == null)
				{
					_useStop = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "useStop", cr2w, this);
				}
				return _useStop;
			}
			set
			{
				if (_useStop == value)
				{
					return;
				}
				_useStop = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("blendTime")] 
		public CHandle<AIArgumentMapping> BlendTime
		{
			get
			{
				if (_blendTime == null)
				{
					_blendTime = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "blendTime", cr2w, this);
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

		[Ordinal(6)] 
		[RED("globalInBlendTime")] 
		public CHandle<AIArgumentMapping> GlobalInBlendTime
		{
			get
			{
				if (_globalInBlendTime == null)
				{
					_globalInBlendTime = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "globalInBlendTime", cr2w, this);
				}
				return _globalInBlendTime;
			}
			set
			{
				if (_globalInBlendTime == value)
				{
					return;
				}
				_globalInBlendTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("globalOutBlendTime")] 
		public CHandle<AIArgumentMapping> GlobalOutBlendTime
		{
			get
			{
				if (_globalOutBlendTime == null)
				{
					_globalOutBlendTime = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "globalOutBlendTime", cr2w, this);
				}
				return _globalOutBlendTime;
			}
			set
			{
				if (_globalOutBlendTime == value)
				{
					return;
				}
				_globalOutBlendTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("turnCharacterToMatchVelocity")] 
		public CHandle<AIArgumentMapping> TurnCharacterToMatchVelocity
		{
			get
			{
				if (_turnCharacterToMatchVelocity == null)
				{
					_turnCharacterToMatchVelocity = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "turnCharacterToMatchVelocity", cr2w, this);
				}
				return _turnCharacterToMatchVelocity;
			}
			set
			{
				if (_turnCharacterToMatchVelocity == value)
				{
					return;
				}
				_turnCharacterToMatchVelocity = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("customStartAnimationName")] 
		public CHandle<AIArgumentMapping> CustomStartAnimationName
		{
			get
			{
				if (_customStartAnimationName == null)
				{
					_customStartAnimationName = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "customStartAnimationName", cr2w, this);
				}
				return _customStartAnimationName;
			}
			set
			{
				if (_customStartAnimationName == value)
				{
					return;
				}
				_customStartAnimationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("customMainAnimationName")] 
		public CHandle<AIArgumentMapping> CustomMainAnimationName
		{
			get
			{
				if (_customMainAnimationName == null)
				{
					_customMainAnimationName = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "customMainAnimationName", cr2w, this);
				}
				return _customMainAnimationName;
			}
			set
			{
				if (_customMainAnimationName == value)
				{
					return;
				}
				_customMainAnimationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("customStopAnimationName")] 
		public CHandle<AIArgumentMapping> CustomStopAnimationName
		{
			get
			{
				if (_customStopAnimationName == null)
				{
					_customStopAnimationName = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "customStopAnimationName", cr2w, this);
				}
				return _customStopAnimationName;
			}
			set
			{
				if (_customStopAnimationName == value)
				{
					return;
				}
				_customStopAnimationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("startSnapToTerrain")] 
		public CHandle<AIArgumentMapping> StartSnapToTerrain
		{
			get
			{
				if (_startSnapToTerrain == null)
				{
					_startSnapToTerrain = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "startSnapToTerrain", cr2w, this);
				}
				return _startSnapToTerrain;
			}
			set
			{
				if (_startSnapToTerrain == value)
				{
					return;
				}
				_startSnapToTerrain = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("mainSnapToTerrain")] 
		public CHandle<AIArgumentMapping> MainSnapToTerrain
		{
			get
			{
				if (_mainSnapToTerrain == null)
				{
					_mainSnapToTerrain = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "mainSnapToTerrain", cr2w, this);
				}
				return _mainSnapToTerrain;
			}
			set
			{
				if (_mainSnapToTerrain == value)
				{
					return;
				}
				_mainSnapToTerrain = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("stopSnapToTerrain")] 
		public CHandle<AIArgumentMapping> StopSnapToTerrain
		{
			get
			{
				if (_stopSnapToTerrain == null)
				{
					_stopSnapToTerrain = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "stopSnapToTerrain", cr2w, this);
				}
				return _stopSnapToTerrain;
			}
			set
			{
				if (_stopSnapToTerrain == value)
				{
					return;
				}
				_stopSnapToTerrain = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("startSnapToTerrainBlendTime")] 
		public CHandle<AIArgumentMapping> StartSnapToTerrainBlendTime
		{
			get
			{
				if (_startSnapToTerrainBlendTime == null)
				{
					_startSnapToTerrainBlendTime = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "startSnapToTerrainBlendTime", cr2w, this);
				}
				return _startSnapToTerrainBlendTime;
			}
			set
			{
				if (_startSnapToTerrainBlendTime == value)
				{
					return;
				}
				_startSnapToTerrainBlendTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("stopSnapToTerrainBlendTime")] 
		public CHandle<AIArgumentMapping> StopSnapToTerrainBlendTime
		{
			get
			{
				if (_stopSnapToTerrainBlendTime == null)
				{
					_stopSnapToTerrainBlendTime = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "stopSnapToTerrainBlendTime", cr2w, this);
				}
				return _stopSnapToTerrainBlendTime;
			}
			set
			{
				if (_stopSnapToTerrainBlendTime == value)
				{
					return;
				}
				_stopSnapToTerrainBlendTime = value;
				PropertySet(this);
			}
		}

		public AIbehaviorActionAnimationCurvePathDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
