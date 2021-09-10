using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSmartObjectPropertyDictionary : ISerializable
	{
		[Ordinal(0)] 
		[RED("properties")] 
		public CArray<gameSmartObjectPropertyDictionaryPropertyEntry> Properties
		{
			get => GetPropertyValue<CArray<gameSmartObjectPropertyDictionaryPropertyEntry>>();
			set => SetPropertyValue<CArray<gameSmartObjectPropertyDictionaryPropertyEntry>>(value);
		}

		public gameSmartObjectPropertyDictionary()
		{
			Properties = new();
		}
	}
}
