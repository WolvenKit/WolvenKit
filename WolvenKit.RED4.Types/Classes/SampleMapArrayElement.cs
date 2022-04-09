using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SampleMapArrayElement : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("myKey")] 
		public CUInt32 MyKey
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("someStringProperty")] 
		public CString SomeStringProperty
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("someArrayProperty")] 
		public CArray<CString> SomeArrayProperty
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		public SampleMapArrayElement()
		{
			SomeArrayProperty = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
