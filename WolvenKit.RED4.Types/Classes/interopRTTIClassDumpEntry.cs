using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class interopRTTIClassDumpEntry : RedBaseClass
	{
		private CInt32 _i;
		private CInt32 _b;
		private CInt32 _r;
		private CInt32 _a;

		[Ordinal(0)] 
		[RED("i")] 
		public CInt32 I
		{
			get => GetProperty(ref _i);
			set => SetProperty(ref _i, value);
		}

		[Ordinal(1)] 
		[RED("b")] 
		public CInt32 B
		{
			get => GetProperty(ref _b);
			set => SetProperty(ref _b, value);
		}

		[Ordinal(2)] 
		[RED("r")] 
		public CInt32 R
		{
			get => GetProperty(ref _r);
			set => SetProperty(ref _r, value);
		}

		[Ordinal(3)] 
		[RED("a")] 
		public CInt32 A
		{
			get => GetProperty(ref _a);
			set => SetProperty(ref _a, value);
		}

		public interopRTTIClassDumpEntry()
		{
			_i = -1;
			_b = -1;
			_r = -1;
		}
	}
}
