using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSmartObjectPropertyDictionary : ISerializable
	{
		private CArray<gameSmartObjectPropertyDictionaryPropertyEntry> _properties;

		[Ordinal(0)] 
		[RED("properties")] 
		public CArray<gameSmartObjectPropertyDictionaryPropertyEntry> Properties
		{
			get => GetProperty(ref _properties);
			set => SetProperty(ref _properties, value);
		}
	}
}
