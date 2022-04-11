using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectObjectProvider_SweepOverTime_Sphere : gameEffectObjectProvider_SweepOverTime
	{
		[Ordinal(2)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameEffectObjectProvider_SweepOverTime_Sphere()
		{
			QueryPreset = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
