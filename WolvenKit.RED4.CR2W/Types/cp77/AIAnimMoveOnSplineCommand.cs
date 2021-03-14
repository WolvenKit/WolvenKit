using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIAnimMoveOnSplineCommand : AIMoveCommand
	{
		private NodeRef _spline;
		private CBool _useStart;
		private CBool _useStop;
		private CName _controllerSetupName;
		private CFloat _blendTime;
		private CFloat _globalInBlendTime;
		private CFloat _globalOutBlendTime;
		private CBool _turnCharacterToMatchVelocity;
		private CName _customStartAnimationName;
		private CName _customMainAnimationName;
		private CName _customStopAnimationName;
		private CBool _startSnapToTerrain;
		private CBool _mainSnapToTerrain;
		private CBool _stopSnapToTerrain;
		private CFloat _startSnapToTerrainBlendTime;
		private CFloat _stopSnapToTerrainBlendTime;

		[Ordinal(7)] 
		[RED("spline")] 
		public NodeRef Spline
		{
			get
			{
				if (_spline == null)
				{
					_spline = (NodeRef) CR2WTypeManager.Create("NodeRef", "spline", cr2w, this);
				}
				return _spline;
			}
			set
			{
				if (_spline == value)
				{
					return;
				}
				_spline = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("useStart")] 
		public CBool UseStart
		{
			get
			{
				if (_useStart == null)
				{
					_useStart = (CBool) CR2WTypeManager.Create("Bool", "useStart", cr2w, this);
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

		[Ordinal(9)] 
		[RED("useStop")] 
		public CBool UseStop
		{
			get
			{
				if (_useStop == null)
				{
					_useStop = (CBool) CR2WTypeManager.Create("Bool", "useStop", cr2w, this);
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

		[Ordinal(10)] 
		[RED("controllerSetupName")] 
		public CName ControllerSetupName
		{
			get
			{
				if (_controllerSetupName == null)
				{
					_controllerSetupName = (CName) CR2WTypeManager.Create("CName", "controllerSetupName", cr2w, this);
				}
				return _controllerSetupName;
			}
			set
			{
				if (_controllerSetupName == value)
				{
					return;
				}
				_controllerSetupName = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
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

		[Ordinal(12)] 
		[RED("globalInBlendTime")] 
		public CFloat GlobalInBlendTime
		{
			get
			{
				if (_globalInBlendTime == null)
				{
					_globalInBlendTime = (CFloat) CR2WTypeManager.Create("Float", "globalInBlendTime", cr2w, this);
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

		[Ordinal(13)] 
		[RED("globalOutBlendTime")] 
		public CFloat GlobalOutBlendTime
		{
			get
			{
				if (_globalOutBlendTime == null)
				{
					_globalOutBlendTime = (CFloat) CR2WTypeManager.Create("Float", "globalOutBlendTime", cr2w, this);
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

		[Ordinal(14)] 
		[RED("turnCharacterToMatchVelocity")] 
		public CBool TurnCharacterToMatchVelocity
		{
			get
			{
				if (_turnCharacterToMatchVelocity == null)
				{
					_turnCharacterToMatchVelocity = (CBool) CR2WTypeManager.Create("Bool", "turnCharacterToMatchVelocity", cr2w, this);
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

		[Ordinal(15)] 
		[RED("customStartAnimationName")] 
		public CName CustomStartAnimationName
		{
			get
			{
				if (_customStartAnimationName == null)
				{
					_customStartAnimationName = (CName) CR2WTypeManager.Create("CName", "customStartAnimationName", cr2w, this);
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

		[Ordinal(16)] 
		[RED("customMainAnimationName")] 
		public CName CustomMainAnimationName
		{
			get
			{
				if (_customMainAnimationName == null)
				{
					_customMainAnimationName = (CName) CR2WTypeManager.Create("CName", "customMainAnimationName", cr2w, this);
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

		[Ordinal(17)] 
		[RED("customStopAnimationName")] 
		public CName CustomStopAnimationName
		{
			get
			{
				if (_customStopAnimationName == null)
				{
					_customStopAnimationName = (CName) CR2WTypeManager.Create("CName", "customStopAnimationName", cr2w, this);
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

		[Ordinal(18)] 
		[RED("startSnapToTerrain")] 
		public CBool StartSnapToTerrain
		{
			get
			{
				if (_startSnapToTerrain == null)
				{
					_startSnapToTerrain = (CBool) CR2WTypeManager.Create("Bool", "startSnapToTerrain", cr2w, this);
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

		[Ordinal(19)] 
		[RED("mainSnapToTerrain")] 
		public CBool MainSnapToTerrain
		{
			get
			{
				if (_mainSnapToTerrain == null)
				{
					_mainSnapToTerrain = (CBool) CR2WTypeManager.Create("Bool", "mainSnapToTerrain", cr2w, this);
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

		[Ordinal(20)] 
		[RED("stopSnapToTerrain")] 
		public CBool StopSnapToTerrain
		{
			get
			{
				if (_stopSnapToTerrain == null)
				{
					_stopSnapToTerrain = (CBool) CR2WTypeManager.Create("Bool", "stopSnapToTerrain", cr2w, this);
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

		[Ordinal(21)] 
		[RED("startSnapToTerrainBlendTime")] 
		public CFloat StartSnapToTerrainBlendTime
		{
			get
			{
				if (_startSnapToTerrainBlendTime == null)
				{
					_startSnapToTerrainBlendTime = (CFloat) CR2WTypeManager.Create("Float", "startSnapToTerrainBlendTime", cr2w, this);
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

		[Ordinal(22)] 
		[RED("stopSnapToTerrainBlendTime")] 
		public CFloat StopSnapToTerrainBlendTime
		{
			get
			{
				if (_stopSnapToTerrainBlendTime == null)
				{
					_stopSnapToTerrainBlendTime = (CFloat) CR2WTypeManager.Create("Float", "stopSnapToTerrainBlendTime", cr2w, this);
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

		public AIAnimMoveOnSplineCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
