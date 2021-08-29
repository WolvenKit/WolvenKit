using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkBorderWidget : inkLeafWidget
	{
		private CFloat _thickness;

		[Ordinal(20)] 
		[RED("thickness")] 
		public CFloat Thickness
		{
			get => GetProperty(ref _thickness);
			set => SetProperty(ref _thickness, value);
		}
	}
}
