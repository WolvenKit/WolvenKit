using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class attrSoftMinMax : attrAttribute
	{
		[Ordinal(0)] 
		[RED("n")] 
		public CFloat N
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("x")] 
		public CFloat X
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public attrSoftMinMax()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
