using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class meshMeshParamDestructionBonds : meshMeshParameter
	{
		[Ordinal(0)] 
		[RED("bonds")] 
		public CArray<meshDestructionBond> Bonds
		{
			get => GetPropertyValue<CArray<meshDestructionBond>>();
			set => SetPropertyValue<CArray<meshDestructionBond>>(value);
		}

		public meshMeshParamDestructionBonds()
		{
			Bonds = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
