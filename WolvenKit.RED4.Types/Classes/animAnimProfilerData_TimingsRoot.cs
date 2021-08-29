using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimProfilerData_TimingsRoot : ISerializable
	{
		private CArray<animAnimProfilerData_Timings> _timings;

		[Ordinal(0)] 
		[RED("timings")] 
		public CArray<animAnimProfilerData_Timings> Timings
		{
			get => GetProperty(ref _timings);
			set => SetProperty(ref _timings, value);
		}
	}
}
