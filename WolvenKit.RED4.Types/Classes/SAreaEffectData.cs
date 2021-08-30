using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SAreaEffectData : RedBaseClass
	{
		private CHandle<ScriptableDeviceAction> _action;
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
		private CEnum<EPriority> _highlightPriority;
		private CHandle<gameEffectInstance> _effectInstance;

		[Ordinal(0)] 
		[RED("action")] 
		public CHandle<ScriptableDeviceAction> Action
		{
			get => GetProperty(ref _action);
			set => SetProperty(ref _action, value);
		}

		[Ordinal(1)] 
		[RED("areaEffectID")] 
		public CName AreaEffectID
		{
			get => GetProperty(ref _areaEffectID);
			set => SetProperty(ref _areaEffectID, value);
		}

		[Ordinal(2)] 
		[RED("indicatorEffectName")] 
		public CName IndicatorEffectName
		{
			get => GetProperty(ref _indicatorEffectName);
			set => SetProperty(ref _indicatorEffectName, value);
		}

		[Ordinal(3)] 
		[RED("useIndicatorEffect")] 
		public CBool UseIndicatorEffect
		{
			get => GetProperty(ref _useIndicatorEffect);
			set => SetProperty(ref _useIndicatorEffect, value);
		}

		[Ordinal(4)] 
		[RED("indicatorEffectSize")] 
		public CFloat IndicatorEffectSize
		{
			get => GetProperty(ref _indicatorEffectSize);
			set => SetProperty(ref _indicatorEffectSize, value);
		}

		[Ordinal(5)] 
		[RED("stimRange")] 
		public CFloat StimRange
		{
			get => GetProperty(ref _stimRange);
			set => SetProperty(ref _stimRange, value);
		}

		[Ordinal(6)] 
		[RED("stimLifetime")] 
		public CFloat StimLifetime
		{
			get => GetProperty(ref _stimLifetime);
			set => SetProperty(ref _stimLifetime, value);
		}

		[Ordinal(7)] 
		[RED("stimType")] 
		public CEnum<DeviceStimType> StimType
		{
			get => GetProperty(ref _stimType);
			set => SetProperty(ref _stimType, value);
		}

		[Ordinal(8)] 
		[RED("stimSource")] 
		public NodeRef StimSource
		{
			get => GetProperty(ref _stimSource);
			set => SetProperty(ref _stimSource, value);
		}

		[Ordinal(9)] 
		[RED("additionaStimSources")] 
		public CArray<NodeRef> AdditionaStimSources
		{
			get => GetProperty(ref _additionaStimSources);
			set => SetProperty(ref _additionaStimSources, value);
		}

		[Ordinal(10)] 
		[RED("investigateSpot")] 
		public NodeRef InvestigateSpot
		{
			get => GetProperty(ref _investigateSpot);
			set => SetProperty(ref _investigateSpot, value);
		}

		[Ordinal(11)] 
		[RED("investigateController")] 
		public CBool InvestigateController
		{
			get => GetProperty(ref _investigateController);
			set => SetProperty(ref _investigateController, value);
		}

		[Ordinal(12)] 
		[RED("controllerSource")] 
		public NodeRef ControllerSource
		{
			get => GetProperty(ref _controllerSource);
			set => SetProperty(ref _controllerSource, value);
		}

		[Ordinal(13)] 
		[RED("highlightTargets")] 
		public CBool HighlightTargets
		{
			get => GetProperty(ref _highlightTargets);
			set => SetProperty(ref _highlightTargets, value);
		}

		[Ordinal(14)] 
		[RED("highlightType")] 
		public CEnum<EFocusForcedHighlightType> HighlightType
		{
			get => GetProperty(ref _highlightType);
			set => SetProperty(ref _highlightType, value);
		}

		[Ordinal(15)] 
		[RED("highlightPriority")] 
		public CEnum<EPriority> HighlightPriority
		{
			get => GetProperty(ref _highlightPriority);
			set => SetProperty(ref _highlightPriority, value);
		}

		[Ordinal(16)] 
		[RED("effectInstance")] 
		public CHandle<gameEffectInstance> EffectInstance
		{
			get => GetProperty(ref _effectInstance);
			set => SetProperty(ref _effectInstance, value);
		}

		public SAreaEffectData()
		{
			_indicatorEffectName = "focus_10m";
			_indicatorEffectSize = 1.000000F;
			_stimRange = 10.000000F;
			_stimLifetime = 3.000000F;
			_highlightTargets = true;
			_highlightType = new() { Value = Enums.EFocusForcedHighlightType.DISTRACTION };
			_highlightPriority = new() { Value = Enums.EPriority.High };
		}
	}
}
