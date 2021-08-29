using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ForceVisionApperanceEvent : redEvent
	{
		private CHandle<FocusForcedHighlightData> _forcedHighlight;
		private CBool _apply;
		private CBool _forceCancel;
		private CBool _ignoreStackEvaluation;
		private CHandle<IScriptable> _responseData;

		[Ordinal(0)] 
		[RED("forcedHighlight")] 
		public CHandle<FocusForcedHighlightData> ForcedHighlight
		{
			get => GetProperty(ref _forcedHighlight);
			set => SetProperty(ref _forcedHighlight, value);
		}

		[Ordinal(1)] 
		[RED("apply")] 
		public CBool Apply
		{
			get => GetProperty(ref _apply);
			set => SetProperty(ref _apply, value);
		}

		[Ordinal(2)] 
		[RED("forceCancel")] 
		public CBool ForceCancel
		{
			get => GetProperty(ref _forceCancel);
			set => SetProperty(ref _forceCancel, value);
		}

		[Ordinal(3)] 
		[RED("ignoreStackEvaluation")] 
		public CBool IgnoreStackEvaluation
		{
			get => GetProperty(ref _ignoreStackEvaluation);
			set => SetProperty(ref _ignoreStackEvaluation, value);
		}

		[Ordinal(4)] 
		[RED("responseData")] 
		public CHandle<IScriptable> ResponseData
		{
			get => GetProperty(ref _responseData);
			set => SetProperty(ref _responseData, value);
		}
	}
}
