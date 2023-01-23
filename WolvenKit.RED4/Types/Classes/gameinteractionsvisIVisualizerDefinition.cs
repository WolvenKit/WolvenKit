using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsvisIVisualizerDefinition : ISerializable
	{
		[Ordinal(0)] 
		[RED("flags")] 
		public CEnum<gameinteractionsvisEVisualizerDefinitionFlags> Flags
		{
			get => GetPropertyValue<CEnum<gameinteractionsvisEVisualizerDefinitionFlags>>();
			set => SetPropertyValue<CEnum<gameinteractionsvisEVisualizerDefinitionFlags>>(value);
		}

		public gameinteractionsvisIVisualizerDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
