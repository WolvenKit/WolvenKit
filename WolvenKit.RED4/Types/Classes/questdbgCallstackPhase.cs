using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questdbgCallstackPhase : questdbgCallstackBlock
	{
		[Ordinal(2)] 
		[RED("phases")] 
		public CArray<CUInt64> Phases
		{
			get => GetPropertyValue<CArray<CUInt64>>();
			set => SetPropertyValue<CArray<CUInt64>>(value);
		}

		[Ordinal(3)] 
		[RED("blocks")] 
		public CArray<CUInt64> Blocks
		{
			get => GetPropertyValue<CArray<CUInt64>>();
			set => SetPropertyValue<CArray<CUInt64>>(value);
		}

		public questdbgCallstackPhase()
		{
			Phases = new();
			Blocks = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
