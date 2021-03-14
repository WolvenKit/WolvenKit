using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeActionAnimationCurvePathDefinition : AICTreeNodeActionDefinition
	{
		private LibTreeDefNodeRef _nodeReference;
		private LibTreeDefCName _controllersSetupName;
		private LibTreeDefBool _useStart;
		private LibTreeDefBool _useStop;
		private LibTreeDefFloat _blendTime;
		private LibTreeDefFloat _globalInBlendTime;
		private LibTreeDefFloat _globalOutBlendTime;
		private LibTreeDefBool _turnCharacterToMatchVelocity;
		private LibTreeDefCName _customStartAnimationName;
		private LibTreeDefCName _customMainAnimationName;
		private LibTreeDefCName _customStopAnimationName;
		private LibTreeDefBool _startSnapToTerrain;
		private LibTreeDefBool _mainSnapToTerrain;
		private LibTreeDefBool _stopSnapToTerrain;
		private LibTreeDefFloat _startSnapToTerrainBlendTime;
		private LibTreeDefFloat _stopSnapToTerrainBlendTime;

		[Ordinal(1)] 
		[RED("nodeReference")] 
		public LibTreeDefNodeRef NodeReference
		{
			get
			{
				if (_nodeReference == null)
				{
					_nodeReference = (LibTreeDefNodeRef) CR2WTypeManager.Create("LibTreeDefNodeRef", "nodeReference", cr2w, this);
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
		public LibTreeDefCName ControllersSetupName
		{
			get
			{
				if (_controllersSetupName == null)
				{
					_controllersSetupName = (LibTreeDefCName) CR2WTypeManager.Create("LibTreeDefCName", "controllersSetupName", cr2w, this);
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
		public LibTreeDefBool UseStart
		{
			get
			{
				if (_useStart == null)
				{
					_useStart = (LibTreeDefBool) CR2WTypeManager.Create("LibTreeDefBool", "useStart", cr2w, this);
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
		public LibTreeDefBool UseStop
		{
			get
			{
				if (_useStop == null)
				{
					_useStop = (LibTreeDefBool) CR2WTypeManager.Create("LibTreeDefBool", "useStop", cr2w, this);
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
		public LibTreeDefFloat BlendTime
		{
			get
			{
				if (_blendTime == null)
				{
					_blendTime = (LibTreeDefFloat) CR2WTypeManager.Create("LibTreeDefFloat", "blendTime", cr2w, this);
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
		public LibTreeDefFloat GlobalInBlendTime
		{
			get
			{
				if (_globalInBlendTime == null)
				{
					_globalInBlendTime = (LibTreeDefFloat) CR2WTypeManager.Create("LibTreeDefFloat", "globalInBlendTime", cr2w, this);
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
		public LibTreeDefFloat GlobalOutBlendTime
		{
			get
			{
				if (_globalOutBlendTime == null)
				{
					_globalOutBlendTime = (LibTreeDefFloat) CR2WTypeManager.Create("LibTreeDefFloat", "globalOutBlendTime", cr2w, this);
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
		public LibTreeDefBool TurnCharacterToMatchVelocity
		{
			get
			{
				if (_turnCharacterToMatchVelocity == null)
				{
					_turnCharacterToMatchVelocity = (LibTreeDefBool) CR2WTypeManager.Create("LibTreeDefBool", "turnCharacterToMatchVelocity", cr2w, this);
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
		public LibTreeDefCName CustomStartAnimationName
		{
			get
			{
				if (_customStartAnimationName == null)
				{
					_customStartAnimationName = (LibTreeDefCName) CR2WTypeManager.Create("LibTreeDefCName", "customStartAnimationName", cr2w, this);
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
		public LibTreeDefCName CustomMainAnimationName
		{
			get
			{
				if (_customMainAnimationName == null)
				{
					_customMainAnimationName = (LibTreeDefCName) CR2WTypeManager.Create("LibTreeDefCName", "customMainAnimationName", cr2w, this);
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
		public LibTreeDefCName CustomStopAnimationName
		{
			get
			{
				if (_customStopAnimationName == null)
				{
					_customStopAnimationName = (LibTreeDefCName) CR2WTypeManager.Create("LibTreeDefCName", "customStopAnimationName", cr2w, this);
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
		public LibTreeDefBool StartSnapToTerrain
		{
			get
			{
				if (_startSnapToTerrain == null)
				{
					_startSnapToTerrain = (LibTreeDefBool) CR2WTypeManager.Create("LibTreeDefBool", "startSnapToTerrain", cr2w, this);
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
		public LibTreeDefBool MainSnapToTerrain
		{
			get
			{
				if (_mainSnapToTerrain == null)
				{
					_mainSnapToTerrain = (LibTreeDefBool) CR2WTypeManager.Create("LibTreeDefBool", "mainSnapToTerrain", cr2w, this);
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
		public LibTreeDefBool StopSnapToTerrain
		{
			get
			{
				if (_stopSnapToTerrain == null)
				{
					_stopSnapToTerrain = (LibTreeDefBool) CR2WTypeManager.Create("LibTreeDefBool", "stopSnapToTerrain", cr2w, this);
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
		public LibTreeDefFloat StartSnapToTerrainBlendTime
		{
			get
			{
				if (_startSnapToTerrainBlendTime == null)
				{
					_startSnapToTerrainBlendTime = (LibTreeDefFloat) CR2WTypeManager.Create("LibTreeDefFloat", "startSnapToTerrainBlendTime", cr2w, this);
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
		public LibTreeDefFloat StopSnapToTerrainBlendTime
		{
			get
			{
				if (_stopSnapToTerrainBlendTime == null)
				{
					_stopSnapToTerrainBlendTime = (LibTreeDefFloat) CR2WTypeManager.Create("LibTreeDefFloat", "stopSnapToTerrainBlendTime", cr2w, this);
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

		public AICTreeNodeActionAnimationCurvePathDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
