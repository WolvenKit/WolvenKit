using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class physicsSimulationFilter : RedBaseClass
	{
		private CUInt64 _mask1;
		private CUInt64 _mask2;

		[Ordinal(0)] 
		[RED("mask1")] 
		public CUInt64 Mask1
		{
			get => GetProperty(ref _mask1);
			set => SetProperty(ref _mask1, value);
		}

		[Ordinal(1)] 
		[RED("mask2")] 
		public CUInt64 Mask2
		{
			get => GetProperty(ref _mask2);
			set => SetProperty(ref _mask2, value);
		}
	}
}
