using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Point : RedBaseClass
	{
		private CInt32 _x;
		private CInt32 _y;

		[Ordinal(0)] 
		[RED("x")] 
		public CInt32 X
		{
			get => GetProperty(ref _x);
			set => SetProperty(ref _x, value);
		}

		[Ordinal(1)] 
		[RED("y")] 
		public CInt32 Y
		{
			get => GetProperty(ref _y);
			set => SetProperty(ref _y, value);
		}
	}
}
