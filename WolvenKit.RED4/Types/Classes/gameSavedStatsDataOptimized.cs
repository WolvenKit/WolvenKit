using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSavedStatsDataOptimized : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("statModifiers")] 
		public CArray<CHandle<gameStatModifierData_Deprecated>> StatModifiers
		{
			get => GetPropertyValue<CArray<CHandle<gameStatModifierData_Deprecated>>>();
			set => SetPropertyValue<CArray<CHandle<gameStatModifierData_Deprecated>>>(value);
		}

		[Ordinal(1)] 
		[RED("bufferSliceIndices")] 
		public CArray<CUInt16> BufferSliceIndices
		{
			get => GetPropertyValue<CArray<CUInt16>>();
			set => SetPropertyValue<CArray<CUInt16>>(value);
		}

		[Ordinal(2)] 
		[RED("inactiveStatsIndices")] 
		public CArray<CUInt16> InactiveStatsIndices
		{
			get => GetPropertyValue<CArray<CUInt16>>();
			set => SetPropertyValue<CArray<CUInt16>>(value);
		}

		[Ordinal(3)] 
		[RED("entityHash")] 
		public CUInt64 EntityHash
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(4)] 
		[RED("seed")] 
		public CUInt32 Seed
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(5)] 
		[RED("recordIDIndex")] 
		public CUInt16 RecordIDIndex
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(6)] 
		[RED("idType")] 
		public CEnum<gameStatIDType> IdType
		{
			get => GetPropertyValue<CEnum<gameStatIDType>>();
			set => SetPropertyValue<CEnum<gameStatIDType>>(value);
		}

		public gameSavedStatsDataOptimized()
		{
			StatModifiers = new();
			BufferSliceIndices = new();
			InactiveStatsIndices = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
