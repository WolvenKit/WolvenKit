using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CColor : RedBaseClass
	{
		private CUInt8 _red;
		private CUInt8 _green;
		private CUInt8 _blue;
		private CUInt8 _alpha;

		[Ordinal(0)] 
		[RED("Red")] 
		public CUInt8 Red
		{
			get => GetProperty(ref _red);
			set => SetProperty(ref _red, value);
		}

		[Ordinal(1)] 
		[RED("Green")] 
		public CUInt8 Green
		{
			get => GetProperty(ref _green);
			set => SetProperty(ref _green, value);
		}

		[Ordinal(2)] 
		[RED("Blue")] 
		public CUInt8 Blue
		{
			get => GetProperty(ref _blue);
			set => SetProperty(ref _blue, value);
		}

		[Ordinal(3)] 
		[RED("Alpha")] 
		public CUInt8 Alpha
		{
			get => GetProperty(ref _alpha);
			set => SetProperty(ref _alpha, value);
		}
	}
}
