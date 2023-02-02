using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SAreaEffectData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("action")] 
		public CHandle<ScriptableDeviceAction> Action
		{
			get => GetPropertyValue<CHandle<ScriptableDeviceAction>>();
			set => SetPropertyValue<CHandle<ScriptableDeviceAction>>(value);
		}

		[Ordinal(1)] 
		[RED("areaEffectID")] 
		public CName AreaEffectID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("indicatorEffectName")] 
		public CName IndicatorEffectName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("useIndicatorEffect")] 
		public CBool UseIndicatorEffect
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("indicatorEffectSize")] 
		public CFloat IndicatorEffectSize
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("stimRange")] 
		public CFloat StimRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("stimLifetime")] 
		public CFloat StimLifetime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("stimType")] 
		public CEnum<DeviceStimType> StimType
		{
			get => GetPropertyValue<CEnum<DeviceStimType>>();
			set => SetPropertyValue<CEnum<DeviceStimType>>(value);
		}

		[Ordinal(8)] 
		[RED("stimSource")] 
		public NodeRef StimSource
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(9)] 
		[RED("additionaStimSources")] 
		public CArray<NodeRef> AdditionaStimSources
		{
			get => GetPropertyValue<CArray<NodeRef>>();
			set => SetPropertyValue<CArray<NodeRef>>(value);
		}

		[Ordinal(10)] 
		[RED("investigateSpot")] 
		public NodeRef InvestigateSpot
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(11)] 
		[RED("investigateController")] 
		public CBool InvestigateController
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("controllerSource")] 
		public NodeRef ControllerSource
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(13)] 
		[RED("highlightTargets")] 
		public CBool HighlightTargets
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("highlightType")] 
		public CEnum<EFocusForcedHighlightType> HighlightType
		{
			get => GetPropertyValue<CEnum<EFocusForcedHighlightType>>();
			set => SetPropertyValue<CEnum<EFocusForcedHighlightType>>(value);
		}

		[Ordinal(15)] 
		[RED("highlightPriority")] 
		public CEnum<EPriority> HighlightPriority
		{
			get => GetPropertyValue<CEnum<EPriority>>();
			set => SetPropertyValue<CEnum<EPriority>>(value);
		}

		[Ordinal(16)] 
		[RED("effectInstance")] 
		public CHandle<gameEffectInstance> EffectInstance
		{
			get => GetPropertyValue<CHandle<gameEffectInstance>>();
			set => SetPropertyValue<CHandle<gameEffectInstance>>(value);
		}

		public SAreaEffectData()
		{
			IndicatorEffectName = "focus_10m";
			IndicatorEffectSize = 1.000000F;
			StimRange = 10.000000F;
			StimLifetime = 3.000000F;
			AdditionaStimSources = new();
			HighlightTargets = true;
			HighlightType = Enums.EFocusForcedHighlightType.DISTRACTION;
			HighlightPriority = Enums.EPriority.High;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
