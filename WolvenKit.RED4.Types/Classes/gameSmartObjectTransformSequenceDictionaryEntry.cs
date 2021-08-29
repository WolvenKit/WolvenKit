using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSmartObjectTransformSequenceDictionaryEntry : RedBaseClass
	{
		private CArray<CUInt16> _sequence;
		private CUInt8 _id;

		[Ordinal(0)] 
		[RED("sequence")] 
		public CArray<CUInt16> Sequence
		{
			get => GetProperty(ref _sequence);
			set => SetProperty(ref _sequence, value);
		}

		[Ordinal(1)] 
		[RED("id")] 
		public CUInt8 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}
	}
}
