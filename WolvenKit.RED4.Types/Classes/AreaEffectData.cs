using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AreaEffectData : IScriptable
	{
		[Ordinal(0)] 
		[RED("action")] 
		public CHandle<ScriptableDeviceAction> Action
		{
			get => GetPropertyValue<CHandle<ScriptableDeviceAction>>();
			set => SetPropertyValue<CHandle<ScriptableDeviceAction>>(value);
		}

		[Ordinal(1)] 
		[RED("actionRecordID")] 
		public TweakDBID ActionRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(2)] 
		[RED("areaEffectID")] 
		public CName AreaEffectID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("indicatorEffectName")] 
		public CName IndicatorEffectName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("useIndicatorEffect")] 
		public CBool UseIndicatorEffect
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("indicatorEffectSize")] 
		public CFloat IndicatorEffectSize
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("stimRange")] 
		public CFloat StimRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("stimLifetime")] 
		public CFloat StimLifetime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("stimType")] 
		public CEnum<DeviceStimType> StimType
		{
			get => GetPropertyValue<CEnum<DeviceStimType>>();
			set => SetPropertyValue<CEnum<DeviceStimType>>(value);
		}

		[Ordinal(9)] 
		[RED("stimSource")] 
		public NodeRef StimSource
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(10)] 
		[RED("additionaStimSources")] 
		public CArray<NodeRef> AdditionaStimSources
		{
			get => GetPropertyValue<CArray<NodeRef>>();
			set => SetPropertyValue<CArray<NodeRef>>(value);
		}

		[Ordinal(11)] 
		[RED("investigateSpot")] 
		public NodeRef InvestigateSpot
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(12)] 
		[RED("investigateController")] 
		public CBool InvestigateController
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("controllerSource")] 
		public NodeRef ControllerSource
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(14)] 
		[RED("highlightTargets")] 
		public CBool HighlightTargets
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("highlightType")] 
		public CEnum<EFocusForcedHighlightType> HighlightType
		{
			get => GetPropertyValue<CEnum<EFocusForcedHighlightType>>();
			set => SetPropertyValue<CEnum<EFocusForcedHighlightType>>(value);
		}

		[Ordinal(16)] 
		[RED("outlineType")] 
		public CEnum<EFocusOutlineType> OutlineType
		{
			get => GetPropertyValue<CEnum<EFocusOutlineType>>();
			set => SetPropertyValue<CEnum<EFocusOutlineType>>(value);
		}

		[Ordinal(17)] 
		[RED("highlightPriority")] 
		public CEnum<EPriority> HighlightPriority
		{
			get => GetPropertyValue<CEnum<EPriority>>();
			set => SetPropertyValue<CEnum<EPriority>>(value);
		}

		[Ordinal(18)] 
		[RED("effectInstance")] 
		public CHandle<gameEffectInstance> EffectInstance
		{
			get => GetPropertyValue<CHandle<gameEffectInstance>>();
			set => SetPropertyValue<CHandle<gameEffectInstance>>(value);
		}

		[Ordinal(19)] 
		[RED("gameEffectOverrideName")] 
		public CName GameEffectOverrideName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public AreaEffectData()
		{
			IndicatorEffectName = "focus_10m";
			IndicatorEffectSize = 1.000000F;
			StimRange = 10.000000F;
			StimLifetime = 3.000000F;
			AdditionaStimSources = new();
			HighlightTargets = true;
			HighlightType = Enums.EFocusForcedHighlightType.INVALID;
			OutlineType = Enums.EFocusOutlineType.DISTRACTION;
			HighlightPriority = Enums.EPriority.High;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
