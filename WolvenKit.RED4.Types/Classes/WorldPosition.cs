using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WorldPosition : RedBaseClass
	{
		private FixedPoint _x;
		private FixedPoint _y;
		private FixedPoint _z;

		[Ordinal(0)] 
		[RED("x")] 
		public FixedPoint X
		{
			get => GetProperty(ref _x);
			set => SetProperty(ref _x, value);
		}

		[Ordinal(1)] 
		[RED("y")] 
		public FixedPoint Y
		{
			get => GetProperty(ref _y);
			set => SetProperty(ref _y, value);
		}

		[Ordinal(2)] 
		[RED("z")] 
		public FixedPoint Z
		{
			get => GetProperty(ref _z);
			set => SetProperty(ref _z, value);
		}
	}
}
