using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnChoiceNodeNsAttachToGameObjectParams : RedBaseClass
	{
		private NodeRef _nodeRef;
		private CEnum<scnChoiceNodeNsVisualizerStyle> _visualizerStyle;

		[Ordinal(0)] 
		[RED("nodeRef")] 
		public NodeRef NodeRef
		{
			get => GetProperty(ref _nodeRef);
			set => SetProperty(ref _nodeRef, value);
		}

		[Ordinal(1)] 
		[RED("visualizerStyle")] 
		public CEnum<scnChoiceNodeNsVisualizerStyle> VisualizerStyle
		{
			get => GetProperty(ref _visualizerStyle);
			set => SetProperty(ref _visualizerStyle, value);
		}

		public scnChoiceNodeNsAttachToGameObjectParams()
		{
			_visualizerStyle = new() { Value = Enums.scnChoiceNodeNsVisualizerStyle.inWorld };
		}
	}
}
