using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class interopUint64Pair : RedBaseClass
	{
		private CUInt64 _first;
		private CUInt64 _second;

		[Ordinal(0)] 
		[RED("first")] 
		public CUInt64 First
		{
			get => GetProperty(ref _first);
			set => SetProperty(ref _first, value);
		}

		[Ordinal(1)] 
		[RED("second")] 
		public CUInt64 Second
		{
			get => GetProperty(ref _second);
			set => SetProperty(ref _second, value);
		}
	}
}
