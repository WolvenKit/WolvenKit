using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ForceVisionApperanceEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("forcedHighlight")] 
		public CHandle<FocusForcedHighlightData> ForcedHighlight
		{
			get => GetPropertyValue<CHandle<FocusForcedHighlightData>>();
			set => SetPropertyValue<CHandle<FocusForcedHighlightData>>(value);
		}

		[Ordinal(1)] 
		[RED("apply")] 
		public CBool Apply
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("forceCancel")] 
		public CBool ForceCancel
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("ignoreStackEvaluation")] 
		public CBool IgnoreStackEvaluation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("responseData")] 
		public CHandle<IScriptable> ResponseData
		{
			get => GetPropertyValue<CHandle<IScriptable>>();
			set => SetPropertyValue<CHandle<IScriptable>>(value);
		}

		public ForceVisionApperanceEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
