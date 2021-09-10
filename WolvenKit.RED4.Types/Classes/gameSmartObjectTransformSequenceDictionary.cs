using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSmartObjectTransformSequenceDictionary : ISerializable
	{
		[Ordinal(0)] 
		[RED("sequences")] 
		public CArray<gameSmartObjectTransformSequenceDictionaryEntry> Sequences
		{
			get => GetPropertyValue<CArray<gameSmartObjectTransformSequenceDictionaryEntry>>();
			set => SetPropertyValue<CArray<gameSmartObjectTransformSequenceDictionaryEntry>>(value);
		}

		public gameSmartObjectTransformSequenceDictionary()
		{
			Sequences = new();
		}
	}
}
