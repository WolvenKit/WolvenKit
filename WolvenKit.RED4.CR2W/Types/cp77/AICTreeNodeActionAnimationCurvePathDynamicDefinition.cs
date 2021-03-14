using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeActionAnimationCurvePathDynamicDefinition : AICTreeNodeActionDefinition
	{
		private CName _targetSplineVarName;
		private CName _controlerVarName;
		private CName _startAnimVarName;
		private CName _stopAnimVarName;
		private CFloat _blendTime;
		private CFloat _globalInBlendTime;
		private CFloat _globalOutBlendTime;
		private CBool _turnCharacterToMatchVelocity;
		private CBool _startSnapToTerrain;
		private CBool _mainSnapToTerrain;
		private CBool _stopSnapToTerrain;
		private CFloat _startSnapToTerrainBlendTime;
		private CFloat _stopSnapToTerrainBlendTime;

		[Ordinal(1)] 
		[RED("targetSplineVarName")] 
		public CName TargetSplineVarName
		{
			get
			{
				if (_targetSplineVarName == null)
				{
					_targetSplineVarName = (CName) CR2WTypeManager.Create("CName", "targetSplineVarName", cr2w, this);
				}
				return _targetSplineVarName;
			}
			set
			{
				if (_targetSplineVarName == value)
				{
					return;
				}
				_targetSplineVarName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("controlerVarName")] 
		public CName ControlerVarName
		{
			get
			{
				if (_controlerVarName == null)
				{
					_controlerVarName = (CName) CR2WTypeManager.Create("CName", "controlerVarName", cr2w, this);
				}
				return _controlerVarName;
			}
			set
			{
				if (_controlerVarName == value)
				{
					return;
				}
				_controlerVarName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("startAnimVarName")] 
		public CName StartAnimVarName
		{
			get
			{
				if (_startAnimVarName == null)
				{
					_startAnimVarName = (CName) CR2WTypeManager.Create("CName", "startAnimVarName", cr2w, this);
				}
				return _startAnimVarName;
			}
			set
			{
				if (_startAnimVarName == value)
				{
					return;
				}
				_startAnimVarName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("stopAnimVarName")] 
		public CName StopAnimVarName
		{
			get
			{
				if (_stopAnimVarName == null)
				{
					_stopAnimVarName = (CName) CR2WTypeManager.Create("CName", "stopAnimVarName", cr2w, this);
				}
				return _stopAnimVarName;
			}
			set
			{
				if (_stopAnimVarName == value)
				{
					return;
				}
				_stopAnimVarName = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
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

		[Ordinal(6)] 
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

		[Ordinal(7)] 
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

		[Ordinal(8)] 
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

		[Ordinal(9)] 
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

		[Ordinal(10)] 
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

		[Ordinal(11)] 
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

		[Ordinal(12)] 
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

		[Ordinal(13)] 
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

		public AICTreeNodeActionAnimationCurvePathDynamicDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
