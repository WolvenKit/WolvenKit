using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameCompressedSmartObjectPointProperties : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("propertyId")] 
		public CUInt16 PropertyId
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		public gameCompressedSmartObjectPointProperties()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
