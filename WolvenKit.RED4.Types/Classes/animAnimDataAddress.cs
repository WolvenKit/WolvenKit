using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimDataAddress : RedBaseClass
	{
		private CUInt32 _unkIndex;
		private CUInt32 _fsetInBytes;
		private CUInt32 _zeInBytes;

		[Ordinal(0)] 
		[RED("unkIndex")] 
		public CUInt32 UnkIndex
		{
			get => GetProperty(ref _unkIndex);
			set => SetProperty(ref _unkIndex, value);
		}

		[Ordinal(1)] 
		[RED("fsetInBytes")] 
		public CUInt32 FsetInBytes
		{
			get => GetProperty(ref _fsetInBytes);
			set => SetProperty(ref _fsetInBytes, value);
		}

		[Ordinal(2)] 
		[RED("zeInBytes")] 
		public CUInt32 ZeInBytes
		{
			get => GetProperty(ref _zeInBytes);
			set => SetProperty(ref _zeInBytes, value);
		}

		public animAnimDataAddress()
		{
			_unkIndex = 4294967295;
			_fsetInBytes = 4294967295;
			_zeInBytes = 4294967295;
		}
	}
}
