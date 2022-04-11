using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnChoiceNodeNsAttachToGameObjectParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("nodeRef")] 
		public NodeRef NodeRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("visualizerStyle")] 
		public CEnum<scnChoiceNodeNsVisualizerStyle> VisualizerStyle
		{
			get => GetPropertyValue<CEnum<scnChoiceNodeNsVisualizerStyle>>();
			set => SetPropertyValue<CEnum<scnChoiceNodeNsVisualizerStyle>>(value);
		}

		public scnChoiceNodeNsAttachToGameObjectParams()
		{
			VisualizerStyle = Enums.scnChoiceNodeNsVisualizerStyle.inWorld;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
