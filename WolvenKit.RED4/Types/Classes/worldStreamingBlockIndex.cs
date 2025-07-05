using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldStreamingBlockIndex : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("rldGridCell")] 
		public CUInt32 RldGridCell
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("oup")] 
		public CEnum<worldStreamingDataGroup> Oup
		{
			get => GetPropertyValue<CEnum<worldStreamingDataGroup>>();
			set => SetPropertyValue<CEnum<worldStreamingDataGroup>>(value);
		}

		public worldStreamingBlockIndex()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
