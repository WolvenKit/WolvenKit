using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ResolveSensorDeviceBehaviour : redEvent
	{
		private CInt32 _iteration;

		[Ordinal(0)] 
		[RED("iteration")] 
		public CInt32 Iteration
		{
			get => GetProperty(ref _iteration);
			set => SetProperty(ref _iteration, value);
		}
	}
}
