using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimProfilerData_TimingsRoot : ISerializable
	{
		[Ordinal(0)] 
		[RED("timings")] 
		public CArray<animAnimProfilerData_Timings> Timings
		{
			get => GetPropertyValue<CArray<animAnimProfilerData_Timings>>();
			set => SetPropertyValue<CArray<animAnimProfilerData_Timings>>(value);
		}

		public animAnimProfilerData_TimingsRoot()
		{
			Timings = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
