using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class navgendebugCompactCell : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("cellData")] 
		public CUInt64 CellData
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		public navgendebugCompactCell()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
