using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class meshMeshParamDestructionBonds : meshMeshParameter
	{
		private CArray<meshDestructionBond> _bonds;

		[Ordinal(0)] 
		[RED("bonds")] 
		public CArray<meshDestructionBond> Bonds
		{
			get => GetProperty(ref _bonds);
			set => SetProperty(ref _bonds, value);
		}
	}
}
