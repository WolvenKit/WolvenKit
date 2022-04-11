using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkBorderWidget : inkLeafWidget
	{
		[Ordinal(20)] 
		[RED("thickness")] 
		public CFloat Thickness
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
