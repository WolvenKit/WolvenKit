using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Quaternion : RedBaseClass
	{
		private CFloat _i;
		private CFloat _j;
		private CFloat _k;
		private CFloat _r;

		[Ordinal(0)] 
		[RED("i")] 
		public CFloat I
		{
			get => GetProperty(ref _i);
			set => SetProperty(ref _i, value);
		}

		[Ordinal(1)] 
		[RED("j")] 
		public CFloat J
		{
			get => GetProperty(ref _j);
			set => SetProperty(ref _j, value);
		}

		[Ordinal(2)] 
		[RED("k")] 
		public CFloat K
		{
			get => GetProperty(ref _k);
			set => SetProperty(ref _k, value);
		}

		[Ordinal(3)] 
		[RED("r")] 
		public CFloat R
		{
			get => GetProperty(ref _r);
			set => SetProperty(ref _r, value);
		}

		public Quaternion()
		{
			_r = 1.000000F;
		}
	}
}
