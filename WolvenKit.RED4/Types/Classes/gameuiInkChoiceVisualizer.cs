using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiInkChoiceVisualizer : gameuiIChoiceVisualizer
	{
		[Ordinal(0)] 
		[RED("isDynamic")] 
		public CBool IsDynamic
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<gameuiChoiceListVisualizerType> Type
		{
			get => GetPropertyValue<CEnum<gameuiChoiceListVisualizerType>>();
			set => SetPropertyValue<CEnum<gameuiChoiceListVisualizerType>>(value);
		}

		public gameuiInkChoiceVisualizer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
