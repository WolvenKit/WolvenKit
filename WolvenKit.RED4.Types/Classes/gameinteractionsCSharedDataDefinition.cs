using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsCSharedDataDefinition : RedBaseClass
	{
		private CArray<CString> _defaultChoices;
		private CHandle<gameuiIChoiceVisualizer> _visualizer;

		[Ordinal(0)] 
		[RED("defaultChoices")] 
		public CArray<CString> DefaultChoices
		{
			get => GetProperty(ref _defaultChoices);
			set => SetProperty(ref _defaultChoices, value);
		}

		[Ordinal(1)] 
		[RED("visualizer")] 
		public CHandle<gameuiIChoiceVisualizer> Visualizer
		{
			get => GetProperty(ref _visualizer);
			set => SetProperty(ref _visualizer, value);
		}
	}
}
