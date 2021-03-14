using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AreaEffectData : IScriptable
	{
		private CHandle<ScriptableDeviceAction> _action;
		private TweakDBID _actionRecordID;
		private CName _areaEffectID;
		private CName _indicatorEffectName;
		private CBool _useIndicatorEffect;
		private CFloat _indicatorEffectSize;
		private CFloat _stimRange;
		private CFloat _stimLifetime;
		private CEnum<DeviceStimType> _stimType;
		private NodeRef _stimSource;
		private CArray<NodeRef> _additionaStimSources;
		private NodeRef _investigateSpot;
		private CBool _investigateController;
		private NodeRef _controllerSource;
		private CBool _highlightTargets;
		private CEnum<EFocusForcedHighlightType> _highlightType;
		private CEnum<EFocusOutlineType> _outlineType;
		private CEnum<EPriority> _highlightPriority;
		private CHandle<gameEffectInstance> _effectInstance;
		private CName _gameEffectOverrideName;

		[Ordinal(0)] 
		[RED("action")] 
		public CHandle<ScriptableDeviceAction> Action
		{
			get
			{
				if (_action == null)
				{
					_action = (CHandle<ScriptableDeviceAction>) CR2WTypeManager.Create("handle:ScriptableDeviceAction", "action", cr2w, this);
				}
				return _action;
			}
			set
			{
				if (_action == value)
				{
					return;
				}
				_action = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("actionRecordID")] 
		public TweakDBID ActionRecordID
		{
			get
			{
				if (_actionRecordID == null)
				{
					_actionRecordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "actionRecordID", cr2w, this);
				}
				return _actionRecordID;
			}
			set
			{
				if (_actionRecordID == value)
				{
					return;
				}
				_actionRecordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("areaEffectID")] 
		public CName AreaEffectID
		{
			get
			{
				if (_areaEffectID == null)
				{
					_areaEffectID = (CName) CR2WTypeManager.Create("CName", "areaEffectID", cr2w, this);
				}
				return _areaEffectID;
			}
			set
			{
				if (_areaEffectID == value)
				{
					return;
				}
				_areaEffectID = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("indicatorEffectName")] 
		public CName IndicatorEffectName
		{
			get
			{
				if (_indicatorEffectName == null)
				{
					_indicatorEffectName = (CName) CR2WTypeManager.Create("CName", "indicatorEffectName", cr2w, this);
				}
				return _indicatorEffectName;
			}
			set
			{
				if (_indicatorEffectName == value)
				{
					return;
				}
				_indicatorEffectName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("useIndicatorEffect")] 
		public CBool UseIndicatorEffect
		{
			get
			{
				if (_useIndicatorEffect == null)
				{
					_useIndicatorEffect = (CBool) CR2WTypeManager.Create("Bool", "useIndicatorEffect", cr2w, this);
				}
				return _useIndicatorEffect;
			}
			set
			{
				if (_useIndicatorEffect == value)
				{
					return;
				}
				_useIndicatorEffect = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("indicatorEffectSize")] 
		public CFloat IndicatorEffectSize
		{
			get
			{
				if (_indicatorEffectSize == null)
				{
					_indicatorEffectSize = (CFloat) CR2WTypeManager.Create("Float", "indicatorEffectSize", cr2w, this);
				}
				return _indicatorEffectSize;
			}
			set
			{
				if (_indicatorEffectSize == value)
				{
					return;
				}
				_indicatorEffectSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("stimRange")] 
		public CFloat StimRange
		{
			get
			{
				if (_stimRange == null)
				{
					_stimRange = (CFloat) CR2WTypeManager.Create("Float", "stimRange", cr2w, this);
				}
				return _stimRange;
			}
			set
			{
				if (_stimRange == value)
				{
					return;
				}
				_stimRange = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("stimLifetime")] 
		public CFloat StimLifetime
		{
			get
			{
				if (_stimLifetime == null)
				{
					_stimLifetime = (CFloat) CR2WTypeManager.Create("Float", "stimLifetime", cr2w, this);
				}
				return _stimLifetime;
			}
			set
			{
				if (_stimLifetime == value)
				{
					return;
				}
				_stimLifetime = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("stimType")] 
		public CEnum<DeviceStimType> StimType
		{
			get
			{
				if (_stimType == null)
				{
					_stimType = (CEnum<DeviceStimType>) CR2WTypeManager.Create("DeviceStimType", "stimType", cr2w, this);
				}
				return _stimType;
			}
			set
			{
				if (_stimType == value)
				{
					return;
				}
				_stimType = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("stimSource")] 
		public NodeRef StimSource
		{
			get
			{
				if (_stimSource == null)
				{
					_stimSource = (NodeRef) CR2WTypeManager.Create("NodeRef", "stimSource", cr2w, this);
				}
				return _stimSource;
			}
			set
			{
				if (_stimSource == value)
				{
					return;
				}
				_stimSource = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("additionaStimSources")] 
		public CArray<NodeRef> AdditionaStimSources
		{
			get
			{
				if (_additionaStimSources == null)
				{
					_additionaStimSources = (CArray<NodeRef>) CR2WTypeManager.Create("array:NodeRef", "additionaStimSources", cr2w, this);
				}
				return _additionaStimSources;
			}
			set
			{
				if (_additionaStimSources == value)
				{
					return;
				}
				_additionaStimSources = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("investigateSpot")] 
		public NodeRef InvestigateSpot
		{
			get
			{
				if (_investigateSpot == null)
				{
					_investigateSpot = (NodeRef) CR2WTypeManager.Create("NodeRef", "investigateSpot", cr2w, this);
				}
				return _investigateSpot;
			}
			set
			{
				if (_investigateSpot == value)
				{
					return;
				}
				_investigateSpot = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("investigateController")] 
		public CBool InvestigateController
		{
			get
			{
				if (_investigateController == null)
				{
					_investigateController = (CBool) CR2WTypeManager.Create("Bool", "investigateController", cr2w, this);
				}
				return _investigateController;
			}
			set
			{
				if (_investigateController == value)
				{
					return;
				}
				_investigateController = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("controllerSource")] 
		public NodeRef ControllerSource
		{
			get
			{
				if (_controllerSource == null)
				{
					_controllerSource = (NodeRef) CR2WTypeManager.Create("NodeRef", "controllerSource", cr2w, this);
				}
				return _controllerSource;
			}
			set
			{
				if (_controllerSource == value)
				{
					return;
				}
				_controllerSource = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("highlightTargets")] 
		public CBool HighlightTargets
		{
			get
			{
				if (_highlightTargets == null)
				{
					_highlightTargets = (CBool) CR2WTypeManager.Create("Bool", "highlightTargets", cr2w, this);
				}
				return _highlightTargets;
			}
			set
			{
				if (_highlightTargets == value)
				{
					return;
				}
				_highlightTargets = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("highlightType")] 
		public CEnum<EFocusForcedHighlightType> HighlightType
		{
			get
			{
				if (_highlightType == null)
				{
					_highlightType = (CEnum<EFocusForcedHighlightType>) CR2WTypeManager.Create("EFocusForcedHighlightType", "highlightType", cr2w, this);
				}
				return _highlightType;
			}
			set
			{
				if (_highlightType == value)
				{
					return;
				}
				_highlightType = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("outlineType")] 
		public CEnum<EFocusOutlineType> OutlineType
		{
			get
			{
				if (_outlineType == null)
				{
					_outlineType = (CEnum<EFocusOutlineType>) CR2WTypeManager.Create("EFocusOutlineType", "outlineType", cr2w, this);
				}
				return _outlineType;
			}
			set
			{
				if (_outlineType == value)
				{
					return;
				}
				_outlineType = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("highlightPriority")] 
		public CEnum<EPriority> HighlightPriority
		{
			get
			{
				if (_highlightPriority == null)
				{
					_highlightPriority = (CEnum<EPriority>) CR2WTypeManager.Create("EPriority", "highlightPriority", cr2w, this);
				}
				return _highlightPriority;
			}
			set
			{
				if (_highlightPriority == value)
				{
					return;
				}
				_highlightPriority = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("effectInstance")] 
		public CHandle<gameEffectInstance> EffectInstance
		{
			get
			{
				if (_effectInstance == null)
				{
					_effectInstance = (CHandle<gameEffectInstance>) CR2WTypeManager.Create("handle:gameEffectInstance", "effectInstance", cr2w, this);
				}
				return _effectInstance;
			}
			set
			{
				if (_effectInstance == value)
				{
					return;
				}
				_effectInstance = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("gameEffectOverrideName")] 
		public CName GameEffectOverrideName
		{
			get
			{
				if (_gameEffectOverrideName == null)
				{
					_gameEffectOverrideName = (CName) CR2WTypeManager.Create("CName", "gameEffectOverrideName", cr2w, this);
				}
				return _gameEffectOverrideName;
			}
			set
			{
				if (_gameEffectOverrideName == value)
				{
					return;
				}
				_gameEffectOverrideName = value;
				PropertySet(this);
			}
		}

		public AreaEffectData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
