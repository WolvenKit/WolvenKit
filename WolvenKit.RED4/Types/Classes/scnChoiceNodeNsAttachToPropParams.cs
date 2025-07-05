using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnChoiceNodeNsAttachToPropParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("propId")] 
		public scnPropId PropId
		{
			get => GetPropertyValue<scnPropId>();
			set => SetPropertyValue<scnPropId>(value);
		}

		[Ordinal(1)] 
		[RED("visualizerStyle")] 
		public CEnum<scnChoiceNodeNsVisualizerStyle> VisualizerStyle
		{
			get => GetPropertyValue<CEnum<scnChoiceNodeNsVisualizerStyle>>();
			set => SetPropertyValue<CEnum<scnChoiceNodeNsVisualizerStyle>>(value);
		}

		public scnChoiceNodeNsAttachToPropParams()
		{
			PropId = new scnPropId { Id = uint.MaxValue };
			VisualizerStyle = Enums.scnChoiceNodeNsVisualizerStyle.inWorld;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
