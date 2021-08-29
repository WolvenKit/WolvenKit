using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SampleMapArrayElement : RedBaseClass
	{
		private CUInt32 _myKey;
		private CString _someStringProperty;
		private CArray<CString> _someArrayProperty;

		[Ordinal(0)] 
		[RED("myKey")] 
		public CUInt32 MyKey
		{
			get => GetProperty(ref _myKey);
			set => SetProperty(ref _myKey, value);
		}

		[Ordinal(1)] 
		[RED("someStringProperty")] 
		public CString SomeStringProperty
		{
			get => GetProperty(ref _someStringProperty);
			set => SetProperty(ref _someStringProperty, value);
		}

		[Ordinal(2)] 
		[RED("someArrayProperty")] 
		public CArray<CString> SomeArrayProperty
		{
			get => GetProperty(ref _someArrayProperty);
			set => SetProperty(ref _someArrayProperty, value);
		}
	}
}
