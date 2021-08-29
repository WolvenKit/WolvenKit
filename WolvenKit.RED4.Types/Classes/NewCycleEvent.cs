using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NewCycleEvent : redEvent
	{
		private CUInt16 _cyclesCount;

		[Ordinal(0)] 
		[RED("cyclesCount")] 
		public CUInt16 CyclesCount
		{
			get => GetProperty(ref _cyclesCount);
			set => SetProperty(ref _cyclesCount, value);
		}
	}
}
