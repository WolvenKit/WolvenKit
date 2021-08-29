using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsResetChoicesEvent : redEvent
	{
		private CName _layer;

		[Ordinal(0)] 
		[RED("layer")] 
		public CName Layer
		{
			get => GetProperty(ref _layer);
			set => SetProperty(ref _layer, value);
		}
	}
}
