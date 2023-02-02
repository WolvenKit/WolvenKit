using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSmartObjectTransformSequenceDictionaryEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("sequence")] 
		public CArray<CUInt16> Sequence
		{
			get => GetPropertyValue<CArray<CUInt16>>();
			set => SetPropertyValue<CArray<CUInt16>>(value);
		}

		[Ordinal(1)] 
		[RED("id")] 
		public CUInt8 Id
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		public gameSmartObjectTransformSequenceDictionaryEntry()
		{
			Sequence = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
