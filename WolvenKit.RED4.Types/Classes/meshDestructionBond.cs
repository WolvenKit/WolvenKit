using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class meshDestructionBond : RedBaseClass
	{
		private CUInt16 _bondIndex;
		private CUInt8 _bondHealth;

		[Ordinal(0)] 
		[RED("bondIndex")] 
		public CUInt16 BondIndex
		{
			get => GetProperty(ref _bondIndex);
			set => SetProperty(ref _bondIndex, value);
		}

		[Ordinal(1)] 
		[RED("bondHealth")] 
		public CUInt8 BondHealth
		{
			get => GetProperty(ref _bondHealth);
			set => SetProperty(ref _bondHealth, value);
		}
	}
}
