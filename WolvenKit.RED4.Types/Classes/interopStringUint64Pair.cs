using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class interopStringUint64Pair : RedBaseClass
	{
		private CString _string;
		private CUInt64 _number;

		[Ordinal(0)] 
		[RED("string")] 
		public CString String
		{
			get => GetProperty(ref _string);
			set => SetProperty(ref _string, value);
		}

		[Ordinal(1)] 
		[RED("number")] 
		public CUInt64 Number
		{
			get => GetProperty(ref _number);
			set => SetProperty(ref _number, value);
		}
	}
}
