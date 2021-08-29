using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSmartObjectTransformSequenceDictionary : ISerializable
	{
		private CArray<gameSmartObjectTransformSequenceDictionaryEntry> _sequences;

		[Ordinal(0)] 
		[RED("sequences")] 
		public CArray<gameSmartObjectTransformSequenceDictionaryEntry> Sequences
		{
			get => GetProperty(ref _sequences);
			set => SetProperty(ref _sequences, value);
		}
	}
}
