using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsSetChoicesEvent : redEvent
	{
		private CArray<gameinteractionsChoice> _choices;
		private CName _layer;

		[Ordinal(0)] 
		[RED("choices")] 
		public CArray<gameinteractionsChoice> Choices
		{
			get => GetProperty(ref _choices);
			set => SetProperty(ref _choices, value);
		}

		[Ordinal(1)] 
		[RED("layer")] 
		public CName Layer
		{
			get => GetProperty(ref _layer);
			set => SetProperty(ref _layer, value);
		}
	}
}
