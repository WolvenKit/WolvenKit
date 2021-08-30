using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnChoiceNodeNsAttachToPropParams : RedBaseClass
	{
		private scnPropId _propId;
		private CEnum<scnChoiceNodeNsVisualizerStyle> _visualizerStyle;

		[Ordinal(0)] 
		[RED("propId")] 
		public scnPropId PropId
		{
			get => GetProperty(ref _propId);
			set => SetProperty(ref _propId, value);
		}

		[Ordinal(1)] 
		[RED("visualizerStyle")] 
		public CEnum<scnChoiceNodeNsVisualizerStyle> VisualizerStyle
		{
			get => GetProperty(ref _visualizerStyle);
			set => SetProperty(ref _visualizerStyle, value);
		}

		public scnChoiceNodeNsAttachToPropParams()
		{
			_visualizerStyle = new() { Value = Enums.scnChoiceNodeNsVisualizerStyle.inWorld };
		}
	}
}
