using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsCSharedDataDefinition : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("defaultChoices")] 
		public CArray<CString> DefaultChoices
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(1)] 
		[RED("visualizer")] 
		public CHandle<gameuiIChoiceVisualizer> Visualizer
		{
			get => GetPropertyValue<CHandle<gameuiIChoiceVisualizer>>();
			set => SetPropertyValue<CHandle<gameuiIChoiceVisualizer>>(value);
		}

		public gameinteractionsCSharedDataDefinition()
		{
			DefaultChoices = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
