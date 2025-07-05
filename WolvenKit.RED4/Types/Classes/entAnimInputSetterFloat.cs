using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entAnimInputSetterFloat : entAnimInputSetter
	{
		[Ordinal(1)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public entAnimInputSetterFloat()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
