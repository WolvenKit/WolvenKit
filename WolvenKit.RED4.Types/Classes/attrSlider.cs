using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class attrSlider : attrAttribute
	{
		[Ordinal(0)] 
		[RED("ep")] 
		public CFloat Ep
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
