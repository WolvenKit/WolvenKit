using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class interopStringUint64Pair : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("string")] 
		public CString String
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("number")] 
		public CUInt64 Number
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		public interopStringUint64Pair()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
