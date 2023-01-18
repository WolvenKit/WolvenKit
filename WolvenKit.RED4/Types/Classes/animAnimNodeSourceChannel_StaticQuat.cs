using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNodeSourceChannel_StaticQuat : animIAnimNodeSourceChannel_Quat
	{
		[Ordinal(0)] 
		[RED("data")] 
		public Quaternion Data
		{
			get => GetPropertyValue<Quaternion>();
			set => SetPropertyValue<Quaternion>(value);
		}

		public animAnimNodeSourceChannel_StaticQuat()
		{
			Data = new() { R = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
