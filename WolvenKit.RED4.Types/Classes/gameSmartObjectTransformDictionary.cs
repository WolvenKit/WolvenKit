using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSmartObjectTransformDictionary : ISerializable
	{
		[Ordinal(0)] 
		[RED("transforms")] 
		public CArray<gameSmartObjectTransformDictionaryTransformEntry> Transforms
		{
			get => GetPropertyValue<CArray<gameSmartObjectTransformDictionaryTransformEntry>>();
			set => SetPropertyValue<CArray<gameSmartObjectTransformDictionaryTransformEntry>>(value);
		}

		public gameSmartObjectTransformDictionary()
		{
			Transforms = new();
		}
	}
}
