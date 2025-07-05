using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LibTreeParametersForwarder : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("overrides")] 
		public CArray<CUInt32> Overrides
		{
			get => GetPropertyValue<CArray<CUInt32>>();
			set => SetPropertyValue<CArray<CUInt32>>(value);
		}

		public LibTreeParametersForwarder()
		{
			Overrides = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
