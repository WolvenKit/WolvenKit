using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiInkChoiceVisualizer : gameuiIChoiceVisualizer
	{
		private CBool _isDynamic;
		private CEnum<gameuiChoiceListVisualizerType> _type;

		[Ordinal(0)] 
		[RED("isDynamic")] 
		public CBool IsDynamic
		{
			get => GetProperty(ref _isDynamic);
			set => SetProperty(ref _isDynamic, value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<gameuiChoiceListVisualizerType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
