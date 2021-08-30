using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AreaEffectData : IScriptable
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
			get => GetProperty(ref _action);
			set => SetProperty(ref _action, value);
		}

		[Ordinal(1)] 
		[RED("actionRecordID")] 
		public TweakDBID ActionRecordID
		{
			get => GetProperty(ref _actionRecordID);
			set => SetProperty(ref _actionRecordID, value);
		}

		[Ordinal(2)] 
		[RED("areaEffectID")] 
		public CName AreaEffectID
		{
			get => GetProperty(ref _areaEffectID);
			set => SetProperty(ref _areaEffectID, value);
		}

		[Ordinal(3)] 
		[RED("indicatorEffectName")] 
		public CName IndicatorEffectName
		{
			get => GetProperty(ref _indicatorEffectName);
			set => SetProperty(ref _indicatorEffectName, value);
		}

		[Ordinal(4)] 
		[RED("useIndicatorEffect")] 
		public CBool UseIndicatorEffect
		{
			get => GetProperty(ref _useIndicatorEffect);
			set => SetProperty(ref _useIndicatorEffect, value);
		}

		[Ordinal(5)] 
		[RED("indicatorEffectSize")] 
		public CFloat IndicatorEffectSize
		{
			get => GetProperty(ref _indicatorEffectSize);
			set => SetProperty(ref _indicatorEffectSize, value);
		}

		[Ordinal(6)] 
		[RED("stimRange")] 
		public CFloat StimRange
		{
			get => GetProperty(ref _stimRange);
			set => SetProperty(ref _stimRange, value);
		}

		[Ordinal(7)] 
		[RED("stimLifetime")] 
		public CFloat StimLifetime
		{
			get => GetProperty(ref _stimLifetime);
			set => SetProperty(ref _stimLifetime, value);
		}

		[Ordinal(8)] 
		[RED("stimType")] 
		public CEnum<DeviceStimType> StimType
		{
			get => GetProperty(ref _stimType);
			set => SetProperty(ref _stimType, value);
		}

		[Ordinal(9)] 
		[RED("stimSource")] 
		public NodeRef StimSource
		{
			get => GetProperty(ref _stimSource);
			set => SetProperty(ref _stimSource, value);
		}

		[Ordinal(10)] 
		[RED("additionaStimSources")] 
		public CArray<NodeRef> AdditionaStimSources
		{
			get => GetProperty(ref _additionaStimSources);
			set => SetProperty(ref _additionaStimSources, value);
		}

		[Ordinal(11)] 
		[RED("investigateSpot")] 
		public NodeRef InvestigateSpot
		{
			get => GetProperty(ref _investigateSpot);
			set => SetProperty(ref _investigateSpot, value);
		}

		[Ordinal(12)] 
		[RED("investigateController")] 
		public CBool InvestigateController
		{
			get => GetProperty(ref _investigateController);
			set => SetProperty(ref _investigateController, value);
		}

		[Ordinal(13)] 
		[RED("controllerSource")] 
		public NodeRef ControllerSource
		{
			get => GetProperty(ref _controllerSource);
			set => SetProperty(ref _controllerSource, value);
		}

		[Ordinal(14)] 
		[RED("highlightTargets")] 
		public CBool HighlightTargets
		{
			get => GetProperty(ref _highlightTargets);
			set => SetProperty(ref _highlightTargets, value);
		}

		[Ordinal(15)] 
		[RED("highlightType")] 
		public CEnum<EFocusForcedHighlightType> HighlightType
		{
			get => GetProperty(ref _highlightType);
			set => SetProperty(ref _highlightType, value);
		}

		[Ordinal(16)] 
		[RED("outlineType")] 
		public CEnum<EFocusOutlineType> OutlineType
		{
			get => GetProperty(ref _outlineType);
			set => SetProperty(ref _outlineType, value);
		}

		[Ordinal(17)] 
		[RED("highlightPriority")] 
		public CEnum<EPriority> HighlightPriority
		{
			get => GetProperty(ref _highlightPriority);
			set => SetProperty(ref _highlightPriority, value);
		}

		[Ordinal(18)] 
		[RED("effectInstance")] 
		public CHandle<gameEffectInstance> EffectInstance
		{
			get => GetProperty(ref _effectInstance);
			set => SetProperty(ref _effectInstance, value);
		}

		[Ordinal(19)] 
		[RED("gameEffectOverrideName")] 
		public CName GameEffectOverrideName
		{
			get => GetProperty(ref _gameEffectOverrideName);
			set => SetProperty(ref _gameEffectOverrideName, value);
		}

		public AreaEffectData()
		{
			_indicatorEffectName = "focus_10m";
			_indicatorEffectSize = 1.000000F;
			_stimRange = 10.000000F;
			_stimLifetime = 3.000000F;
			_highlightTargets = true;
			_highlightType = new() { Value = Enums.EFocusForcedHighlightType.INVALID };
			_outlineType = new() { Value = Enums.EFocusOutlineType.DISTRACTION };
			_highlightPriority = new() { Value = Enums.EPriority.High };
		}
	}
}
