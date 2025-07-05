using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class meshDestructionBond : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("bondIndex")] 
		public CUInt16 BondIndex
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(1)] 
		[RED("bondHealth")] 
		public CUInt8 BondHealth
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		public meshDestructionBond()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
