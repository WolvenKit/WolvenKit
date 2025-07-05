using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameBodyTypeData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("rigHash")] 
		public CUInt64 RigHash
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(1)] 
		[RED("animsetHashes")] 
		public CArray<CUInt64> AnimsetHashes
		{
			get => GetPropertyValue<CArray<CUInt64>>();
			set => SetPropertyValue<CArray<CUInt64>>(value);
		}

		[Ordinal(2)] 
		[RED("overrides")] 
		public CArray<gameAnimsetOverrideData> Overrides
		{
			get => GetPropertyValue<CArray<gameAnimsetOverrideData>>();
			set => SetPropertyValue<CArray<gameAnimsetOverrideData>>(value);
		}

		public gameBodyTypeData()
		{
			AnimsetHashes = new();
			Overrides = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
