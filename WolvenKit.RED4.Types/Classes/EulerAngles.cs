using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EulerAngles : RedBaseClass
	{
		private CFloat _pitch;
		private CFloat _yaw;
		private CFloat _roll;

		[Ordinal(0)] 
		[RED("Pitch")] 
		public CFloat Pitch
		{
			get => GetProperty(ref _pitch);
			set => SetProperty(ref _pitch, value);
		}

		[Ordinal(1)] 
		[RED("Yaw")] 
		public CFloat Yaw
		{
			get => GetProperty(ref _yaw);
			set => SetProperty(ref _yaw, value);
		}

		[Ordinal(2)] 
		[RED("Roll")] 
		public CFloat Roll
		{
			get => GetProperty(ref _roll);
			set => SetProperty(ref _roll, value);
		}
	}
}
